using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SearchHit : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The name of the content source which the externalItem is part of .</summary>
        public string ContentSource { get; set; }
        /// <summary>The internal identifier for the item.</summary>
        public string HitId { get; set; }
        /// <summary>The rank or the order of the result.</summary>
        public int? Rank { get; set; }
        public ApiSdk.Models.Microsoft.Graph.Entity Resource { get; set; }
        /// <summary>ID of the result template used to render the search result. This ID must map to a display layout in the resultTemplates dictionary that is also included in the searchResponse.</summary>
        public string ResultTemplateId { get; set; }
        /// <summary>A summary of the result, if a summary is available.</summary>
        public string Summary { get; set; }
        /// <summary>
        /// Instantiates a new searchHit and sets the default values.
        /// </summary>
        public SearchHit() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.SearchHit CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchHit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"contentSource", (o,n) => { (o as SearchHit).ContentSource = n.GetStringValue(); } },
                {"hitId", (o,n) => { (o as SearchHit).HitId = n.GetStringValue(); } },
                {"rank", (o,n) => { (o as SearchHit).Rank = n.GetIntValue(); } },
                {"resource", (o,n) => { (o as SearchHit).Resource = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Entity>(ApiSdk.Models.Microsoft.Graph.Entity.CreateFromDiscriminatorValue); } },
                {"resultTemplateId", (o,n) => { (o as SearchHit).ResultTemplateId = n.GetStringValue(); } },
                {"summary", (o,n) => { (o as SearchHit).Summary = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("contentSource", ContentSource);
            writer.WriteStringValue("hitId", HitId);
            writer.WriteIntValue("rank", Rank);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Entity>("resource", Resource);
            writer.WriteStringValue("resultTemplateId", ResultTemplateId);
            writer.WriteStringValue("summary", Summary);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
