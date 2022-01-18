using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Phone : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Language { get; set; }
        /// <summary>The phone number.</summary>
        public string Number { get; set; }
        public string Region { get; set; }
        /// <summary>The type of phone number. Possible values are: home, business, mobile, other, assistant, homeFax, businessFax, otherFax, pager, radio.</summary>
        public PhoneType? Type { get; set; }
        /// <summary>
        /// Instantiates a new phone and sets the default values.
        /// </summary>
        public Phone() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"language", (o,n) => { (o as Phone).Language = n.GetStringValue(); } },
                {"number", (o,n) => { (o as Phone).Number = n.GetStringValue(); } },
                {"region", (o,n) => { (o as Phone).Region = n.GetStringValue(); } },
                {"type", (o,n) => { (o as Phone).Type = n.GetEnumValue<PhoneType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("language", Language);
            writer.WriteStringValue("number", Number);
            writer.WriteStringValue("region", Region);
            writer.WriteEnumValue<PhoneType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
