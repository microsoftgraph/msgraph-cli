using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Permission : Entity, IParsable {
        /// <summary>A format of yyyy-MM-ddTHH:mm:ssZ of DateTimeOffset indicates the expiration time of the permission. DateTime.MinValue indicates there is no expiration set for this permission. Optional.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        public ApiSdk.Models.Microsoft.Graph.IdentitySet GrantedTo { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.IdentitySet> GrantedToIdentities { get; set; }
        /// <summary>For link type permissions, the details of the users to whom permission was granted. Read-only.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.SharePointIdentitySet> GrantedToIdentitiesV2 { get; set; }
        /// <summary>For user type permissions, the details of the users and applications for this permission. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.SharePointIdentitySet GrantedToV2 { get; set; }
        /// <summary>Indicates whether the password is set for this permission. This property only appears in the response. Optional. Read-only. For OneDrive Personal only..</summary>
        public bool? HasPassword { get; set; }
        /// <summary>Provides a reference to the ancestor of the current permission, if it is inherited from an ancestor. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.ItemReference InheritedFrom { get; set; }
        /// <summary>Details of any associated sharing invitation for this permission. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.SharingInvitation Invitation { get; set; }
        /// <summary>Provides the link details of the current permission, if it is a link type permissions. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.SharingLink Link { get; set; }
        /// <summary>The type of permission, for example, read. See below for the full list of roles. Read-only.</summary>
        public List<string> Roles { get; set; }
        /// <summary>A unique token that can be used to access this shared item via the **shares** API. Read-only.</summary>
        public string ShareId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.Permission CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Permission();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"expirationDateTime", (o,n) => { (o as Permission).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"grantedTo", (o,n) => { (o as Permission).GrantedTo = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>(ApiSdk.Models.Microsoft.Graph.IdentitySet.CreateFromDiscriminatorValue); } },
                {"grantedToIdentities", (o,n) => { (o as Permission).GrantedToIdentities = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.IdentitySet>(ApiSdk.Models.Microsoft.Graph.IdentitySet.CreateFromDiscriminatorValue).ToList(); } },
                {"grantedToIdentitiesV2", (o,n) => { (o as Permission).GrantedToIdentitiesV2 = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SharePointIdentitySet>(ApiSdk.Models.Microsoft.Graph.SharePointIdentitySet.CreateFromDiscriminatorValue).ToList(); } },
                {"grantedToV2", (o,n) => { (o as Permission).GrantedToV2 = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SharePointIdentitySet>(ApiSdk.Models.Microsoft.Graph.SharePointIdentitySet.CreateFromDiscriminatorValue); } },
                {"hasPassword", (o,n) => { (o as Permission).HasPassword = n.GetBoolValue(); } },
                {"inheritedFrom", (o,n) => { (o as Permission).InheritedFrom = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ItemReference>(ApiSdk.Models.Microsoft.Graph.ItemReference.CreateFromDiscriminatorValue); } },
                {"invitation", (o,n) => { (o as Permission).Invitation = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SharingInvitation>(ApiSdk.Models.Microsoft.Graph.SharingInvitation.CreateFromDiscriminatorValue); } },
                {"link", (o,n) => { (o as Permission).Link = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SharingLink>(ApiSdk.Models.Microsoft.Graph.SharingLink.CreateFromDiscriminatorValue); } },
                {"roles", (o,n) => { (o as Permission).Roles = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"shareId", (o,n) => { (o as Permission).ShareId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySet>("grantedTo", GrantedTo);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.IdentitySet>("grantedToIdentities", GrantedToIdentities);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SharePointIdentitySet>("grantedToIdentitiesV2", GrantedToIdentitiesV2);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SharePointIdentitySet>("grantedToV2", GrantedToV2);
            writer.WriteBoolValue("hasPassword", HasPassword);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ItemReference>("inheritedFrom", InheritedFrom);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SharingInvitation>("invitation", Invitation);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SharingLink>("link", Link);
            writer.WriteCollectionOfPrimitiveValues<string>("roles", Roles);
            writer.WriteStringValue("shareId", ShareId);
        }
    }
}
