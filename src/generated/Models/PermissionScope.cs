using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class PermissionScope : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A description of the delegated permissions, intended to be read by an administrator granting the permission on behalf of all users. This text appears in tenant-wide admin consent experiences.</summary>
        public string AdminConsentDescription { get; set; }
        /// <summary>The permission&apos;s title, intended to be read by an administrator granting the permission on behalf of all users.</summary>
        public string AdminConsentDisplayName { get; set; }
        /// <summary>Unique delegated permission identifier inside the collection of delegated permissions defined for a resource application.</summary>
        public string Id { get; set; }
        /// <summary>When creating or updating a permission, this property must be set to true (which is the default). To delete a permission, this property must first be set to false.  At that point, in a subsequent call, the permission may be removed.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The origin property</summary>
        public string Origin { get; set; }
        /// <summary>The possible values are: User and Admin. Specifies whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator consent should always be required. While Microsoft Graph defines the default consent requirement for each permission, the tenant administrator may override the behavior in their organization (by allowing, restricting, or limiting user consent to this delegated permission). For more information, see Configure how users consent to applications.</summary>
        public string Type { get; set; }
        /// <summary>A description of the delegated permissions, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.</summary>
        public string UserConsentDescription { get; set; }
        /// <summary>A title for the permission, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.</summary>
        public string UserConsentDisplayName { get; set; }
        /// <summary>Specifies the value to include in the scp (scope) claim in access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % &amp; &apos; ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..</summary>
        public string Value { get; set; }
        /// <summary>
        /// Instantiates a new permissionScope and sets the default values.
        /// </summary>
        public PermissionScope() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.permissionScope";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PermissionScope CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PermissionScope();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"adminConsentDescription", n => { AdminConsentDescription = n.GetStringValue(); } },
                {"adminConsentDisplayName", n => { AdminConsentDisplayName = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"origin", n => { Origin = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"userConsentDescription", n => { UserConsentDescription = n.GetStringValue(); } },
                {"userConsentDisplayName", n => { UserConsentDisplayName = n.GetStringValue(); } },
                {"value", n => { Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("adminConsentDescription", AdminConsentDescription);
            writer.WriteStringValue("adminConsentDisplayName", AdminConsentDisplayName);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("origin", Origin);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("userConsentDescription", UserConsentDescription);
            writer.WriteStringValue("userConsentDisplayName", UserConsentDisplayName);
            writer.WriteStringValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
