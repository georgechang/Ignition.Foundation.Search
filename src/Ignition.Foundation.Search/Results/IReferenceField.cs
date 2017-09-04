using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ignition.Foundation.Search.Results
{
    public interface IReferenceField<T>
    {
        Expression<Func<T, object>> ReferencedItem { get; set; }
        Type ResultType { get; set; }
    }
}
