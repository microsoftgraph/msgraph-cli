using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class UpdateWindowsDeviceAccountActionParameter : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Not yet documented</summary>
        public bool? CalendarSyncEnabled { get; set; }
        /// <summary>Not yet documented</summary>
        public WindowsDeviceAccount DeviceAccount { get; set; }
        /// <summary>Not yet documented</summary>
        public string DeviceAccountEmail { get; set; }
        /// <summary>Not yet documented</summary>
        public string ExchangeServer { get; set; }
        /// <summary>Not yet documented</summary>
        public bool? PasswordRotationEnabled { get; set; }
        /// <summary>Not yet documented</summary>
        public string SessionInitiationProtocalAddress { get; set; }
        /// <summary>
        /// Instantiates a new updateWindowsDeviceAccountActionParameter and sets the default values.
        /// </summary>
        public UpdateWindowsDeviceAccountActionParameter() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UpdateWindowsDeviceAccountActionParameter CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateWindowsDeviceAccountActionParameter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"calendarSyncEnabled", n => { CalendarSyncEnabled = n.GetBoolValue(); } },
                {"deviceAccount", n => { DeviceAccount = n.GetObjectValue<WindowsDeviceAccount>(WindowsDeviceAccount.CreateFromDiscriminatorValue); } },
                {"deviceAccountEmail", n => { DeviceAccountEmail = n.GetStringValue(); } },
                {"exchangeServer", n => { ExchangeServer = n.GetStringValue(); } },
                {"passwordRotationEnabled", n => { PasswordRotationEnabled = n.GetBoolValue(); } },
                {"sessionInitiationProtocalAddress", n => { SessionInitiationProtocalAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("calendarSyncEnabled", CalendarSyncEnabled);
            writer.WriteObjectValue<WindowsDeviceAccount>("deviceAccount", DeviceAccount);
            writer.WriteStringValue("deviceAccountEmail", DeviceAccountEmail);
            writer.WriteStringValue("exchangeServer", ExchangeServer);
            writer.WriteBoolValue("passwordRotationEnabled", PasswordRotationEnabled);
            writer.WriteStringValue("sessionInitiationProtocalAddress", SessionInitiationProtocalAddress);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
