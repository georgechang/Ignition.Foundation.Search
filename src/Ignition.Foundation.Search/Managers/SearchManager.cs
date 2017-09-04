﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Ignition.Foundation.Search.Indexes;
using Ignition.Foundation.Search.Results;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq;
using System.Linq;
using System.Linq.Expressions;
using Sitecore.ContentSearch.Linq.Utilities;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.ContentSearch.Utilities;
using Sitecore.Data;

namespace Ignition.Foundation.Search.Managers
{
    public class SearchManager : ISearchManager
    {
        private readonly IIgnitionSearchIndex _index;
        private readonly ISearchOptionsFactory _searchOptionsFactory;

        public SearchManager(IIgnitionSearchIndex index, ISearchOptionsFactory searchOptionsFactory)
        {
            _index = index;
            _searchOptionsFactory = searchOptionsFactory;
        }

        public ISearchOptions<T> CreateSearchOptions<T>() => _searchOptionsFactory.CreateSearchOptions<T>();

        public IEnumerable<T> GetSearchResults<T>(CultureInfo cultureInfo, Expression<Func<T, bool>> predicate = null)
        {
            var options = _searchOptionsFactory.CreateSearchOptions<T>();
            options.CultureInfo = cultureInfo;
            options.Predicate = predicate;
            return GetSearchResults(options);
        }

        public IEnumerable<T> GetSearchResults<T>(ISearchOptions<T> options)
        {
            using (var context = _index.GetSearchContext())
            {
                var results = context.GetQueryable<T>(new CultureExecutionContext(options.CultureInfo));

                // filter
                if (options.Filter != null)
                    results = results.Filter(options.Filter);

                // query
                if (options.Predicate != null)
                    results = results.Where(options.Predicate);

                // sort

                return results.ToList();
            }
        }
    }
}