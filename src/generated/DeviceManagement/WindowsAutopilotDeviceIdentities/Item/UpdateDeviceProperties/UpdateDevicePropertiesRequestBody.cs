using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.UpdateDeviceProperties {
    public class UpdateDevicePropertiesRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string AddressableUserName { get; set; }
        public string DisplayName { get; set; }
        public string GroupTag { get; set; }
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Instantiates a new updateDevicePropertiesRequestBody and sets the default values.
        /// </summary>
        public UpdateDevicePropertiesRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"addressableUserName", (o,n) => { (o as UpdateDevicePropertiesRequestBody).AddressableUserName = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as UpdateDevicePropertiesRequestBody).DisplayName = n.GetStringValue(); } },
                {"groupTag", (o,n) => { (o as UpdateDevicePropertiesRequestBody).GroupTag = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as UpdateDevicePropertiesRequestBody).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("addressableUserName", AddressableUserName);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("groupTag", GroupTag);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
