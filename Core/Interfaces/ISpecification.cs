﻿using System.Linq.Expressions;

namespace Core.Interfaces
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> criteria { get; }
        List<Expression<Func<T, object>>> includes { get; }
        Expression<Func<T, object>> OrderBy{ get; }
        Expression<Func<T, object>> OrderByDescending{ get; }
        int Take { get; }
        int Skip { get; }
        bool IsPagingEnabled { get; }


    }
}
