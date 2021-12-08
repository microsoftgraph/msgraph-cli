using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ResourceVisualization : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A string describing where the item is stored. For example, the name of a SharePoint site or the user name identifying the owner of the OneDrive storing the item.</summary>
        public string ContainerDisplayName { get; set; }
        /// <summary>Can be used for filtering by the type of container in which the file is stored. Such as Site or OneDriveBusiness.</summary>
        public string ContainerType { get; set; }
        /// <summary>A path leading to the folder in which the item is stored.</summary>
        public string ContainerWebUrl { get; set; }
        /// <summary>The item's media type. Can be used for filtering for a specific type of file based on supported IANA Media Mime Types. Note that not all Media Mime Types are supported.</summary>
        public string MediaType { get; set; }
        /// <summary>A URL leading to the preview image for the item.</summary>
        public string PreviewImageUrl { get; set; }
        /// <summary>A preview text for the item.</summary>
        public string PreviewText { get; set; }
        /// <summary>The item's title text.</summary>
        public string Title { get; set; }
        /// <summary>The item's media type. Can be used for filtering for a specific file based on a specific type. See below for supported types.</summary>
        public string Type { get; set; }
        /// <summary>
        /// Instantiates a new resourceVisualization and sets the default values.
        /// </summary>
        public ResourceVisualization() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"containerDisplayName", (o,n) => { (o as ResourceVisualization).ContainerDisplayName = n.GetStringValue(); } },
                {"containerType", (o,n) => { (o as ResourceVisualization).ContainerType = n.GetStringValue(); } },
                {"containerWebUrl", (o,n) => { (o as ResourceVisualization).ContainerWebUrl = n.GetStringValue(); } },
                {"mediaType", (o,n) => { (o as ResourceVisualization).MediaType = n.GetStringValue(); } },
                {"previewImageUrl", (o,n) => { (o as ResourceVisualization).PreviewImageUrl = n.GetStringValue(); } },
                {"previewText", (o,n) => { (o as ResourceVisualization).PreviewText = n.GetStringValue(); } },
                {"title", (o,n) => { (o as ResourceVisualization).Title = n.GetStringValue(); } },
                {"type", (o,n) => { (o as ResourceVisualization).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("containerDisplayName", ContainerDisplayName);
            writer.WriteStringValue("containerType", ContainerType);
            writer.WriteStringValue("containerWebUrl", ContainerWebUrl);
            writer.WriteStringValue("mediaType", MediaType);
            writer.WriteStringValue("previewImageUrl", PreviewImageUrl);
            writer.WriteStringValue("previewText", PreviewText);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
