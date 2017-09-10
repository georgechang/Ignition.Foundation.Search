namespace Ignition.Foundation.Search.Sort
{
    public interface ISortByMethodFactory
    {
        ISortByMethod GetSortByMethod<T>() where T : ISortByFieldAttribute;
    }
}