using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class FolderView : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The method by which the folder should be sorted.</summary>
        public string SortBy { get; set; }
        /// <summary>If true, indicates that items should be sorted in descending order. Otherwise, items should be sorted ascending.</summary>
        public string SortOrder { get; set; }
        /// <summary>The type of view that should be used to represent the folder.</summary>
        public string ViewType { get; set; }
        /// <summary>
        /// Instantiates a new folderView and sets the default values.
        /// </summary>
        public FolderView() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"sortBy", (o,n) => { (o as FolderView).SortBy = n.GetStringValue(); } },
                {"sortOrder", (o,n) => { (o as FolderView).SortOrder = n.GetStringValue(); } },
                {"viewType", (o,n) => { (o as FolderView).ViewType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("sortBy", SortBy);
            writer.WriteStringValue("sortOrder", SortOrder);
            writer.WriteStringValue("viewType", ViewType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
