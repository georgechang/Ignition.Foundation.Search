using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using Ignition.Foundation.Search.Sort;

namespace Ignition.Foundation.Search.Results
{
    public class IgnitionSearchOptions<T> : ISearchOptions<T>
    {
        public string Query { get; set; }

        public Expression<Func<T, bool>> Predicate { get; set; }

        public CultureInfo CultureInfo { get; set; }

        public Expression<Func<T, bool>> Filter { get; set; }

        public int? PageNumber { get; set; }

        public int? ResultsPerPage { get; set; }

        public Expression<Func<T, object>> OrderByExpression { get; set; }

        public OrderByDirection OrderByDirection { get; set; }
    }
}