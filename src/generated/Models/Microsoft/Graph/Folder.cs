using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Folder : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of children contained immediately within this container.</summary>
        public int? ChildCount { get; set; }
        /// <summary>A collection of properties defining the recommended view for the folder.</summary>
        public ApiSdk.Models.Microsoft.Graph.FolderView View { get; set; }
        /// <summary>
        /// Instantiates a new folder and sets the default values.
        /// </summary>
        public Folder() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.Folder CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Folder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"childCount", (o,n) => { (o as Folder).ChildCount = n.GetIntValue(); } },
                {"view", (o,n) => { (o as Folder).View = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.FolderView>(ApiSdk.Models.Microsoft.Graph.FolderView.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("childCount", ChildCount);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.FolderView>("view", View);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
