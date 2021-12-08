using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AccessReviewReviewerScope : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The query specifying who will be the reviewer. See table for examples.</summary>
        public string Query { get; set; }
        /// <summary>In the scenario where reviewers need to be specified dynamically, this property is used to indicate the relative source of the query. This property is only required if a relative query, for example, ./manager, is specified. Possible value: decisions.</summary>
        public string QueryRoot { get; set; }
        /// <summary>The type of query. Examples include MicrosoftGraph and ARM.</summary>
        public string QueryType { get; set; }
        /// <summary>
        /// Instantiates a new accessReviewReviewerScope and sets the default values.
        /// </summary>
        public AccessReviewReviewerScope() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"query", (o,n) => { (o as AccessReviewReviewerScope).Query = n.GetStringValue(); } },
                {"queryRoot", (o,n) => { (o as AccessReviewReviewerScope).QueryRoot = n.GetStringValue(); } },
                {"queryType", (o,n) => { (o as AccessReviewReviewerScope).QueryType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("query", Query);
            writer.WriteStringValue("queryRoot", QueryRoot);
            writer.WriteStringValue("queryType", QueryType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
