﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Application.Specification
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        List<(Expression<Func<T, object>> expression, SortDirection direction)> OrderBy { get; }
    }
}
