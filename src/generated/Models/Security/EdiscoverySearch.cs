// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class EdiscoverySearch : global::ApiSdk.Models.Security.Search, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Adds an additional source to the eDiscovery search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Security.DataSource>? AdditionalSources { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Security.DataSource> AdditionalSources { get; set; }
#endif
        /// <summary>Adds the results of the eDiscovery search to the specified reviewSet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Security.EdiscoveryAddToReviewSetOperation? AddToReviewSetOperation { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Security.EdiscoveryAddToReviewSetOperation AddToReviewSetOperation { get; set; }
#endif
        /// <summary>Custodian sources that are included in the eDiscovery search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Security.DataSource>? CustodianSources { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Security.DataSource> CustodianSources { get; set; }
#endif
        /// <summary>When specified, the collection spans across a service for an entire workload. Possible values are: none, allTenantMailboxes, allTenantSites, allCaseCustodians, allCaseNoncustodialDataSources.</summary>
        public global::ApiSdk.Models.Security.DataSourceScopes? DataSourceScopes { get; set; }
        /// <summary>The last estimate operation associated with the eDiscovery search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Security.EdiscoveryEstimateOperation? LastEstimateStatisticsOperation { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Security.EdiscoveryEstimateOperation LastEstimateStatisticsOperation { get; set; }
#endif
        /// <summary>noncustodialDataSource sources that are included in the eDiscovery search</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Security.EdiscoveryNoncustodialDataSource>? NoncustodialSources { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Security.EdiscoveryNoncustodialDataSource> NoncustodialSources { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Security.EdiscoverySearch"/> and sets the default values.
        /// </summary>
        public EdiscoverySearch() : base()
        {
            OdataType = "#microsoft.graph.security.ediscoverySearch";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Security.EdiscoverySearch"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Security.EdiscoverySearch CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Security.EdiscoverySearch();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "addToReviewSetOperation", n => { AddToReviewSetOperation = n.GetObjectValue<global::ApiSdk.Models.Security.EdiscoveryAddToReviewSetOperation>(global::ApiSdk.Models.Security.EdiscoveryAddToReviewSetOperation.CreateFromDiscriminatorValue); } },
                { "additionalSources", n => { AdditionalSources = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Security.DataSource>(global::ApiSdk.Models.Security.DataSource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "custodianSources", n => { CustodianSources = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Security.DataSource>(global::ApiSdk.Models.Security.DataSource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "dataSourceScopes", n => { DataSourceScopes = n.GetEnumValue<global::ApiSdk.Models.Security.DataSourceScopes>(); } },
                { "lastEstimateStatisticsOperation", n => { LastEstimateStatisticsOperation = n.GetObjectValue<global::ApiSdk.Models.Security.EdiscoveryEstimateOperation>(global::ApiSdk.Models.Security.EdiscoveryEstimateOperation.CreateFromDiscriminatorValue); } },
                { "noncustodialSources", n => { NoncustodialSources = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Security.EdiscoveryNoncustodialDataSource>(global::ApiSdk.Models.Security.EdiscoveryNoncustodialDataSource.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Security.DataSource>("additionalSources", AdditionalSources);
            writer.WriteObjectValue<global::ApiSdk.Models.Security.EdiscoveryAddToReviewSetOperation>("addToReviewSetOperation", AddToReviewSetOperation);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Security.DataSource>("custodianSources", CustodianSources);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.DataSourceScopes>("dataSourceScopes", DataSourceScopes);
            writer.WriteObjectValue<global::ApiSdk.Models.Security.EdiscoveryEstimateOperation>("lastEstimateStatisticsOperation", LastEstimateStatisticsOperation);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Security.EdiscoveryNoncustodialDataSource>("noncustodialSources", NoncustodialSources);
        }
    }
}
#pragma warning restore CS0618
