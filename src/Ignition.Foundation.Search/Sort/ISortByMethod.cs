using System.Linq;

namespace Ignition.Foundation.Search.Sort
{
    public interface ISortByMethod
    {
        IQueryable<T> SortResults<T>(IQueryable<T> results, bool descending = false);
    }
}