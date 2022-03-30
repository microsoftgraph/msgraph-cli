using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PageLinks : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Opens the page in the OneNote native client if it's installed.</summary>
        public ApiSdk.Models.Microsoft.Graph.ExternalLink OneNoteClientUrl { get; set; }
        /// <summary>Opens the page in OneNote on the web.</summary>
        public ApiSdk.Models.Microsoft.Graph.ExternalLink OneNoteWebUrl { get; set; }
        /// <summary>
        /// Instantiates a new pageLinks and sets the default values.
        /// </summary>
        public PageLinks() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.PageLinks CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PageLinks();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"oneNoteClientUrl", (o,n) => { (o as PageLinks).OneNoteClientUrl = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ExternalLink>(ApiSdk.Models.Microsoft.Graph.ExternalLink.CreateFromDiscriminatorValue); } },
                {"oneNoteWebUrl", (o,n) => { (o as PageLinks).OneNoteWebUrl = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ExternalLink>(ApiSdk.Models.Microsoft.Graph.ExternalLink.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ExternalLink>("oneNoteClientUrl", OneNoteClientUrl);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ExternalLink>("oneNoteWebUrl", OneNoteWebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
