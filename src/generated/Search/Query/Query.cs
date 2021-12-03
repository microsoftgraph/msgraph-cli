using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Search.Query {
    public class Query : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A collection of search results.</summary>
        public List<SearchHitsContainer> HitsContainers { get; set; }
        /// <summary>Contains the search terms sent in the initial search query.</summary>
        public List<string> SearchTerms { get; set; }
        /// <summary>
        /// Instantiates a new query and sets the default values.
        /// </summary>
        public Query() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"hitsContainers", (o,n) => { (o as Query).HitsContainers = n.GetCollectionOfObjectValues<SearchHitsContainer>().ToList(); } },
                {"searchTerms", (o,n) => { (o as Query).SearchTerms = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<SearchHitsContainer>("hitsContainers", HitsContainers);
            writer.WriteCollectionOfPrimitiveValues<string>("searchTerms", SearchTerms);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
