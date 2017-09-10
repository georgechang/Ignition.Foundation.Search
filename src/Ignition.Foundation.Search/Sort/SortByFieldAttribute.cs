using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Ignition.Foundation.Search.Results;

namespace Ignition.Foundation.Search.Sort
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public abstract class SortByFieldAttribute : Attribute, ISortByFieldAttribute
    {
    }
}