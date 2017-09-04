using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using Ignition.Foundation.Search.Sort;

namespace Ignition.Foundation.Search.Results
{
    public class IgnitionSearchOptions<T> : ISearchOptions<T>
    {
        private ISortByMethod _sortByMethod;

        public IgnitionSearchOptions(ISortByMethod sortByMethod)
        {
            _sortByMethod = sortByMethod;
        }

        public Expression<Func<T, bool>> Predicate { get; set; }
        public CultureInfo CultureInfo { get; set; }
        public Expression<Func<T, bool>> Filter { get; set; }
    }
}