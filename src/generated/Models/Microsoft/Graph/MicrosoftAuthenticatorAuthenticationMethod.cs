using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class MicrosoftAuthenticatorAuthenticationMethod : AuthenticationMethod, IParsable {
        /// <summary>The date and time that this app was registered. This property is null if the device is not registered for passwordless Phone Sign-In.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The registered device on which Microsoft Authenticator resides. This property is null if the device is not registered for passwordless Phone Sign-In.</summary>
        public ApiSdk.Models.Microsoft.Graph.Device Device { get; set; }
        /// <summary>Tags containing app metadata.</summary>
        public string DeviceTag { get; set; }
        /// <summary>The name of the device on which this app is registered.</summary>
        public string DisplayName { get; set; }
        /// <summary>Numerical version of this instance of the Authenticator app.</summary>
        public string PhoneAppVersion { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MicrosoftAuthenticatorAuthenticationMethod CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftAuthenticatorAuthenticationMethod();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as MicrosoftAuthenticatorAuthenticationMethod).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"device", (o,n) => { (o as MicrosoftAuthenticatorAuthenticationMethod).Device = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Device>(ApiSdk.Models.Microsoft.Graph.Device.CreateFromDiscriminatorValue); } },
                {"deviceTag", (o,n) => { (o as MicrosoftAuthenticatorAuthenticationMethod).DeviceTag = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as MicrosoftAuthenticatorAuthenticationMethod).DisplayName = n.GetStringValue(); } },
                {"phoneAppVersion", (o,n) => { (o as MicrosoftAuthenticatorAuthenticationMethod).PhoneAppVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Device>("device", Device);
            writer.WriteStringValue("deviceTag", DeviceTag);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("phoneAppVersion", PhoneAppVersion);
        }
    }
}
