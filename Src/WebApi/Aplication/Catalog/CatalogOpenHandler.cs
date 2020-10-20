﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using Domain.Catalog;
using Domain.Portifolio;
using Domain.Stock;
using FluentResults;
using MediatR;

namespace WebApi.Aplication.Catalog
{
    public class CatalogOpenHandler : AsyncRequestHandler<CatalogOpenCommand>, ICommandHandler<CatalogOpenCommand>
    {
        private readonly IProductRepository _product;
        private readonly ILotRepository _lotRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICatalogRepository _catalogRepository;
        private readonly IChannelRepository _channelRepository;

        public CatalogOpenHandler(IProductRepository product, ILotRepository lotRepository, IUnitOfWork unitOfWork, ICatalogRepository catalogRepository, IChannelRepository channelRepository)
        {
            _product = product;
            _lotRepository = lotRepository;
            _unitOfWork = unitOfWork;
            _catalogRepository = catalogRepository;
            _channelRepository = channelRepository;
        }


        protected override async Task Handle(CatalogOpenCommand request, CancellationToken cancellationToken)
        {
            var (channel, products, lots) = await GetData(request);
            var catalog = new Domain.Catalog.Catalog(channel);
            foreach (var item in request.Items)
            {
                var produt = products.First(it => it.Id == item.ProductId);
                var lot = lots.First(it => it.Id == item.LotId);
                catalog.Add(produt, lot, item.Quantity);
            }
            channel.SetCurrentCatalog(catalog);
            await _catalogRepository.Add(catalog);
            await _channelRepository.Update(channel);
            await _unitOfWork.Commit();
        }

        private async Task<(Channel channel, IList<Product> products, IList<Lot> lots)> GetData(CatalogOpenCommand request)
        {
            var productsIds = request.Items.Select(it => it.ProductId).ToList();
            var lotsIds = request.Items.Select(it => it.LotId).ToList();
            var productsTask = _product.List(it => productsIds.Contains(it.Id));
            var lotsTask = _lotRepository.List(it => lotsIds.Contains(it.Id));
            var channelTask = _channelRepository.GetByQuery(it => it.OwnerId == request.OwnerId);
            await Task.WhenAll(productsTask, lotsTask, channelTask);
            return (channel: await channelTask, products: await productsTask, lots: await lotsTask);
        }
    }

    public record CatalogOpenQueryResponse(Guid CatalogId, Guid OwnerId);

    public record CatalogOpenCommand : ICommand
    {
        public Guid OwnerId { get; init; }
        public IList<CatalogOpenItemCommand> Items { get; init; }
    }

    public record CatalogOpenItemCommand
    {
        public Guid ProductId { get; init; }
        public Guid LotId { get; init; }
        public decimal Quantity { get; init; }
    }
}