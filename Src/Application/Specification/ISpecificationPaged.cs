﻿namespace Application.Specification
{
    public interface ISpecificationPaged<T> : ISpecification<T>
    {
        int PageNumber { get; }
        int PageSize { get; }
    }
}
