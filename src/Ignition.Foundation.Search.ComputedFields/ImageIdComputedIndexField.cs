using System;
using System.Xml;

using Sitecore.ContentSearch;
using Sitecore.ContentSearch.ComputedFields;
using Sitecore.Data.Fields;
using Sitecore.Diagnostics;
using Sitecore.Xml;

namespace Ignition.Foundation.Search.ComputedFields
{
    public class ImageIdComputedIndexField : AbstractComputedIndexField
    {
        public ImageIdComputedIndexField(XmlNode configNode) : base(configNode)
        {
            this.ImageFieldName = XmlUtil.GetAttribute("imageFieldName", configNode);
        }

        private string ImageFieldName { get; }

        public override object ComputeFieldValue(IIndexable indexable)
        {
            Assert.ArgumentNotNull(indexable, "indexable");

            try
            {
                var indexItem = indexable as SitecoreIndexableItem;

                if (indexItem == null) return null;

                var item = indexItem.Item;

                ImageField img = item.Fields[this.ImageFieldName];

                return img?.MediaItem == null ? null : img.MediaID;
            }
            catch (Exception exc)
            {
                Log.Error($"An error occurred when indexing {indexable.Id}: {exc.Message}", exc, this);
            }

            return null;
        }
    }
}