using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class SharePointIdentitySet : IdentitySet, IParsable {
        /// <summary>The group associated with this action. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? Group { get; set; }
#nullable restore
#else
        public Identity Group { get; set; }
#endif
        /// <summary>The SharePoint group associated with this action. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SharePointIdentity? SiteGroup { get; set; }
#nullable restore
#else
        public SharePointIdentity SiteGroup { get; set; }
#endif
        /// <summary>The SharePoint user associated with this action. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SharePointIdentity? SiteUser { get; set; }
#nullable restore
#else
        public SharePointIdentity SiteUser { get; set; }
#endif
        /// <summary>
        /// Instantiates a new SharePointIdentitySet and sets the default values.
        /// </summary>
        public SharePointIdentitySet() : base() {
            OdataType = "#microsoft.graph.sharePointIdentitySet";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SharePointIdentitySet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharePointIdentitySet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"group", n => { Group = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"siteGroup", n => { SiteGroup = n.GetObjectValue<SharePointIdentity>(SharePointIdentity.CreateFromDiscriminatorValue); } },
                {"siteUser", n => { SiteUser = n.GetObjectValue<SharePointIdentity>(SharePointIdentity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Identity>("group", Group);
            writer.WriteObjectValue<SharePointIdentity>("siteGroup", SiteGroup);
            writer.WriteObjectValue<SharePointIdentity>("siteUser", SiteUser);
        }
    }
}
