using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    public class EdiscoveryExportOperation : CaseOperation, IParsable {
        /// <summary>The description provided for the export.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The exportFileMetadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.Security.ExportFileMetadata>? ExportFileMetadata { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.Security.ExportFileMetadata> ExportFileMetadata { get; set; }
#endif
        /// <summary>The options provided for the export. For more details, see reviewSet: export. Possible values are: originalFiles, text, pdfReplacement,  tags.</summary>
        public ApiSdk.Models.Security.ExportOptions? ExportOptions { get; set; }
        /// <summary>The options provided that specify the structure of the export. For more details, see reviewSet: export. Possible values are: none, directory, pst.</summary>
        public ExportFileStructure? ExportStructure { get; set; }
        /// <summary>The name provided for the export.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OutputName { get; set; }
#nullable restore
#else
        public string OutputName { get; set; }
#endif
        /// <summary>Review set from where documents are exported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EdiscoveryReviewSet? ReviewSet { get; set; }
#nullable restore
#else
        public EdiscoveryReviewSet ReviewSet { get; set; }
#endif
        /// <summary>The review set query which is used to filter the documents for export.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EdiscoveryReviewSetQuery? ReviewSetQuery { get; set; }
#nullable restore
#else
        public EdiscoveryReviewSetQuery ReviewSetQuery { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EdiscoveryExportOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoveryExportOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"exportFileMetadata", n => { ExportFileMetadata = n.GetCollectionOfObjectValues<ApiSdk.Models.Security.ExportFileMetadata>(ApiSdk.Models.Security.ExportFileMetadata.CreateFromDiscriminatorValue)?.ToList(); } },
                {"exportOptions", n => { ExportOptions = n.GetEnumValue<ExportOptions>(); } },
                {"exportStructure", n => { ExportStructure = n.GetEnumValue<ExportFileStructure>(); } },
                {"outputName", n => { OutputName = n.GetStringValue(); } },
                {"reviewSet", n => { ReviewSet = n.GetObjectValue<EdiscoveryReviewSet>(EdiscoveryReviewSet.CreateFromDiscriminatorValue); } },
                {"reviewSetQuery", n => { ReviewSetQuery = n.GetObjectValue<EdiscoveryReviewSetQuery>(EdiscoveryReviewSetQuery.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Security.ExportFileMetadata>("exportFileMetadata", ExportFileMetadata);
            writer.WriteEnumValue<ExportOptions>("exportOptions", ExportOptions);
            writer.WriteEnumValue<ExportFileStructure>("exportStructure", ExportStructure);
            writer.WriteStringValue("outputName", OutputName);
            writer.WriteObjectValue<EdiscoveryReviewSet>("reviewSet", ReviewSet);
            writer.WriteObjectValue<EdiscoveryReviewSetQuery>("reviewSetQuery", ReviewSetQuery);
        }
    }
}
