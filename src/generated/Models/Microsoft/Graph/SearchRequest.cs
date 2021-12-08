using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SearchRequest : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Contains one or more filters to obtain search results aggregated and filtered to a specific value of a field. Optional.Build this filter based on a prior search that aggregates by the same field. From the response of the prior search, identify the searchBucket that filters results to the specific value of the field, use the string in its aggregationFilterToken property, and build an aggregation filter string in the format '{field}:/'{aggregationFilterToken}/''. If multiple values for the same field need to be provided, use the strings in its aggregationFilterToken property and build an aggregation filter string in the format '{field}:or(/'{aggregationFilterToken1}/',/'{aggregationFilterToken2}/')'. For example, searching and aggregating drive items by file type returns a searchBucket for the file type docx in the response. You can conveniently use the aggregationFilterToken returned for this searchBucket in a subsequent search query and filter matches down to drive items of the docx file type. Example 1 and example 2 show the actual requests and responses.</summary>
        public List<string> AggregationFilters { get; set; }
        /// <summary>Specifies aggregations (also known as refiners) to be returned alongside search results. Optional.</summary>
        public List<AggregationOption> Aggregations { get; set; }
        /// <summary>Contains the connection to be targeted. Respects the following format : /external/connections/connectionid where connectionid is the ConnectionId defined in the Connectors Administration.  Note: contentSource is only applicable when entityType=externalItem. Optional.</summary>
        public List<string> ContentSources { get; set; }
        /// <summary>This triggers hybrid sort for messages: the first 3 messages are the most relevant. This property is only applicable to entityType=message. Optional.</summary>
        public bool? EnableTopResults { get; set; }
        /// <summary>One or more types of resources expected in the response. Possible values are: list, site, listItem, message, event, drive, driveItem, person, externalItem. See known limitations for those combinations of two or more entity types that are supported in the same search request. Required.</summary>
        public List<EntityType?> EntityTypes { get; set; }
        /// <summary>Contains the fields to be returned for each resource object specified in entityTypes, allowing customization of the fields returned by default otherwise, including additional fields such as custom managed properties from SharePoint and OneDrive, or custom fields in externalItem from content that Microsoft Graph connectors bring in. The fields property can be using the semantic labels applied to properties. For example, if a property is label as title, you can retrieve it using the following syntax : label_title.Optional.</summary>
        public List<string> Fields { get; set; }
        /// <summary>Specifies the offset for the search results. Offset 0 returns the very first result. Optional.</summary>
        public int? From { get; set; }
        public SearchQuery Query { get; set; }
        /// <summary>The size of the page to be retrieved. Optional.</summary>
        public int? Size { get; set; }
        /// <summary>Contains the ordered collection of fields and direction to sort results. There can be at most 5 sort properties in the collection. Optional.</summary>
        public List<SortProperty> SortProperties { get; set; }
        /// <summary>
        /// Instantiates a new searchRequest and sets the default values.
        /// </summary>
        public SearchRequest() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"aggregationFilters", (o,n) => { (o as SearchRequest).AggregationFilters = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"aggregations", (o,n) => { (o as SearchRequest).Aggregations = n.GetCollectionOfObjectValues<AggregationOption>().ToList(); } },
                {"contentSources", (o,n) => { (o as SearchRequest).ContentSources = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"enableTopResults", (o,n) => { (o as SearchRequest).EnableTopResults = n.GetBoolValue(); } },
                {"entityTypes", (o,n) => { (o as SearchRequest).EntityTypes = n.GetCollectionOfEnumValues<EntityType>().ToList(); } },
                {"fields", (o,n) => { (o as SearchRequest).Fields = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"from", (o,n) => { (o as SearchRequest).From = n.GetIntValue(); } },
                {"query", (o,n) => { (o as SearchRequest).Query = n.GetObjectValue<SearchQuery>(); } },
                {"size", (o,n) => { (o as SearchRequest).Size = n.GetIntValue(); } },
                {"sortProperties", (o,n) => { (o as SearchRequest).SortProperties = n.GetCollectionOfObjectValues<SortProperty>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("aggregationFilters", AggregationFilters);
            writer.WriteCollectionOfObjectValues<AggregationOption>("aggregations", Aggregations);
            writer.WriteCollectionOfPrimitiveValues<string>("contentSources", ContentSources);
            writer.WriteBoolValue("enableTopResults", EnableTopResults);
            writer.WriteCollectionOfEnumValues<EntityType>("entityTypes", EntityTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("fields", Fields);
            writer.WriteIntValue("from", From);
            writer.WriteObjectValue<SearchQuery>("query", Query);
            writer.WriteIntValue("size", Size);
            writer.WriteCollectionOfObjectValues<SortProperty>("sortProperties", SortProperties);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
