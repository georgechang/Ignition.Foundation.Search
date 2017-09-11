using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;

namespace Ignition.Foundation.Search.Results
{
    public interface ISearchOptions<T>
    {
        string Query { get; set; }
        Expression<Func<T, bool>> Predicate { get; set; }
        CultureInfo CultureInfo { get; set; }
        Expression<Func<T, bool>> Filter { get; set; }
        int? PageNumber { get; set; }
        int? ResultsPerPage { get; set; }
        Expression<Func<T, object>> OrderByExpression { get; set; }
        OrderByDirection OrderByDirection { get; set; }
    }

    public enum OrderByDirection
    {
        Ascending,
        Descending
    }
}