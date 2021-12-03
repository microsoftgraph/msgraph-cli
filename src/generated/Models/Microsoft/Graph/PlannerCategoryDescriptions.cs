using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PlannerCategoryDescriptions : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The label associated with Category 1</summary>
        public string Category1 { get; set; }
        /// <summary>The label associated with Category 2</summary>
        public string Category2 { get; set; }
        /// <summary>The label associated with Category 3</summary>
        public string Category3 { get; set; }
        /// <summary>The label associated with Category 4</summary>
        public string Category4 { get; set; }
        /// <summary>The label associated with Category 5</summary>
        public string Category5 { get; set; }
        /// <summary>The label associated with Category 6</summary>
        public string Category6 { get; set; }
        /// <summary>
        /// Instantiates a new plannerCategoryDescriptions and sets the default values.
        /// </summary>
        public PlannerCategoryDescriptions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"category1", (o,n) => { (o as PlannerCategoryDescriptions).Category1 = n.GetStringValue(); } },
                {"category2", (o,n) => { (o as PlannerCategoryDescriptions).Category2 = n.GetStringValue(); } },
                {"category3", (o,n) => { (o as PlannerCategoryDescriptions).Category3 = n.GetStringValue(); } },
                {"category4", (o,n) => { (o as PlannerCategoryDescriptions).Category4 = n.GetStringValue(); } },
                {"category5", (o,n) => { (o as PlannerCategoryDescriptions).Category5 = n.GetStringValue(); } },
                {"category6", (o,n) => { (o as PlannerCategoryDescriptions).Category6 = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("category1", Category1);
            writer.WriteStringValue("category2", Category2);
            writer.WriteStringValue("category3", Category3);
            writer.WriteStringValue("category4", Category4);
            writer.WriteStringValue("category5", Category5);
            writer.WriteStringValue("category6", Category6);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
