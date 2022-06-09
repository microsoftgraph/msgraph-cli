using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class Permission : Entity, IParsable {
        /// <summary>A format of yyyy-MM-ddTHH:mm:ssZ of DateTimeOffset indicates the expiration time of the permission. DateTime.MinValue indicates there is no expiration set for this permission. Optional.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>The grantedTo property</summary>
        public IdentitySet GrantedTo { get; set; }
        /// <summary>The grantedToIdentities property</summary>
        public List<IdentitySet> GrantedToIdentities { get; set; }
        /// <summary>For link type permissions, the details of the users to whom permission was granted. Read-only.</summary>
        public List<SharePointIdentitySet> GrantedToIdentitiesV2 { get; set; }
        /// <summary>For user type permissions, the details of the users and applications for this permission. Read-only.</summary>
        public SharePointIdentitySet GrantedToV2 { get; set; }
        /// <summary>Indicates whether the password is set for this permission. This property only appears in the response. Optional. Read-only. For OneDrive Personal only.</summary>
        public bool? HasPassword { get; set; }
        /// <summary>Provides a reference to the ancestor of the current permission, if it is inherited from an ancestor. Read-only.</summary>
        public ItemReference InheritedFrom { get; set; }
        /// <summary>Details of any associated sharing invitation for this permission. Read-only.</summary>
        public SharingInvitation Invitation { get; set; }
        /// <summary>Provides the link details of the current permission, if it is a link type permissions. Read-only.</summary>
        public SharingLink Link { get; set; }
        /// <summary>The type of permission, for example, read. See below for the full list of roles. Read-only.</summary>
        public List<string> Roles { get; set; }
        /// <summary>A unique token that can be used to access this shared item via the [shares API][]. Read-only.</summary>
        public string ShareId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Permission CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Permission();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"grantedTo", n => { GrantedTo = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"grantedToIdentities", n => { GrantedToIdentities = n.GetCollectionOfObjectValues<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue).ToList(); } },
                {"grantedToIdentitiesV2", n => { GrantedToIdentitiesV2 = n.GetCollectionOfObjectValues<SharePointIdentitySet>(SharePointIdentitySet.CreateFromDiscriminatorValue).ToList(); } },
                {"grantedToV2", n => { GrantedToV2 = n.GetObjectValue<SharePointIdentitySet>(SharePointIdentitySet.CreateFromDiscriminatorValue); } },
                {"hasPassword", n => { HasPassword = n.GetBoolValue(); } },
                {"inheritedFrom", n => { InheritedFrom = n.GetObjectValue<ItemReference>(ItemReference.CreateFromDiscriminatorValue); } },
                {"invitation", n => { Invitation = n.GetObjectValue<SharingInvitation>(SharingInvitation.CreateFromDiscriminatorValue); } },
                {"link", n => { Link = n.GetObjectValue<SharingLink>(SharingLink.CreateFromDiscriminatorValue); } },
                {"roles", n => { Roles = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"shareId", n => { ShareId = n.GetStringValue(); } },
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
            writer.WriteObjectValue<IdentitySet>("grantedTo", GrantedTo);
            writer.WriteCollectionOfObjectValues<IdentitySet>("grantedToIdentities", GrantedToIdentities);
            writer.WriteCollectionOfObjectValues<SharePointIdentitySet>("grantedToIdentitiesV2", GrantedToIdentitiesV2);
            writer.WriteObjectValue<SharePointIdentitySet>("grantedToV2", GrantedToV2);
            writer.WriteBoolValue("hasPassword", HasPassword);
            writer.WriteObjectValue<ItemReference>("inheritedFrom", InheritedFrom);
            writer.WriteObjectValue<SharingInvitation>("invitation", Invitation);
            writer.WriteObjectValue<SharingLink>("link", Link);
            writer.WriteCollectionOfPrimitiveValues<string>("roles", Roles);
            writer.WriteStringValue("shareId", ShareId);
        }
    }
}
