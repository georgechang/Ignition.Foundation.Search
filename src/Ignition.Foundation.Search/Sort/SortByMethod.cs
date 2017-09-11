using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Ignition.Foundation.Search.Results;
using Sitecore.ContentSearch.Utilities;

namespace Ignition.Foundation.Search.Sort
{
    public class SortByMethod : ISortByMethod
    {
        private readonly SortByFieldAttribute _sortByAttribute;

        protected SortByMethod(SortByFieldAttribute sortByAttribute)
        {
            _sortByAttribute = sortByAttribute;
        }

        public IEnumerable<T> SortResults<T, TU>(IOrderedEnumerable<T> results) where T : IgnitionSearchResultItem
        {
            var sortFields = new List<Expression<Func<T, TU>>>();
            var properties = typeof(T).GetProperties();

            foreach (var propertyInfo in properties)
            {
                // TODO: check if parameter matches current type
                var sortByFieldAttribute = propertyInfo.CustomAttributes.FirstOrDefault(x => x.AttributeType == _sortByAttribute.GetType());

                if (sortByFieldAttribute == null) continue;
                var parameter = Expression.Parameter(typeof(T));
                var property = Expression.Property(parameter, propertyInfo);
                var conversion = Expression.Convert(property, typeof(TU));
                sortFields.Add(Expression.Lambda<Func<T, TU>>(conversion, parameter));
            }

            return sortFields.Any() ? sortFields.Aggregate(results, (current, sortField) => current.ThenBy(x => sortField.Compile().Invoke(x))) : null;
        }
    }
}