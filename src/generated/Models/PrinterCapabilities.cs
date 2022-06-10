using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class PrinterCapabilities : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A list of supported bottom margins(in microns) for the printer.</summary>
        public List<int?> BottomMargins { get; set; }
        /// <summary>True if the printer supports collating when printing muliple copies of a multi-page document; false otherwise.</summary>
        public bool? Collation { get; set; }
        /// <summary>The color modes supported by the printer. Valid values are described in the following table.</summary>
        public List<string> ColorModes { get; set; }
        /// <summary>A list of supported content (MIME) types that the printer supports. It is not guaranteed that the Universal Print service supports printing all of these MIME types.</summary>
        public List<string> ContentTypes { get; set; }
        /// <summary>The range of copies per job supported by the printer.</summary>
        public IntegerRange CopiesPerJob { get; set; }
        /// <summary>The list of print resolutions in DPI that are supported by the printer.</summary>
        public List<int?> Dpis { get; set; }
        /// <summary>The list of duplex modes that are supported by the printer. Valid values are described in the following table.</summary>
        public List<string> DuplexModes { get; set; }
        /// <summary>The list of feed orientations that are supported by the printer.</summary>
        public List<string> FeedOrientations { get; set; }
        /// <summary>Finishing processes the printer supports for a printed document.</summary>
        public List<string> Finishings { get; set; }
        /// <summary>Supported input bins for the printer.</summary>
        public List<string> InputBins { get; set; }
        /// <summary>True if color printing is supported by the printer; false otherwise. Read-only.</summary>
        public bool? IsColorPrintingSupported { get; set; }
        /// <summary>True if the printer supports printing by page ranges; false otherwise.</summary>
        public bool? IsPageRangeSupported { get; set; }
        /// <summary>A list of supported left margins(in microns) for the printer.</summary>
        public List<int?> LeftMargins { get; set; }
        /// <summary>The media (i.e., paper) colors supported by the printer.</summary>
        public List<string> MediaColors { get; set; }
        /// <summary>The media sizes supported by the printer. Supports standard size names for ISO and ANSI media sizes. Valid values are in the following table.</summary>
        public List<string> MediaSizes { get; set; }
        /// <summary>The media types supported by the printer.</summary>
        public List<string> MediaTypes { get; set; }
        /// <summary>The presentation directions supported by the printer. Supported values are described in the following table.</summary>
        public List<string> MultipageLayouts { get; set; }
        /// <summary>The print orientations supported by the printer. Valid values are described in the following table.</summary>
        public List<string> Orientations { get; set; }
        /// <summary>The printer&apos;s supported output bins (trays).</summary>
        public List<string> OutputBins { get; set; }
        /// <summary>Supported number of Input Pages to impose upon a single Impression.</summary>
        public List<int?> PagesPerSheet { get; set; }
        /// <summary>The print qualities supported by the printer.</summary>
        public List<string> Qualities { get; set; }
        /// <summary>A list of supported right margins(in microns) for the printer.</summary>
        public List<int?> RightMargins { get; set; }
        /// <summary>Supported print scalings.</summary>
        public List<string> Scalings { get; set; }
        /// <summary>True if the printer supports scaling PDF pages to match the print media size; false otherwise.</summary>
        public bool? SupportsFitPdfToPage { get; set; }
        /// <summary>A list of supported top margins(in microns) for the printer.</summary>
        public List<int?> TopMargins { get; set; }
        /// <summary>
        /// Instantiates a new printerCapabilities and sets the default values.
        /// </summary>
        public PrinterCapabilities() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PrinterCapabilities CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrinterCapabilities();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bottomMargins", n => { BottomMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"collation", n => { Collation = n.GetBoolValue(); } },
                {"colorModes", n => { ColorModes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"contentTypes", n => { ContentTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"copiesPerJob", n => { CopiesPerJob = n.GetObjectValue<IntegerRange>(IntegerRange.CreateFromDiscriminatorValue); } },
                {"dpis", n => { Dpis = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"duplexModes", n => { DuplexModes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"feedOrientations", n => { FeedOrientations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"finishings", n => { Finishings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"inputBins", n => { InputBins = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isColorPrintingSupported", n => { IsColorPrintingSupported = n.GetBoolValue(); } },
                {"isPageRangeSupported", n => { IsPageRangeSupported = n.GetBoolValue(); } },
                {"leftMargins", n => { LeftMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"mediaColors", n => { MediaColors = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"mediaSizes", n => { MediaSizes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"mediaTypes", n => { MediaTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"multipageLayouts", n => { MultipageLayouts = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"orientations", n => { Orientations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"outputBins", n => { OutputBins = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"pagesPerSheet", n => { PagesPerSheet = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"qualities", n => { Qualities = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"rightMargins", n => { RightMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
                {"scalings", n => { Scalings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportsFitPdfToPage", n => { SupportsFitPdfToPage = n.GetBoolValue(); } },
                {"topMargins", n => { TopMargins = n.GetCollectionOfPrimitiveValues<int?>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<int?>("bottomMargins", BottomMargins);
            writer.WriteBoolValue("collation", Collation);
            writer.WriteCollectionOfPrimitiveValues<string>("colorModes", ColorModes);
            writer.WriteCollectionOfPrimitiveValues<string>("contentTypes", ContentTypes);
            writer.WriteObjectValue<IntegerRange>("copiesPerJob", CopiesPerJob);
            writer.WriteCollectionOfPrimitiveValues<int?>("dpis", Dpis);
            writer.WriteCollectionOfPrimitiveValues<string>("duplexModes", DuplexModes);
            writer.WriteCollectionOfPrimitiveValues<string>("feedOrientations", FeedOrientations);
            writer.WriteCollectionOfPrimitiveValues<string>("finishings", Finishings);
            writer.WriteCollectionOfPrimitiveValues<string>("inputBins", InputBins);
            writer.WriteBoolValue("isColorPrintingSupported", IsColorPrintingSupported);
            writer.WriteBoolValue("isPageRangeSupported", IsPageRangeSupported);
            writer.WriteCollectionOfPrimitiveValues<int?>("leftMargins", LeftMargins);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaColors", MediaColors);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaSizes", MediaSizes);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaTypes", MediaTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("multipageLayouts", MultipageLayouts);
            writer.WriteCollectionOfPrimitiveValues<string>("orientations", Orientations);
            writer.WriteCollectionOfPrimitiveValues<string>("outputBins", OutputBins);
            writer.WriteCollectionOfPrimitiveValues<int?>("pagesPerSheet", PagesPerSheet);
            writer.WriteCollectionOfPrimitiveValues<string>("qualities", Qualities);
            writer.WriteCollectionOfPrimitiveValues<int?>("rightMargins", RightMargins);
            writer.WriteCollectionOfPrimitiveValues<string>("scalings", Scalings);
            writer.WriteBoolValue("supportsFitPdfToPage", SupportsFitPdfToPage);
            writer.WriteCollectionOfPrimitiveValues<int?>("topMargins", TopMargins);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
