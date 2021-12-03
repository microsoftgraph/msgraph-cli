using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PrinterDefaults : IParsable {
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
        /// <summary>The default output bin to place completed prints into. See the printer's capabilities for a list of supported output bins.</summary>
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"colorMode", (o,n) => { (o as PrinterDefaults).ColorMode = n.GetEnumValue<PrintColorMode>(); } },
                {"contentType", (o,n) => { (o as PrinterDefaults).ContentType = n.GetStringValue(); } },
                {"copiesPerJob", (o,n) => { (o as PrinterDefaults).CopiesPerJob = n.GetIntValue(); } },
                {"dpi", (o,n) => { (o as PrinterDefaults).Dpi = n.GetIntValue(); } },
                {"duplexMode", (o,n) => { (o as PrinterDefaults).DuplexMode = n.GetEnumValue<PrintDuplexMode>(); } },
                {"finishings", (o,n) => { (o as PrinterDefaults).Finishings = n.GetCollectionOfEnumValues<PrintFinishing>().ToList(); } },
                {"fitPdfToPage", (o,n) => { (o as PrinterDefaults).FitPdfToPage = n.GetBoolValue(); } },
                {"inputBin", (o,n) => { (o as PrinterDefaults).InputBin = n.GetStringValue(); } },
                {"mediaColor", (o,n) => { (o as PrinterDefaults).MediaColor = n.GetStringValue(); } },
                {"mediaSize", (o,n) => { (o as PrinterDefaults).MediaSize = n.GetStringValue(); } },
                {"mediaType", (o,n) => { (o as PrinterDefaults).MediaType = n.GetStringValue(); } },
                {"multipageLayout", (o,n) => { (o as PrinterDefaults).MultipageLayout = n.GetEnumValue<PrintMultipageLayout>(); } },
                {"orientation", (o,n) => { (o as PrinterDefaults).Orientation = n.GetEnumValue<PrintOrientation>(); } },
                {"outputBin", (o,n) => { (o as PrinterDefaults).OutputBin = n.GetStringValue(); } },
                {"pagesPerSheet", (o,n) => { (o as PrinterDefaults).PagesPerSheet = n.GetIntValue(); } },
                {"quality", (o,n) => { (o as PrinterDefaults).Quality = n.GetEnumValue<PrintQuality>(); } },
                {"scaling", (o,n) => { (o as PrinterDefaults).Scaling = n.GetEnumValue<PrintScaling>(); } },
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
