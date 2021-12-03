using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ToneInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>An incremental identifier used for ordering DTMF events.</summary>
        public long? SequenceId { get; set; }
        /// <summary>Possible values are: tone0, tone1, tone2, tone3, tone4, tone5, tone6, tone7, tone8, tone9, star, pound, a, b, c, d, flash.</summary>
        public Tone? Tone { get; set; }
        /// <summary>
        /// Instantiates a new toneInfo and sets the default values.
        /// </summary>
        public ToneInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"sequenceId", (o,n) => { (o as ToneInfo).SequenceId = n.GetLongValue(); } },
                {"tone", (o,n) => { (o as ToneInfo).Tone = n.GetEnumValue<Tone>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("sequenceId", SequenceId);
            writer.WriteEnumValue<Tone>("tone", Tone);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
