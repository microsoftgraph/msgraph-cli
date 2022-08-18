using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class PhoneAuthenticationMethod : AuthenticationMethod, IParsable {
        /// <summary>The phone number to text or call for authentication. Phone numbers use the format +{country code} {number}x{extension}, with extension optional. For example, +1 5555551234 or +1 5555551234x123 are valid. Numbers are rejected when creating or updating if they do not match the required format.</summary>
        public string PhoneNumber { get; set; }
        /// <summary>The type of this phone. Possible values are: mobile, alternateMobile, or office.</summary>
        public AuthenticationPhoneType? PhoneType { get; set; }
        /// <summary>Whether a phone is ready to be used for SMS sign-in or not. Possible values are: notSupported, notAllowedByPolicy, notEnabled, phoneNumberNotUnique, ready, or notConfigured, unknownFutureValue.</summary>
        public AuthenticationMethodSignInState? SmsSignInState { get; set; }
        /// <summary>
        /// Instantiates a new PhoneAuthenticationMethod and sets the default values.
        /// </summary>
        public PhoneAuthenticationMethod() : base() {
            OdataType = "#microsoft.graph.phoneAuthenticationMethod";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PhoneAuthenticationMethod CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PhoneAuthenticationMethod();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"phoneType", n => { PhoneType = n.GetEnumValue<AuthenticationPhoneType>(); } },
                {"smsSignInState", n => { SmsSignInState = n.GetEnumValue<AuthenticationMethodSignInState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteEnumValue<AuthenticationPhoneType>("phoneType", PhoneType);
            writer.WriteEnumValue<AuthenticationMethodSignInState>("smsSignInState", SmsSignInState);
        }
    }
}
