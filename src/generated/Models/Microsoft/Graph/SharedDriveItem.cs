using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SharedDriveItem : BaseItem, IParsable {
        /// <summary>Used to access the underlying driveItem</summary>
        public ApiSdk.Models.Microsoft.Graph.DriveItem DriveItem { get; set; }
        /// <summary>All driveItems contained in the sharing root. This collection cannot be enumerated.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DriveItem> Items { get; set; }
        /// <summary>Used to access the underlying list</summary>
        public ApiSdk.Models.Microsoft.Graph.List List { get; set; }
        /// <summary>Used to access the underlying listItem</summary>
        public ApiSdk.Models.Microsoft.Graph.ListItem ListItem { get; set; }
        /// <summary>Information about the owner of the shared item being referenced.</summary>
        public IdentitySet Owner { get; set; }
        /// <summary>Used to access the permission representing the underlying sharing link</summary>
        public ApiSdk.Models.Microsoft.Graph.Permission Permission { get; set; }
        /// <summary>Used to access the underlying driveItem. Deprecated -- use driveItem instead.</summary>
        public ApiSdk.Models.Microsoft.Graph.DriveItem Root { get; set; }
        /// <summary>Used to access the underlying site</summary>
        public ApiSdk.Models.Microsoft.Graph.Site Site { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SharedDriveItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedDriveItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"driveItem", (o,n) => { (o as SharedDriveItem).DriveItem = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DriveItem>(ApiSdk.Models.Microsoft.Graph.DriveItem.CreateFromDiscriminatorValue); } },
                {"items", (o,n) => { (o as SharedDriveItem).Items = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DriveItem>(ApiSdk.Models.Microsoft.Graph.DriveItem.CreateFromDiscriminatorValue).ToList(); } },
                {"list", (o,n) => { (o as SharedDriveItem).List = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.List>(ApiSdk.Models.Microsoft.Graph.List.CreateFromDiscriminatorValue); } },
                {"listItem", (o,n) => { (o as SharedDriveItem).ListItem = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ListItem>(ApiSdk.Models.Microsoft.Graph.ListItem.CreateFromDiscriminatorValue); } },
                {"owner", (o,n) => { (o as SharedDriveItem).Owner = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"permission", (o,n) => { (o as SharedDriveItem).Permission = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Permission>(ApiSdk.Models.Microsoft.Graph.Permission.CreateFromDiscriminatorValue); } },
                {"root", (o,n) => { (o as SharedDriveItem).Root = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DriveItem>(ApiSdk.Models.Microsoft.Graph.DriveItem.CreateFromDiscriminatorValue); } },
                {"site", (o,n) => { (o as SharedDriveItem).Site = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Site>(ApiSdk.Models.Microsoft.Graph.Site.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DriveItem>("driveItem", DriveItem);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DriveItem>("items", Items);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.List>("list", List);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ListItem>("listItem", ListItem);
            writer.WriteObjectValue<IdentitySet>("owner", Owner);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Permission>("permission", Permission);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DriveItem>("root", Root);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Site>("site", Site);
        }
    }
}
