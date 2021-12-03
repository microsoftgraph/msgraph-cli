using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class IntegerRange : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The inclusive upper bound of the integer range.</summary>
        public long? End { get; set; }
        /// <summary>The inclusive lower bound of the integer range.</summary>
        public long? Start { get; set; }
        /// <summary>
        /// Instantiates a new integerRange and sets the default values.
        /// </summary>
        public IntegerRange() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"end", (o,n) => { (o as IntegerRange).End = n.GetLongValue(); } },
                {"start", (o,n) => { (o as IntegerRange).Start = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("end", End);
            writer.WriteLongValue("start", Start);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
