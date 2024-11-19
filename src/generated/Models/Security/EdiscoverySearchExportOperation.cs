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
    public partial class EdiscoverySearchExportOperation : global::ApiSdk.Models.Security.CaseOperation, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The additional items to include in the export. The possible values are: none, teamsAndYammerConversations, cloudAttachments, allDocumentVersions, subfolderContents, listAttachments, unknownFutureValue.</summary>
        public global::ApiSdk.Models.Security.AdditionalOptions? AdditionalOptions { get; set; }
        /// <summary>The description of the export by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The name of export provided by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Items to be included in the export. The possible values are: searchHits, partiallyIndexed, unknownFutureValue.</summary>
        public global::ApiSdk.Models.Security.ExportCriteria? ExportCriteria { get; set; }
        /// <summary>Contains the properties for an export file metadata, including downloadUrl, fileName, and size.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Security.ExportFileMetadata>? ExportFileMetadata { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Security.ExportFileMetadata> ExportFileMetadata { get; set; }
#endif
        /// <summary>Format of the emails of the export. The possible values are: pst, msg, eml, unknownFutureValue.</summary>
        public global::ApiSdk.Models.Security.ExportFormat? ExportFormat { get; set; }
        /// <summary>Location scope for partially indexed items. You can choose to include partially indexed items only in responsive locations with search hits or in all targeted locations. The possible values are: responsiveLocations, nonresponsiveLocations, unknownFutureValue.</summary>
        public global::ApiSdk.Models.Security.ExportLocation? ExportLocation { get; set; }
        /// <summary>Indicates whether to export single items.</summary>
        public bool? ExportSingleItems { get; set; }
        /// <summary>The eDiscovery searches under each case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Security.EdiscoverySearch? Search { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Security.EdiscoverySearch Search { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Security.EdiscoverySearchExportOperation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Security.EdiscoverySearchExportOperation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Security.EdiscoverySearchExportOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "additionalOptions", n => { AdditionalOptions = n.GetEnumValue<global::ApiSdk.Models.Security.AdditionalOptions>(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "exportCriteria", n => { ExportCriteria = n.GetEnumValue<global::ApiSdk.Models.Security.ExportCriteria>(); } },
                { "exportFileMetadata", n => { ExportFileMetadata = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Security.ExportFileMetadata>(global::ApiSdk.Models.Security.ExportFileMetadata.CreateFromDiscriminatorValue)?.AsList(); } },
                { "exportFormat", n => { ExportFormat = n.GetEnumValue<global::ApiSdk.Models.Security.ExportFormat>(); } },
                { "exportLocation", n => { ExportLocation = n.GetEnumValue<global::ApiSdk.Models.Security.ExportLocation>(); } },
                { "exportSingleItems", n => { ExportSingleItems = n.GetBoolValue(); } },
                { "search", n => { Search = n.GetObjectValue<global::ApiSdk.Models.Security.EdiscoverySearch>(global::ApiSdk.Models.Security.EdiscoverySearch.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.Security.AdditionalOptions>("additionalOptions", AdditionalOptions);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.ExportCriteria>("exportCriteria", ExportCriteria);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Security.ExportFileMetadata>("exportFileMetadata", ExportFileMetadata);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.ExportFormat>("exportFormat", ExportFormat);
            writer.WriteEnumValue<global::ApiSdk.Models.Security.ExportLocation>("exportLocation", ExportLocation);
            writer.WriteBoolValue("exportSingleItems", ExportSingleItems);
            writer.WriteObjectValue<global::ApiSdk.Models.Security.EdiscoverySearch>("search", Search);
        }
    }
}
#pragma warning restore CS0618