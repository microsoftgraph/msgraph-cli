using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class CalculatedColumn : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>For dateTime output types, the format of the value. Must be one of dateOnly or dateTime.</summary>
        public string Format { get; set; }
        /// <summary>The formula used to compute the value for this column.</summary>
        public string Formula { get; set; }
        /// <summary>The output type used to format values in this column. Must be one of boolean, currency, dateTime, number, or text.</summary>
        public string OutputType { get; set; }
        /// <summary>
        /// Instantiates a new calculatedColumn and sets the default values.
        /// </summary>
        public CalculatedColumn() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"format", (o,n) => { (o as CalculatedColumn).Format = n.GetStringValue(); } },
                {"formula", (o,n) => { (o as CalculatedColumn).Formula = n.GetStringValue(); } },
                {"outputType", (o,n) => { (o as CalculatedColumn).OutputType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("format", Format);
            writer.WriteStringValue("formula", Formula);
            writer.WriteStringValue("outputType", OutputType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
