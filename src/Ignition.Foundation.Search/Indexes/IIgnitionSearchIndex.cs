using Sitecore.ContentSearch;

namespace Ignition.Foundation.Search.Indexes
{
    public interface IIgnitionSearchIndex
    {
        IProviderSearchContext GetSearchContext();
        string IndexName { get; }
    }
}