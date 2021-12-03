using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SignInFrequencySessionControl : ConditionalAccessSessionControl, IParsable {
        /// <summary>Possible values are: days, hours.</summary>
        public SigninFrequencyType? Type { get; set; }
        /// <summary>The number of days or hours.</summary>
        public int? Value { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"type", (o,n) => { (o as SignInFrequencySessionControl).Type = n.GetEnumValue<SigninFrequencyType>(); } },
                {"value", (o,n) => { (o as SignInFrequencySessionControl).Value = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<SigninFrequencyType>("type", Type);
            writer.WriteIntValue("value", Value);
        }
    }
}
