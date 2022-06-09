using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class ListItem : BaseItem, IParsable {
        /// <summary>Analytics about the view activities that took place on this item.</summary>
        public ItemAnalytics Analytics { get; set; }
        /// <summary>The content type of this list item</summary>
        public ContentTypeInfo ContentType { get; set; }
        /// <summary>For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]</summary>
        public ApiSdk.Models.DriveItem DriveItem { get; set; }
        /// <summary>The values of the columns set on this list item.</summary>
        public FieldValueSet Fields { get; set; }
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
        public ApiSdk.Models.SharepointIds SharepointIds { get; set; }
        /// <summary>The list of previous versions of the list item.</summary>
        public List<ListItemVersion> Versions { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ListItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ListItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"analytics", n => { Analytics = n.GetObjectValue<ItemAnalytics>(ItemAnalytics.CreateFromDiscriminatorValue); } },
                {"contentType", n => { ContentType = n.GetObjectValue<ContentTypeInfo>(ContentTypeInfo.CreateFromDiscriminatorValue); } },
                {"driveItem", n => { DriveItem = n.GetObjectValue<ApiSdk.Models.DriveItem>(ApiSdk.Models.DriveItem.CreateFromDiscriminatorValue); } },
                {"fields", n => { Fields = n.GetObjectValue<FieldValueSet>(FieldValueSet.CreateFromDiscriminatorValue); } },
                {"sharepointIds", n => { SharepointIds = n.GetObjectValue<ApiSdk.Models.SharepointIds>(ApiSdk.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"versions", n => { Versions = n.GetCollectionOfObjectValues<ListItemVersion>(ListItemVersion.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ItemAnalytics>("analytics", Analytics);
            writer.WriteObjectValue<ContentTypeInfo>("contentType", ContentType);
            writer.WriteObjectValue<ApiSdk.Models.DriveItem>("driveItem", DriveItem);
            writer.WriteObjectValue<FieldValueSet>("fields", Fields);
            writer.WriteObjectValue<ApiSdk.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteCollectionOfObjectValues<ListItemVersion>("versions", Versions);
        }
    }
}
