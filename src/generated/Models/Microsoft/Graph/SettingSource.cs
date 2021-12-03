using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SettingSource : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Not yet documented</summary>
        public string DisplayName { get; set; }
        /// <summary>Not yet documented</summary>
        public string Id { get; set; }
        /// <summary>Not yet documented. Possible values are: deviceConfiguration, deviceIntent.</summary>
        public SettingSourceType? SourceType { get; set; }
        /// <summary>
        /// Instantiates a new settingSource and sets the default values.
        /// </summary>
        public SettingSource() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as SettingSource).DisplayName = n.GetStringValue(); } },
                {"id", (o,n) => { (o as SettingSource).Id = n.GetStringValue(); } },
                {"sourceType", (o,n) => { (o as SettingSource).SourceType = n.GetEnumValue<SettingSourceType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("id", Id);
            writer.WriteEnumValue<SettingSourceType>("sourceType", SourceType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
