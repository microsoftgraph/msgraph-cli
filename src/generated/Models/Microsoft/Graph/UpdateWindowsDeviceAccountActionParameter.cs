using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class UpdateWindowsDeviceAccountActionParameter : IParsable {
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"calendarSyncEnabled", (o,n) => { (o as UpdateWindowsDeviceAccountActionParameter).CalendarSyncEnabled = n.GetBoolValue(); } },
                {"deviceAccount", (o,n) => { (o as UpdateWindowsDeviceAccountActionParameter).DeviceAccount = n.GetObjectValue<WindowsDeviceAccount>(); } },
                {"deviceAccountEmail", (o,n) => { (o as UpdateWindowsDeviceAccountActionParameter).DeviceAccountEmail = n.GetStringValue(); } },
                {"exchangeServer", (o,n) => { (o as UpdateWindowsDeviceAccountActionParameter).ExchangeServer = n.GetStringValue(); } },
                {"passwordRotationEnabled", (o,n) => { (o as UpdateWindowsDeviceAccountActionParameter).PasswordRotationEnabled = n.GetBoolValue(); } },
                {"sessionInitiationProtocalAddress", (o,n) => { (o as UpdateWindowsDeviceAccountActionParameter).SessionInitiationProtocalAddress = n.GetStringValue(); } },
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
