using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SearchResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A collection of search results.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.SearchHitsContainer> HitsContainers { get; set; }
        /// <summary>Provides information related to spelling corrections in the alteration response.</summary>
        public ApiSdk.Models.Microsoft.Graph.AlterationResponse QueryAlterationResponse { get; set; }
        /// <summary>A dictionary of resultTemplateIds and associated values, which include the name and JSON schema of the result templates.</summary>
        public ApiSdk.Models.Microsoft.Graph.ResultTemplateDictionary ResultTemplates { get; set; }
        /// <summary>Contains the search terms sent in the initial search query.</summary>
        public List<string> SearchTerms { get; set; }
        /// <summary>
        /// Instantiates a new searchResponse and sets the default values.
        /// </summary>
        public SearchResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.SearchResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"hitsContainers", (o,n) => { (o as SearchResponse).HitsContainers = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SearchHitsContainer>(ApiSdk.Models.Microsoft.Graph.SearchHitsContainer.CreateFromDiscriminatorValue).ToList(); } },
                {"queryAlterationResponse", (o,n) => { (o as SearchResponse).QueryAlterationResponse = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AlterationResponse>(ApiSdk.Models.Microsoft.Graph.AlterationResponse.CreateFromDiscriminatorValue); } },
                {"resultTemplates", (o,n) => { (o as SearchResponse).ResultTemplates = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ResultTemplateDictionary>(ApiSdk.Models.Microsoft.Graph.ResultTemplateDictionary.CreateFromDiscriminatorValue); } },
                {"searchTerms", (o,n) => { (o as SearchResponse).SearchTerms = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SearchHitsContainer>("hitsContainers", HitsContainers);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AlterationResponse>("queryAlterationResponse", QueryAlterationResponse);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ResultTemplateDictionary>("resultTemplates", ResultTemplates);
            writer.WriteCollectionOfPrimitiveValues<string>("searchTerms", SearchTerms);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
