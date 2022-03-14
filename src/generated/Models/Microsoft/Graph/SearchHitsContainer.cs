using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SearchHitsContainer : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Contains the collection of aggregations computed based on the provided aggregationOption specified in the request.</summary>
        public List<SearchAggregation> Aggregations { get; set; }
        /// <summary>A collection of the search results.</summary>
        public List<SearchHit> Hits { get; set; }
        /// <summary>Provides information if more results are available. Based on this information, you can adjust the from and size properties of the searchRequest accordingly.</summary>
        public bool? MoreResultsAvailable { get; set; }
        /// <summary>The total number of results. Note this is not the number of results on the page, but the total number of results satisfying the query.</summary>
        public int? Total { get; set; }
        /// <summary>
        /// Instantiates a new searchHitsContainer and sets the default values.
        /// </summary>
        public SearchHitsContainer() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SearchHitsContainer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchHitsContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"aggregations", (o,n) => { (o as SearchHitsContainer).Aggregations = n.GetCollectionOfObjectValues<SearchAggregation>(SearchAggregation.CreateFromDiscriminatorValue).ToList(); } },
                {"hits", (o,n) => { (o as SearchHitsContainer).Hits = n.GetCollectionOfObjectValues<SearchHit>(SearchHit.CreateFromDiscriminatorValue).ToList(); } },
                {"moreResultsAvailable", (o,n) => { (o as SearchHitsContainer).MoreResultsAvailable = n.GetBoolValue(); } },
                {"total", (o,n) => { (o as SearchHitsContainer).Total = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<SearchAggregation>("aggregations", Aggregations);
            writer.WriteCollectionOfObjectValues<SearchHit>("hits", Hits);
            writer.WriteBoolValue("moreResultsAvailable", MoreResultsAvailable);
            writer.WriteIntValue("total", Total);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
