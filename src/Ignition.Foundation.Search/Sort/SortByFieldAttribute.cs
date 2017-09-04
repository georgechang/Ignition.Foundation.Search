using System;

namespace Ignition.Foundation.Search.Sort
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SortByFieldAttribute : Attribute
    {
        public readonly Type SortByMethodType;

        public SortByFieldAttribute(Type sortByMethodType)
        {
            SortByMethodType = sortByMethodType;
        }
    }
}