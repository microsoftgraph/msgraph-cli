// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class SharedDriveItem : global::ApiSdk.Models.BaseItem, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Used to access the underlying driveItem</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DriveItem? DriveItem { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DriveItem DriveItem { get; set; }
#endif
        /// <summary>All driveItems contained in the sharing root. This collection cannot be enumerated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DriveItem>? Items { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DriveItem> Items { get; set; }
#endif
        /// <summary>Used to access the underlying list</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.List? List { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.List List { get; set; }
#endif
        /// <summary>Used to access the underlying listItem</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ListItem? ListItem { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ListItem ListItem { get; set; }
#endif
        /// <summary>Information about the owner of the shared item being referenced.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySet? Owner { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySet Owner { get; set; }
#endif
        /// <summary>Used to access the permission representing the underlying sharing link</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Permission? Permission { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Permission Permission { get; set; }
#endif
        /// <summary>Used to access the underlying driveItem. Deprecated -- use driveItem instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DriveItem? Root { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DriveItem Root { get; set; }
#endif
        /// <summary>Used to access the underlying site</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Site? Site { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Site Site { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.SharedDriveItem"/> and sets the default values.
        /// </summary>
        public SharedDriveItem() : base()
        {
            OdataType = "#microsoft.graph.sharedDriveItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.SharedDriveItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.SharedDriveItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.SharedDriveItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "driveItem", n => { DriveItem = n.GetObjectValue<global::ApiSdk.Models.DriveItem>(global::ApiSdk.Models.DriveItem.CreateFromDiscriminatorValue); } },
                { "items", n => { Items = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DriveItem>(global::ApiSdk.Models.DriveItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "list", n => { List = n.GetObjectValue<global::ApiSdk.Models.List>(global::ApiSdk.Models.List.CreateFromDiscriminatorValue); } },
                { "listItem", n => { ListItem = n.GetObjectValue<global::ApiSdk.Models.ListItem>(global::ApiSdk.Models.ListItem.CreateFromDiscriminatorValue); } },
                { "owner", n => { Owner = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "permission", n => { Permission = n.GetObjectValue<global::ApiSdk.Models.Permission>(global::ApiSdk.Models.Permission.CreateFromDiscriminatorValue); } },
                { "root", n => { Root = n.GetObjectValue<global::ApiSdk.Models.DriveItem>(global::ApiSdk.Models.DriveItem.CreateFromDiscriminatorValue); } },
                { "site", n => { Site = n.GetObjectValue<global::ApiSdk.Models.Site>(global::ApiSdk.Models.Site.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::ApiSdk.Models.DriveItem>("driveItem", DriveItem);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DriveItem>("items", Items);
            writer.WriteObjectValue<global::ApiSdk.Models.List>("list", List);
            writer.WriteObjectValue<global::ApiSdk.Models.ListItem>("listItem", ListItem);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("owner", Owner);
            writer.WriteObjectValue<global::ApiSdk.Models.Permission>("permission", Permission);
            writer.WriteObjectValue<global::ApiSdk.Models.DriveItem>("root", Root);
            writer.WriteObjectValue<global::ApiSdk.Models.Site>("site", Site);
        }
    }
}
#pragma warning restore CS0618
