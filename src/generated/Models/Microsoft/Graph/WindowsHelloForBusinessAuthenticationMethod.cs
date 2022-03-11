using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WindowsHelloForBusinessAuthenticationMethod : AuthenticationMethod, IParsable {
        /// <summary>The date and time that this Windows Hello for Business key was registered.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The registered device on which this Windows Hello for Business key resides.</summary>
        public ApiSdk.Models.Microsoft.Graph.Device Device { get; set; }
        /// <summary>The name of the device on which Windows Hello for Business is registered</summary>
        public string DisplayName { get; set; }
        /// <summary>Key strength of this Windows Hello for Business key. Possible values are: normal, weak, unknown.</summary>
        public AuthenticationMethodKeyStrength? KeyStrength { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsHelloForBusinessAuthenticationMethod CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsHelloForBusinessAuthenticationMethod();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as WindowsHelloForBusinessAuthenticationMethod).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"device", (o,n) => { (o as WindowsHelloForBusinessAuthenticationMethod).Device = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Device>(ApiSdk.Models.Microsoft.Graph.Device.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as WindowsHelloForBusinessAuthenticationMethod).DisplayName = n.GetStringValue(); } },
                {"keyStrength", (o,n) => { (o as WindowsHelloForBusinessAuthenticationMethod).KeyStrength = n.GetEnumValue<AuthenticationMethodKeyStrength>(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<AuthenticationMethodKeyStrength>("keyStrength", KeyStrength);
        }
    }
}
