// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class PrintJobConfiguration : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether the printer should collate pages wehen printing multiple copies of a multi-page document.</summary>
        public bool? Collate { get; set; }
        /// <summary>The color mode the printer should use to print the job. Valid values are described in the table below. Read-only.</summary>
        public global::ApiSdk.Models.PrintColorMode? ColorMode { get; set; }
        /// <summary>The number of copies that should be printed. Read-only.</summary>
        public int? Copies { get; set; }
        /// <summary>The resolution to use when printing the job, expressed in dots per inch (DPI). Read-only.</summary>
        public int? Dpi { get; set; }
        /// <summary>The duplex mode the printer should use when printing the job. Valid values are described in the table below. Read-only.</summary>
        public global::ApiSdk.Models.PrintDuplexMode? DuplexMode { get; set; }
        /// <summary>The orientation to use when feeding media into the printer. Valid values are described in the following table. Read-only.</summary>
        public global::ApiSdk.Models.PrinterFeedOrientation? FeedOrientation { get; set; }
        /// <summary>Finishing processes to use when printing.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PrintFinishing?>? Finishings { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PrintFinishing?> Finishings { get; set; }
#endif
        /// <summary>True to fit each page of a PDF document to a physical sheet of media; false to let the printer decide how to lay out impressions.</summary>
        public bool? FitPdfToPage { get; set; }
        /// <summary>The input bin (tray) to use when printing. See the printer&apos;s capabilities for a list of supported input bins.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InputBin { get; set; }
#nullable restore
#else
        public string InputBin { get; set; }
#endif
        /// <summary>The margin settings to use when printing.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PrintMargin? Margin { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PrintMargin Margin { get; set; }
#endif
        /// <summary>The media size to use when printing. Supports standard size names for ISO and ANSI media sizes. Valid values listed in the printerCapabilities topic.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MediaSize { get; set; }
#nullable restore
#else
        public string MediaSize { get; set; }
#endif
        /// <summary>The default media (such as paper) type to print the document on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MediaType { get; set; }
#nullable restore
#else
        public string MediaType { get; set; }
#endif
        /// <summary>The direction to lay out pages when multiple pages are being printed per sheet. Valid values are described in the following table.</summary>
        public global::ApiSdk.Models.PrintMultipageLayout? MultipageLayout { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The orientation setting the printer should use when printing the job. Valid values are described in the following table.</summary>
        public global::ApiSdk.Models.PrintOrientation? Orientation { get; set; }
        /// <summary>The output bin to place completed prints into. See the printer&apos;s capabilities for a list of supported output bins.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OutputBin { get; set; }
#nullable restore
#else
        public string OutputBin { get; set; }
#endif
        /// <summary>The page ranges to print. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.IntegerRange>? PageRanges { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.IntegerRange> PageRanges { get; set; }
#endif
        /// <summary>The number of document pages to print on each sheet.</summary>
        public int? PagesPerSheet { get; set; }
        /// <summary>The print quality to use when printing the job. Valid values are described in the table below. Read-only.</summary>
        public global::ApiSdk.Models.PrintQuality? Quality { get; set; }
        /// <summary>Specifies how the printer should scale the document data to fit the requested media. Valid values are described in the following table.</summary>
        public global::ApiSdk.Models.PrintScaling? Scaling { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.PrintJobConfiguration"/> and sets the default values.
        /// </summary>
        public PrintJobConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PrintJobConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.PrintJobConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.PrintJobConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "collate", n => { Collate = n.GetBoolValue(); } },
                { "colorMode", n => { ColorMode = n.GetEnumValue<global::ApiSdk.Models.PrintColorMode>(); } },
                { "copies", n => { Copies = n.GetIntValue(); } },
                { "dpi", n => { Dpi = n.GetIntValue(); } },
                { "duplexMode", n => { DuplexMode = n.GetEnumValue<global::ApiSdk.Models.PrintDuplexMode>(); } },
                { "feedOrientation", n => { FeedOrientation = n.GetEnumValue<global::ApiSdk.Models.PrinterFeedOrientation>(); } },
                { "finishings", n => { Finishings = n.GetCollectionOfEnumValues<global::ApiSdk.Models.PrintFinishing>()?.AsList(); } },
                { "fitPdfToPage", n => { FitPdfToPage = n.GetBoolValue(); } },
                { "inputBin", n => { InputBin = n.GetStringValue(); } },
                { "margin", n => { Margin = n.GetObjectValue<global::ApiSdk.Models.PrintMargin>(global::ApiSdk.Models.PrintMargin.CreateFromDiscriminatorValue); } },
                { "mediaSize", n => { MediaSize = n.GetStringValue(); } },
                { "mediaType", n => { MediaType = n.GetStringValue(); } },
                { "multipageLayout", n => { MultipageLayout = n.GetEnumValue<global::ApiSdk.Models.PrintMultipageLayout>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "orientation", n => { Orientation = n.GetEnumValue<global::ApiSdk.Models.PrintOrientation>(); } },
                { "outputBin", n => { OutputBin = n.GetStringValue(); } },
                { "pageRanges", n => { PageRanges = n.GetCollectionOfObjectValues<global::ApiSdk.Models.IntegerRange>(global::ApiSdk.Models.IntegerRange.CreateFromDiscriminatorValue)?.AsList(); } },
                { "pagesPerSheet", n => { PagesPerSheet = n.GetIntValue(); } },
                { "quality", n => { Quality = n.GetEnumValue<global::ApiSdk.Models.PrintQuality>(); } },
                { "scaling", n => { Scaling = n.GetEnumValue<global::ApiSdk.Models.PrintScaling>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("collate", Collate);
            writer.WriteEnumValue<global::ApiSdk.Models.PrintColorMode>("colorMode", ColorMode);
            writer.WriteIntValue("copies", Copies);
            writer.WriteIntValue("dpi", Dpi);
            writer.WriteEnumValue<global::ApiSdk.Models.PrintDuplexMode>("duplexMode", DuplexMode);
            writer.WriteEnumValue<global::ApiSdk.Models.PrinterFeedOrientation>("feedOrientation", FeedOrientation);
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.PrintFinishing>("finishings", Finishings);
            writer.WriteBoolValue("fitPdfToPage", FitPdfToPage);
            writer.WriteStringValue("inputBin", InputBin);
            writer.WriteObjectValue<global::ApiSdk.Models.PrintMargin>("margin", Margin);
            writer.WriteStringValue("mediaSize", MediaSize);
            writer.WriteStringValue("mediaType", MediaType);
            writer.WriteEnumValue<global::ApiSdk.Models.PrintMultipageLayout>("multipageLayout", MultipageLayout);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::ApiSdk.Models.PrintOrientation>("orientation", Orientation);
            writer.WriteStringValue("outputBin", OutputBin);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.IntegerRange>("pageRanges", PageRanges);
            writer.WriteIntValue("pagesPerSheet", PagesPerSheet);
            writer.WriteEnumValue<global::ApiSdk.Models.PrintQuality>("quality", Quality);
            writer.WriteEnumValue<global::ApiSdk.Models.PrintScaling>("scaling", Scaling);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
