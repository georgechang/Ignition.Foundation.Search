using System;
using Ignition.Foundation.Search.Context;
using Ignition.Foundation.Search.Indexes;
using Ignition.Foundation.Search.Results;

namespace Ignition.Foundation.Search.Managers
{
    public class SearchManagerFactory : ISearchManagerFactory
    {
        private readonly ISearchContextFactory _searchContextFactory;
        private readonly ISearchOptionsFactory _searchOptionsFactory;

        public SearchManagerFactory(ISearchContextFactory searchContextFactory, ISearchOptionsFactory searchOptionsFactory)
        {
            _searchContextFactory = searchContextFactory;
            _searchOptionsFactory = searchOptionsFactory;
        }

        public ISearchManager GetSearchManager<T>() where T : IIgnitionSearchIndex
        {
            return new SearchManager((T)Activator.CreateInstance(typeof(T), _searchContextFactory), _searchOptionsFactory);
        }
    }
}
