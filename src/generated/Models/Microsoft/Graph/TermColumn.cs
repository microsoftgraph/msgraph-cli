using ApiSdk.Models.Microsoft.Graph.TermStore;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TermColumn : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies whether the column will allow more than one value.</summary>
        public bool? AllowMultipleValues { get; set; }
        public Term ParentTerm { get; set; }
        /// <summary>Specifies whether to display the entire term path or only the term label.</summary>
        public bool? ShowFullyQualifiedName { get; set; }
        public ApiSdk.Models.Microsoft.Graph.TermStore.Set TermSet { get; set; }
        /// <summary>
        /// Instantiates a new termColumn and sets the default values.
        /// </summary>
        public TermColumn() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowMultipleValues", (o,n) => { (o as TermColumn).AllowMultipleValues = n.GetBoolValue(); } },
                {"parentTerm", (o,n) => { (o as TermColumn).ParentTerm = n.GetObjectValue<Term>(); } },
                {"showFullyQualifiedName", (o,n) => { (o as TermColumn).ShowFullyQualifiedName = n.GetBoolValue(); } },
                {"termSet", (o,n) => { (o as TermColumn).TermSet = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.TermStore.Set>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowMultipleValues", AllowMultipleValues);
            writer.WriteObjectValue<Term>("parentTerm", ParentTerm);
            writer.WriteBoolValue("showFullyQualifiedName", ShowFullyQualifiedName);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.TermStore.Set>("termSet", TermSet);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
