using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class List : BaseItem, IParsable {
        /// <summary>The collection of field definitions for this list.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ColumnDefinition> Columns { get; set; }
        /// <summary>The collection of content types present in this list.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ContentType> ContentTypes { get; set; }
        /// <summary>The displayable title of the list.</summary>
        public string DisplayName { get; set; }
        /// <summary>Only present on document libraries. Allows access to the list as a [drive][] resource with [driveItems][driveItem].</summary>
        public ApiSdk.Models.Microsoft.Graph.Drive Drive { get; set; }
        /// <summary>All items contained in the list.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ListItem> Items { get; set; }
        /// <summary>Provides additional details about the list.</summary>
        public ApiSdk.Models.Microsoft.Graph.ListInfo List_prop { get; set; }
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.SharepointIds SharepointIds { get; set; }
        /// <summary>The set of subscriptions on the list.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Subscription> Subscriptions { get; set; }
        /// <summary>If present, indicates that this is a system-managed list. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.SystemFacet System { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.List CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new List();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"columns", (o,n) => { (o as List).Columns = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ColumnDefinition>(ApiSdk.Models.Microsoft.Graph.ColumnDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"contentTypes", (o,n) => { (o as List).ContentTypes = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ContentType>(ApiSdk.Models.Microsoft.Graph.ContentType.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", (o,n) => { (o as List).DisplayName = n.GetStringValue(); } },
                {"drive", (o,n) => { (o as List).Drive = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Drive>(ApiSdk.Models.Microsoft.Graph.Drive.CreateFromDiscriminatorValue); } },
                {"items", (o,n) => { (o as List).Items = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ListItem>(ApiSdk.Models.Microsoft.Graph.ListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"list", (o,n) => { (o as List).List_prop = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ListInfo>(ApiSdk.Models.Microsoft.Graph.ListInfo.CreateFromDiscriminatorValue); } },
                {"sharepointIds", (o,n) => { (o as List).SharepointIds = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SharepointIds>(ApiSdk.Models.Microsoft.Graph.SharepointIds.CreateFromDiscriminatorValue); } },
                {"subscriptions", (o,n) => { (o as List).Subscriptions = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Subscription>(ApiSdk.Models.Microsoft.Graph.Subscription.CreateFromDiscriminatorValue).ToList(); } },
                {"system", (o,n) => { (o as List).System = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SystemFacet>(ApiSdk.Models.Microsoft.Graph.SystemFacet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ColumnDefinition>("columns", Columns);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ContentType>("contentTypes", ContentTypes);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Drive>("drive", Drive);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ListItem>("items", Items);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ListInfo>("list", List_prop);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Subscription>("subscriptions", Subscriptions);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SystemFacet>("system", System);
        }
    }
}
