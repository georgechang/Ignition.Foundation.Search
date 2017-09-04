using Glass.Mapper.Sc;
using Ignition.Foundation.Search.Indexes;
using Ignition.Foundation.Search.Results;

namespace Ignition.Foundation.Search.Managers
{
    public interface ISearchManagerFactory
    {
        ISearchManager GetSearchManager<T>() where T : IIgnitionSearchIndex;
    }
}