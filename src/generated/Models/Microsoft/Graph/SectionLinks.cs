using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SectionLinks : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Opens the section in the OneNote native client if it's installed.</summary>
        public ExternalLink OneNoteClientUrl { get; set; }
        /// <summary>Opens the section in OneNote on the web.</summary>
        public ExternalLink OneNoteWebUrl { get; set; }
        /// <summary>
        /// Instantiates a new sectionLinks and sets the default values.
        /// </summary>
        public SectionLinks() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SectionLinks CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SectionLinks();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"oneNoteClientUrl", (o,n) => { (o as SectionLinks).OneNoteClientUrl = n.GetObjectValue<ExternalLink>(ExternalLink.CreateFromDiscriminatorValue); } },
                {"oneNoteWebUrl", (o,n) => { (o as SectionLinks).OneNoteWebUrl = n.GetObjectValue<ExternalLink>(ExternalLink.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ExternalLink>("oneNoteClientUrl", OneNoteClientUrl);
            writer.WriteObjectValue<ExternalLink>("oneNoteWebUrl", OneNoteWebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
