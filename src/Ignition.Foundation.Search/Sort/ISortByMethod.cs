using System.Collections.Generic;
using System.Linq;
using Ignition.Foundation.Search.Results;

namespace Ignition.Foundation.Search.Sort
{
    public interface ISortByMethod
    {
        IEnumerable<T> SortResults<T, TU>(IOrderedEnumerable<T> results) where T : IgnitionSearchResultItem;
    }
}