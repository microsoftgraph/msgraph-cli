using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Users.Item.ManagedDevices.Item.Wipe {
    public class WipeRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public bool? KeepEnrollmentData { get; set; }
        public bool? KeepUserData { get; set; }
        public string MacOsUnlockCode { get; set; }
        public bool? PersistEsimDataPlan { get; set; }
        /// <summary>
        /// Instantiates a new wipeRequestBody and sets the default values.
        /// </summary>
        public WipeRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"keepEnrollmentData", (o,n) => { (o as WipeRequestBody).KeepEnrollmentData = n.GetBoolValue(); } },
                {"keepUserData", (o,n) => { (o as WipeRequestBody).KeepUserData = n.GetBoolValue(); } },
                {"macOsUnlockCode", (o,n) => { (o as WipeRequestBody).MacOsUnlockCode = n.GetStringValue(); } },
                {"persistEsimDataPlan", (o,n) => { (o as WipeRequestBody).PersistEsimDataPlan = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("keepEnrollmentData", KeepEnrollmentData);
            writer.WriteBoolValue("keepUserData", KeepUserData);
            writer.WriteStringValue("macOsUnlockCode", MacOsUnlockCode);
            writer.WriteBoolValue("persistEsimDataPlan", PersistEsimDataPlan);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
