using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Ignition.Foundation.Search.Sort;
using Sitecore.ContentSearch.SearchTypes;

namespace Ignition.Foundation.Search.Results
{
    public abstract class IgnitionSearchResultItem : SearchResultItem
    {
        [RelevanceSortByField]
        public string Test { get; set; }

        protected string TypeName => GetType().Name;
    }
}