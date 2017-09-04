using Ignition.Foundation.Search.Indexes;
using Sitecore.ContentSearch;

namespace Ignition.Foundation.Search.Context
{
    public interface ISearchContextFactory
    {
        IProviderSearchContext GetSearchContext(IIgnitionSearchIndex searchIndex);
    }
}