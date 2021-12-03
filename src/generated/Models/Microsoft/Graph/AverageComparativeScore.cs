using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AverageComparativeScore : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Average score within specified basis.</summary>
        public double? AverageScore { get; set; }
        /// <summary>Scope type. The possible values are: AllTenants, TotalSeats, IndustryTypes.</summary>
        public string Basis { get; set; }
        /// <summary>
        /// Instantiates a new averageComparativeScore and sets the default values.
        /// </summary>
        public AverageComparativeScore() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"averageScore", (o,n) => { (o as AverageComparativeScore).AverageScore = n.GetDoubleValue(); } },
                {"basis", (o,n) => { (o as AverageComparativeScore).Basis = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("averageScore", AverageScore);
            writer.WriteStringValue("basis", Basis);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
