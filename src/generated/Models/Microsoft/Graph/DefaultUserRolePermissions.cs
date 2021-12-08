using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DefaultUserRolePermissions : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether the default user role can create applications.</summary>
        public bool? AllowedToCreateApps { get; set; }
        /// <summary>Indicates whether the default user role can create security groups.</summary>
        public bool? AllowedToCreateSecurityGroups { get; set; }
        /// <summary>Indicates whether the default user role can read other users.</summary>
        public bool? AllowedToReadOtherUsers { get; set; }
        /// <summary>Indicates if user consent to apps is allowed, and if it is, which permission to grant consent and which app consent policy (permissionGrantPolicy) govern the permission for users to grant consent. Value should be in the format managePermissionGrantsForSelf.{id}, where {id} is the id of a built-in or custom app consent policy. An empty list indicates user consent to apps is disabled.</summary>
        public List<string> PermissionGrantPoliciesAssigned { get; set; }
        /// <summary>
        /// Instantiates a new defaultUserRolePermissions and sets the default values.
        /// </summary>
        public DefaultUserRolePermissions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowedToCreateApps", (o,n) => { (o as DefaultUserRolePermissions).AllowedToCreateApps = n.GetBoolValue(); } },
                {"allowedToCreateSecurityGroups", (o,n) => { (o as DefaultUserRolePermissions).AllowedToCreateSecurityGroups = n.GetBoolValue(); } },
                {"allowedToReadOtherUsers", (o,n) => { (o as DefaultUserRolePermissions).AllowedToReadOtherUsers = n.GetBoolValue(); } },
                {"permissionGrantPoliciesAssigned", (o,n) => { (o as DefaultUserRolePermissions).PermissionGrantPoliciesAssigned = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowedToCreateApps", AllowedToCreateApps);
            writer.WriteBoolValue("allowedToCreateSecurityGroups", AllowedToCreateSecurityGroups);
            writer.WriteBoolValue("allowedToReadOtherUsers", AllowedToReadOtherUsers);
            writer.WriteCollectionOfPrimitiveValues<string>("permissionGrantPoliciesAssigned", PermissionGrantPoliciesAssigned);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
