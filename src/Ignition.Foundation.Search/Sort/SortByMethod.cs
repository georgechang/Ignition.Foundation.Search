using System;
using System.Linq;
using System.Linq.Expressions;

namespace Ignition.Foundation.Search.Sort
{
    public class SortByMethod : ISortByMethod
    {
        protected Expression<Func<T, object>> GetSortField<T>()
        {
            var properties = typeof(T).GetProperties();

            foreach (var propertyInfo in properties)
            {
                var sortByFieldAttribute = propertyInfo.CustomAttributes.FirstOrDefault(x => x.AttributeType == typeof(SortByFieldAttribute));

                if (sortByFieldAttribute == null) continue;
                var parameter = Expression.Parameter(typeof(T));
                var property = Expression.Property(parameter, propertyInfo);
                var conversion = Expression.Convert(property, typeof(object));
                return Expression.Lambda<Func<T, object>>(conversion, parameter);
            }
            return null;
        }

        public IQueryable<T> SortResults<T>(IQueryable<T> results, bool descending = false) => GetSortField<T>() != null ? (descending ? results.OrderByDescending(GetSortField<T>()) : results.OrderBy(GetSortField<T>())) : results.AsQueryable();
    }
}