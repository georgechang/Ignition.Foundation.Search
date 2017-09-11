using Ignition.Foundation.Search.Context;
using Ignition.Foundation.Search.Managers;
using Ignition.Foundation.Search.Results;
using Ignition.Foundation.Search.Sort;
using SimpleInjector;
using SimpleInjector.Packaging;

namespace Ignition.Foundation.Search
{
    public class SearchInstaller : IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register<ISearchManagerFactory, SearchManagerFactory>(Lifestyle.Transient);
            container.Register<ISearchContextFactory, SearchContextFactory>(Lifestyle.Transient);
            container.Register<ISearchOptionsFactory, SearchOptionsFactory>(Lifestyle.Transient);
            //container.Register<ISortByMethod, SortByMethod>(Lifestyle.Scoped);
        }
    }
}