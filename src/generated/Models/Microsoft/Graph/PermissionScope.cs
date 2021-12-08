using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PermissionScope : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A description of the delegated permissions, intended to be read by an administrator granting the permission on behalf of all users. This text appears in tenant-wide admin consent experiences.</summary>
        public string AdminConsentDescription { get; set; }
        /// <summary>The permission's title, intended to be read by an administrator granting the permission on behalf of all users.</summary>
        public string AdminConsentDisplayName { get; set; }
        /// <summary>Unique delegated permission identifier inside the collection of delegated permissions defined for a resource application.</summary>
        public string Id { get; set; }
        /// <summary>When creating or updating a permission, this property must be set to true (which is the default). To delete a permission, this property must first be set to false.  At that point, in a subsequent call, the permission may be removed.</summary>
        public bool? IsEnabled { get; set; }
        public string Origin { get; set; }
        /// <summary>Specifies whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions. This will be the default behavior, but each customer can choose to customize the behavior in their organization (by allowing, restricting or limiting user consent to this delegated permission.)</summary>
        public string Type { get; set; }
        /// <summary>A description of the delegated permissions, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.</summary>
        public string UserConsentDescription { get; set; }
        /// <summary>A title for the permission, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.</summary>
        public string UserConsentDisplayName { get; set; }
        /// <summary>Specifies the value to include in the scp (scope) claim in access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..</summary>
        public string Value { get; set; }
        /// <summary>
        /// Instantiates a new permissionScope and sets the default values.
        /// </summary>
        public PermissionScope() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"adminConsentDescription", (o,n) => { (o as PermissionScope).AdminConsentDescription = n.GetStringValue(); } },
                {"adminConsentDisplayName", (o,n) => { (o as PermissionScope).AdminConsentDisplayName = n.GetStringValue(); } },
                {"id", (o,n) => { (o as PermissionScope).Id = n.GetStringValue(); } },
                {"isEnabled", (o,n) => { (o as PermissionScope).IsEnabled = n.GetBoolValue(); } },
                {"origin", (o,n) => { (o as PermissionScope).Origin = n.GetStringValue(); } },
                {"type", (o,n) => { (o as PermissionScope).Type = n.GetStringValue(); } },
                {"userConsentDescription", (o,n) => { (o as PermissionScope).UserConsentDescription = n.GetStringValue(); } },
                {"userConsentDisplayName", (o,n) => { (o as PermissionScope).UserConsentDisplayName = n.GetStringValue(); } },
                {"value", (o,n) => { (o as PermissionScope).Value = n.GetStringValue(); } },
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
            writer.WriteStringValue("origin", Origin);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("userConsentDescription", UserConsentDescription);
            writer.WriteStringValue("userConsentDisplayName", UserConsentDisplayName);
            writer.WriteStringValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
