using System.Xml;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.ComputedFields;
using Sitecore.Data.Items;
using Sitecore.Links;
using Sitecore.Sites;
using Sitecore.Xml;

namespace Ignition.Foundation.Search.ComputedFields
{
    public class PageUrlComputedIndexField : AbstractComputedIndexField
    {
        public PageUrlComputedIndexField(XmlNode configNode) : base(configNode)
        {
            SiteName = XmlUtil.GetAttribute("siteName", configNode);
        }

        private string SiteName { get; }

        public override object ComputeFieldValue(IIndexable indexable)
        {
            var indexableItem = indexable as SitecoreIndexableItem;
            var item = (Item)indexableItem;

            if (item?.Fields[Sitecore.FieldIDs.LayoutField] == null) return null;

            var urlOptions = new UrlOptions
            {
                LowercaseUrls = true,
                EncodeNames = true,
                LanguageEmbedding = LanguageEmbedding.Always,
                Language = item.Language,
                ShortenUrls = true,
                Site = SiteContext.GetSite(SiteName)
            };

            return LinkManager.GetItemUrl(item, urlOptions);
        }
    }
}
