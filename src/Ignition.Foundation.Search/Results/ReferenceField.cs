using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ignition.Foundation.Search.Results
{
    public class ReferenceField<T> : IReferenceField<T>
    {
        public Expression<Func<T, object>> ReferencedItem { get; set; }
        public Type ResultType { get; set; }
    }
}
