using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class RecentNotebookLinks : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Opens the notebook in the OneNote native client if it's installed.</summary>
        public ApiSdk.Models.Microsoft.Graph.ExternalLink OneNoteClientUrl { get; set; }
        /// <summary>Opens the notebook in OneNote on the web.</summary>
        public ApiSdk.Models.Microsoft.Graph.ExternalLink OneNoteWebUrl { get; set; }
        /// <summary>
        /// Instantiates a new recentNotebookLinks and sets the default values.
        /// </summary>
        public RecentNotebookLinks() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.RecentNotebookLinks CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RecentNotebookLinks();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"oneNoteClientUrl", (o,n) => { (o as RecentNotebookLinks).OneNoteClientUrl = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ExternalLink>(ApiSdk.Models.Microsoft.Graph.ExternalLink.CreateFromDiscriminatorValue); } },
                {"oneNoteWebUrl", (o,n) => { (o as RecentNotebookLinks).OneNoteWebUrl = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ExternalLink>(ApiSdk.Models.Microsoft.Graph.ExternalLink.CreateFromDiscriminatorValue); } },
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
