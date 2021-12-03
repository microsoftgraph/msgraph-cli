using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Users.Item.ManagedDevices.Item.UpdateWindowsDeviceAccount {
    public class UpdateWindowsDeviceAccountRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public UpdateWindowsDeviceAccountActionParameter UpdateWindowsDeviceAccountActionParameter { get; set; }
        /// <summary>
        /// Instantiates a new updateWindowsDeviceAccountRequestBody and sets the default values.
        /// </summary>
        public UpdateWindowsDeviceAccountRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"updateWindowsDeviceAccountActionParameter", (o,n) => { (o as UpdateWindowsDeviceAccountRequestBody).UpdateWindowsDeviceAccountActionParameter = n.GetObjectValue<UpdateWindowsDeviceAccountActionParameter>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UpdateWindowsDeviceAccountActionParameter>("updateWindowsDeviceAccountActionParameter", UpdateWindowsDeviceAccountActionParameter);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
