using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class PasswordProfile : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>true if the user must change her password on the next login; otherwise false. If not set, default is false. NOTE:  For Azure B2C tenants, set to false and instead use custom policies and user flows to force password reset at first sign in. See Force password reset at first logon.</summary>
        public bool? ForceChangePasswordNextSignIn { get; set; }
        /// <summary>If true, at next sign-in, the user must perform a multi-factor authentication (MFA) before being forced to change their password. The behavior is identical to forceChangePasswordNextSignIn except that the user is required to first perform a multi-factor authentication before password change. After a password change, this property will be automatically reset to false. If not set, default is false.</summary>
        public bool? ForceChangePasswordNextSignInWithMfa { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The password for the user. This property is required when a user is created. It can be updated, but the user will be required to change the password on the next login. The password must satisfy minimum requirements as specified by the user’s passwordPolicies property. By default, a strong password is required.</summary>
        public string Password { get; set; }
        /// <summary>
        /// Instantiates a new passwordProfile and sets the default values.
        /// </summary>
        public PasswordProfile() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.passwordProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PasswordProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PasswordProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"forceChangePasswordNextSignIn", n => { ForceChangePasswordNextSignIn = n.GetBoolValue(); } },
                {"forceChangePasswordNextSignInWithMfa", n => { ForceChangePasswordNextSignInWithMfa = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"password", n => { Password = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("forceChangePasswordNextSignIn", ForceChangePasswordNextSignIn);
            writer.WriteBoolValue("forceChangePasswordNextSignInWithMfa", ForceChangePasswordNextSignInWithMfa);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("password", Password);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
