using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class PrinterDefaults : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The default color mode to use when printing the document. Valid values are described in the following table.</summary>
        public PrintColorMode? ColorMode { get; set; }
        /// <summary>The default content (MIME) type to use when processing documents.</summary>
        public string ContentType { get; set; }
        /// <summary>The default number of copies printed per job.</summary>
        public int? CopiesPerJob { get; set; }
        /// <summary>The default resolution in DPI to use when printing the job.</summary>
        public int? Dpi { get; set; }
        /// <summary>The default duplex (double-sided) configuration to use when printing a document. Valid values are described in the following table.</summary>
        public PrintDuplexMode? DuplexMode { get; set; }
        /// <summary>The default set of finishings to apply to print jobs. Valid values are described in the following table.</summary>
        public List<PrintFinishing?> Finishings { get; set; }
        /// <summary>The default fitPdfToPage setting. True to fit each page of a PDF document to a physical sheet of media; false to let the printer decide how to lay out impressions.</summary>
        public bool? FitPdfToPage { get; set; }
        /// <summary>The default input bin that serves as the paper source.</summary>
        public string InputBin { get; set; }
        /// <summary>The default media (such as paper) color to print the document on.</summary>
        public string MediaColor { get; set; }
        /// <summary>The default media size to use. Supports standard size names for ISO and ANSI media sizes. Valid values are listed in the printerCapabilities topic.</summary>
        public string MediaSize { get; set; }
        /// <summary>The default media (such as paper) type to print the document on.</summary>
        public string MediaType { get; set; }
        /// <summary>The default direction to lay out pages when multiple pages are being printed per sheet. Valid values are described in the following table.</summary>
        public PrintMultipageLayout? MultipageLayout { get; set; }
        /// <summary>The default orientation to use when printing the document. Valid values are described in the following table.</summary>
        public PrintOrientation? Orientation { get; set; }
        /// <summary>The default output bin to place completed prints into. See the printer&apos;s capabilities for a list of supported output bins.</summary>
        public string OutputBin { get; set; }
        /// <summary>The default number of document pages to print on each sheet.</summary>
        public int? PagesPerSheet { get; set; }
        /// <summary>The default quality to use when printing the document. Valid values are described in the following table.</summary>
        public PrintQuality? Quality { get; set; }
        /// <summary>Specifies how the printer scales the document data to fit the requested media. Valid values are described in the following table.</summary>
        public PrintScaling? Scaling { get; set; }
        /// <summary>
        /// Instantiates a new printerDefaults and sets the default values.
        /// </summary>
        public PrinterDefaults() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PrinterDefaults CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrinterDefaults();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"colorMode", n => { ColorMode = n.GetEnumValue<PrintColorMode>(); } },
                {"contentType", n => { ContentType = n.GetStringValue(); } },
                {"copiesPerJob", n => { CopiesPerJob = n.GetIntValue(); } },
                {"dpi", n => { Dpi = n.GetIntValue(); } },
                {"duplexMode", n => { DuplexMode = n.GetEnumValue<PrintDuplexMode>(); } },
                {"finishings", n => { Finishings = n.GetCollectionOfEnumValues<PrintFinishing>().ToList(); } },
                {"fitPdfToPage", n => { FitPdfToPage = n.GetBoolValue(); } },
                {"inputBin", n => { InputBin = n.GetStringValue(); } },
                {"mediaColor", n => { MediaColor = n.GetStringValue(); } },
                {"mediaSize", n => { MediaSize = n.GetStringValue(); } },
                {"mediaType", n => { MediaType = n.GetStringValue(); } },
                {"multipageLayout", n => { MultipageLayout = n.GetEnumValue<PrintMultipageLayout>(); } },
                {"orientation", n => { Orientation = n.GetEnumValue<PrintOrientation>(); } },
                {"outputBin", n => { OutputBin = n.GetStringValue(); } },
                {"pagesPerSheet", n => { PagesPerSheet = n.GetIntValue(); } },
                {"quality", n => { Quality = n.GetEnumValue<PrintQuality>(); } },
                {"scaling", n => { Scaling = n.GetEnumValue<PrintScaling>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<PrintColorMode>("colorMode", ColorMode);
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteIntValue("copiesPerJob", CopiesPerJob);
            writer.WriteIntValue("dpi", Dpi);
            writer.WriteEnumValue<PrintDuplexMode>("duplexMode", DuplexMode);
            writer.WriteCollectionOfEnumValues<PrintFinishing>("finishings", Finishings);
            writer.WriteBoolValue("fitPdfToPage", FitPdfToPage);
            writer.WriteStringValue("inputBin", InputBin);
            writer.WriteStringValue("mediaColor", MediaColor);
            writer.WriteStringValue("mediaSize", MediaSize);
            writer.WriteStringValue("mediaType", MediaType);
            writer.WriteEnumValue<PrintMultipageLayout>("multipageLayout", MultipageLayout);
            writer.WriteEnumValue<PrintOrientation>("orientation", Orientation);
            writer.WriteStringValue("outputBin", OutputBin);
            writer.WriteIntValue("pagesPerSheet", PagesPerSheet);
            writer.WriteEnumValue<PrintQuality>("quality", Quality);
            writer.WriteEnumValue<PrintScaling>("scaling", Scaling);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
