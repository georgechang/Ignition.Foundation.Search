using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;

namespace Ignition.Foundation.Search.Results
{
    public interface ISearchOptions<T>
    {
        Expression<Func<T, bool>> Predicate { get; set; }
        CultureInfo CultureInfo { get; set; }
        Expression<Func<T, bool>> Filter { get; set; }
    }
}