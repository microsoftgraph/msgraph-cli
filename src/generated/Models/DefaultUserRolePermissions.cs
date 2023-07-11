using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class DefaultUserRolePermissions : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether the default user role can create applications. This setting corresponds to the Users can register applications setting in the User settings menu in the Azure portal.</summary>
        public bool? AllowedToCreateApps { get; set; }
        /// <summary>Indicates whether the default user role can create security groups. This setting corresponds to the following menus in the Azure portal:  The Users can create security groups in Azure portals, API or PowerShell setting in the Group settings menu.  Users can create security groups setting in the User settings menu.</summary>
        public bool? AllowedToCreateSecurityGroups { get; set; }
        /// <summary>Indicates whether the default user role can create tenants. This setting corresponds to the Restrict non-admin users from creating tenants setting in the User settings menu in the Azure portal.  When this setting is false, users assigned the Tenant Creator role can still create tenants.</summary>
        public bool? AllowedToCreateTenants { get; set; }
        /// <summary>Indicates whether the registered owners of a device can read their own BitLocker recovery keys with default user role.</summary>
        public bool? AllowedToReadBitlockerKeysForOwnedDevice { get; set; }
        /// <summary>Indicates whether the default user role can read other users.</summary>
        public bool? AllowedToReadOtherUsers { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Indicates if user consent to apps is allowed, and if it is, which permission to grant consent and which app consent policy (permissionGrantPolicy) govern the permission for users to grant consent. Value should be in the format managePermissionGrantsForSelf.{id}, where {id} is the id of a built-in or custom app consent policy. An empty list indicates user consent to apps is disabled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PermissionGrantPoliciesAssigned { get; set; }
#nullable restore
#else
        public List<string> PermissionGrantPoliciesAssigned { get; set; }
#endif
        /// <summary>
        /// Instantiates a new defaultUserRolePermissions and sets the default values.
        /// </summary>
        public DefaultUserRolePermissions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DefaultUserRolePermissions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DefaultUserRolePermissions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowedToCreateApps", n => { AllowedToCreateApps = n.GetBoolValue(); } },
                {"allowedToCreateSecurityGroups", n => { AllowedToCreateSecurityGroups = n.GetBoolValue(); } },
                {"allowedToCreateTenants", n => { AllowedToCreateTenants = n.GetBoolValue(); } },
                {"allowedToReadBitlockerKeysForOwnedDevice", n => { AllowedToReadBitlockerKeysForOwnedDevice = n.GetBoolValue(); } },
                {"allowedToReadOtherUsers", n => { AllowedToReadOtherUsers = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"permissionGrantPoliciesAssigned", n => { PermissionGrantPoliciesAssigned = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowedToCreateApps", AllowedToCreateApps);
            writer.WriteBoolValue("allowedToCreateSecurityGroups", AllowedToCreateSecurityGroups);
            writer.WriteBoolValue("allowedToCreateTenants", AllowedToCreateTenants);
            writer.WriteBoolValue("allowedToReadBitlockerKeysForOwnedDevice", AllowedToReadBitlockerKeysForOwnedDevice);
            writer.WriteBoolValue("allowedToReadOtherUsers", AllowedToReadOtherUsers);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("permissionGrantPoliciesAssigned", PermissionGrantPoliciesAssigned);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
