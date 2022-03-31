using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ListItem : BaseItem, IParsable {
        /// <summary>Analytics about the view activities that took place on this item.</summary>
        public ApiSdk.Models.Microsoft.Graph.ItemAnalytics Analytics { get; set; }
        /// <summary>The content type of this list item</summary>
        public ApiSdk.Models.Microsoft.Graph.ContentTypeInfo ContentType { get; set; }
        /// <summary>For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]</summary>
        public ApiSdk.Models.Microsoft.Graph.DriveItem DriveItem { get; set; }
        /// <summary>The values of the columns set on this list item.</summary>
        public ApiSdk.Models.Microsoft.Graph.FieldValueSet Fields { get; set; }
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.SharepointIds SharepointIds { get; set; }
        /// <summary>The list of previous versions of the list item.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ListItemVersion> Versions { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.ListItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ListItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"analytics", (o,n) => { (o as ListItem).Analytics = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ItemAnalytics>(ApiSdk.Models.Microsoft.Graph.ItemAnalytics.CreateFromDiscriminatorValue); } },
                {"contentType", (o,n) => { (o as ListItem).ContentType = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ContentTypeInfo>(ApiSdk.Models.Microsoft.Graph.ContentTypeInfo.CreateFromDiscriminatorValue); } },
                {"driveItem", (o,n) => { (o as ListItem).DriveItem = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DriveItem>(ApiSdk.Models.Microsoft.Graph.DriveItem.CreateFromDiscriminatorValue); } },
                {"fields", (o,n) => { (o as ListItem).Fields = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.FieldValueSet>(ApiSdk.Models.Microsoft.Graph.FieldValueSet.CreateFromDiscriminatorValue); } },
                {"sharepointIds", (o,n) => { (o as ListItem).SharepointIds = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SharepointIds>(ApiSdk.Models.Microsoft.Graph.SharepointIds.CreateFromDiscriminatorValue); } },
                {"versions", (o,n) => { (o as ListItem).Versions = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ListItemVersion>(ApiSdk.Models.Microsoft.Graph.ListItemVersion.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ItemAnalytics>("analytics", Analytics);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ContentTypeInfo>("contentType", ContentType);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DriveItem>("driveItem", DriveItem);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.FieldValueSet>("fields", Fields);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ListItemVersion>("versions", Versions);
        }
    }
}
