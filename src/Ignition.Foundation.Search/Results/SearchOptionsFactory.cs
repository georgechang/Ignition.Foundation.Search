using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ignition.Foundation.Search.Sort;

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
