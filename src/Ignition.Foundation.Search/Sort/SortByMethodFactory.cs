using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignition.Foundation.Search.Sort
{
    public class SortByMethodFactory : ISortByMethodFactory
    {
        private readonly ISortByMethod _sortByMethod;
        public SortByMethodFactory(ISortByMethod method)
        {
            _sortByMethod = method;
        }

        public ISortByMethod GetSortByMethod<T>() where T : ISortByFieldAttribute
        {
            return null;
        }
    }
}
