using Ignition.Foundation.Search.Indexes;
using Sitecore.ContentSearch;

namespace Ignition.Foundation.Search.Context
{
    public class SearchContextFactory : ISearchContextFactory
    {
        public IProviderSearchContext GetSearchContext(IIgnitionSearchIndex searchIndex)
        {
            return ContentSearchManager.GetIndex(searchIndex.IndexName).CreateSearchContext();
        }
    }
}