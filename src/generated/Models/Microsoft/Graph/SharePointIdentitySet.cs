using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SharePointIdentitySet : IdentitySet, IParsable {
        /// <summary>The group associated with this action. Optional.</summary>
        public ApiSdk.Models.Microsoft.Graph.Identity Group { get; set; }
        /// <summary>The SharePoint group associated with this action. Optional.</summary>
        public ApiSdk.Models.Microsoft.Graph.SharePointIdentity SiteGroup { get; set; }
        /// <summary>The SharePoint user associated with this action. Optional.</summary>
        public ApiSdk.Models.Microsoft.Graph.SharePointIdentity SiteUser { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.SharePointIdentitySet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharePointIdentitySet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"group", (o,n) => { (o as SharePointIdentitySet).Group = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Identity>(ApiSdk.Models.Microsoft.Graph.Identity.CreateFromDiscriminatorValue); } },
                {"siteGroup", (o,n) => { (o as SharePointIdentitySet).SiteGroup = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SharePointIdentity>(ApiSdk.Models.Microsoft.Graph.SharePointIdentity.CreateFromDiscriminatorValue); } },
                {"siteUser", (o,n) => { (o as SharePointIdentitySet).SiteUser = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SharePointIdentity>(ApiSdk.Models.Microsoft.Graph.SharePointIdentity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Identity>("group", Group);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SharePointIdentity>("siteGroup", SiteGroup);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SharePointIdentity>("siteUser", SiteUser);
        }
    }
}
