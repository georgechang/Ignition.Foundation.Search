using Ignition.Foundation.Search.Context;
using Ignition.Foundation.Search.Managers;
using Ignition.Foundation.Search.Results;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Ignition.Foundation.Search
{
    public class SearchConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<ISearchManagerFactory, SearchManagerFactory>();
            serviceCollection.AddSingleton<ISearchContextFactory, SearchContextFactory>();
            serviceCollection.AddSingleton<ISearchOptionsFactory, SearchOptionsFactory>();
        }
    }
}