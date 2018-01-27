namespace Ignition.Foundation.Search.Results
{
    public class SearchOptionsFactory : ISearchOptionsFactory
    {
        //private readonly ISortByMethod _sortbyMethod;
        //public SearchOptionsFactory(ISortByMethod sortbyMethod)
        //{
        //    _sortbyMethod = sortbyMethod;
        //}

        public ISearchOptions<T> CreateSearchOptions<T>() => new IgnitionSearchOptions<T>();
    }
}
