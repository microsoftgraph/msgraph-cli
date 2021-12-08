using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.CallRecords {
    public class FailureInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Classification of why a call or portion of a call failed.</summary>
        public string Reason { get; set; }
        /// <summary>The stage when the failure occurred. Possible values are: unknown, callSetup, midcall, unknownFutureValue.</summary>
        public FailureStage? Stage { get; set; }
        /// <summary>
        /// Instantiates a new failureInfo and sets the default values.
        /// </summary>
        public FailureInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"reason", (o,n) => { (o as FailureInfo).Reason = n.GetStringValue(); } },
                {"stage", (o,n) => { (o as FailureInfo).Stage = n.GetEnumValue<FailureStage>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("reason", Reason);
            writer.WriteEnumValue<FailureStage>("stage", Stage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
