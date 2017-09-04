namespace Ignition.Foundation.Search.Results
{
    public interface ISearchOptionsFactory
    {
        ISearchOptions<T> CreateSearchOptions<T>();
    }
}