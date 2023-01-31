using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class SearchRequest : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AggregationFilters { get; set; }
#nullable restore
#else
        public List<string> AggregationFilters { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AggregationOption>? Aggregations { get; set; }
#nullable restore
#else
        public List<AggregationOption> Aggregations { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ContentSources { get; set; }
#nullable restore
#else
        public List<string> ContentSources { get; set; }
#endif
        public bool? EnableTopResults { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EntityType?>? EntityTypes { get; set; }
#nullable restore
#else
        public List<EntityType?> EntityTypes { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Fields { get; set; }
#nullable restore
#else
        public List<string> Fields { get; set; }
#endif
        public int? From { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SearchQuery? Query { get; set; }
#nullable restore
#else
        public SearchQuery Query { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SearchAlterationOptions? QueryAlterationOptions { get; set; }
#nullable restore
#else
        public SearchAlterationOptions QueryAlterationOptions { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ResultTemplateOption? ResultTemplateOptions { get; set; }
#nullable restore
#else
        public ResultTemplateOption ResultTemplateOptions { get; set; }
#endif
        public int? Size { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SortProperty>? SortProperties { get; set; }
#nullable restore
#else
        public List<SortProperty> SortProperties { get; set; }
#endif
        /// <summary>
        /// Instantiates a new searchRequest and sets the default values.
        /// </summary>
        public SearchRequest() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static SearchRequest CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static SearchRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"aggregationFilters", n => { AggregationFilters = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"aggregations", n => { Aggregations = n.GetCollectionOfObjectValues<AggregationOption>(AggregationOption.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contentSources", n => { ContentSources = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"enableTopResults", n => { EnableTopResults = n.GetBoolValue(); } },
                {"entityTypes", n => { EntityTypes = n.GetCollectionOfEnumValues<EntityType>()?.ToList(); } },
                {"fields", n => { Fields = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"from", n => { From = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"query", n => { Query = n.GetObjectValue<SearchQuery>(SearchQuery.CreateFromDiscriminatorValue); } },
                {"queryAlterationOptions", n => { QueryAlterationOptions = n.GetObjectValue<SearchAlterationOptions>(SearchAlterationOptions.CreateFromDiscriminatorValue); } },
                {"resultTemplateOptions", n => { ResultTemplateOptions = n.GetObjectValue<ResultTemplateOption>(ResultTemplateOption.CreateFromDiscriminatorValue); } },
                {"size", n => { Size = n.GetIntValue(); } },
                {"sortProperties", n => { SortProperties = n.GetCollectionOfObjectValues<SortProperty>(SortProperty.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("aggregationFilters", AggregationFilters);
            writer.WriteCollectionOfObjectValues<AggregationOption>("aggregations", Aggregations);
            writer.WriteCollectionOfPrimitiveValues<string>("contentSources", ContentSources);
            writer.WriteBoolValue("enableTopResults", EnableTopResults);
            writer.WriteCollectionOfEnumValues<EntityType>("entityTypes", EntityTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("fields", Fields);
            writer.WriteIntValue("from", From);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<SearchQuery>("query", Query);
            writer.WriteObjectValue<SearchAlterationOptions>("queryAlterationOptions", QueryAlterationOptions);
            writer.WriteObjectValue<ResultTemplateOption>("resultTemplateOptions", ResultTemplateOptions);
            writer.WriteIntValue("size", Size);
            writer.WriteCollectionOfObjectValues<SortProperty>("sortProperties", SortProperties);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
