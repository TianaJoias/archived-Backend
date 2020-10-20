﻿using Domain;
using Domain.Portifolio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EF.EFMappers.Portifolio
{
    internal class TagMapper : EntityMapper<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> builder)
        {
            base.Configure(builder);
            builder.ToTable("Tags");
            builder.Property(x => x.Name);
        }
    }
}