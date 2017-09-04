using Ignition.Foundation.Search.Context;
using Sitecore.ContentSearch;

namespace Ignition.Foundation.Search.Indexes
{
    public abstract class IgnitionSearchIndex : IIgnitionSearchIndex
    {
        private readonly ISearchContextFactory _factory;

        protected IgnitionSearchIndex(ISearchContextFactory factory)
        {
            _factory = factory;
        }

        public IProviderSearchContext GetSearchContext() => _factory.GetSearchContext(this);
        public abstract string IndexName { get; }
    }
}