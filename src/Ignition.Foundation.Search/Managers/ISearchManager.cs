using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using Ignition.Foundation.Search.Results;

namespace Ignition.Foundation.Search.Managers
{
    public interface ISearchManager
    {
        ISearchOptions<T> CreateSearchOptions<T>();
        IEnumerable<T> GetSearchResults<T>(CultureInfo cultureInfo, Expression<Func<T, bool>> predicate = null);
        IEnumerable<T> GetSearchResults<T>(ISearchOptions<T> options);
    }
}