using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using Ignition.Foundation.Search.Results;
using Sitecore.ContentSearch.Linq;
using Sitecore.ContentSearch.SearchTypes;

namespace Ignition.Foundation.Search.Managers
{
    public interface ISearchManager
    {
        ISearchOptions<T> CreateSearchOptions<T>();
        SearchResults<T> GetSearchResults<T>(CultureInfo cultureInfo, Expression<Func<T, bool>> predicate = null) where T : SearchResultItem;
        SearchResults<T> GetSearchResults<T>(ISearchOptions<T> options) where T : SearchResultItem;
    }
}