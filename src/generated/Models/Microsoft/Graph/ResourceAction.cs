using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ResourceAction : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Allowed Actions</summary>
        public List<string> AllowedResourceActions { get; set; }
        /// <summary>Not Allowed Actions.</summary>
        public List<string> NotAllowedResourceActions { get; set; }
        /// <summary>
        /// Instantiates a new resourceAction and sets the default values.
        /// </summary>
        public ResourceAction() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowedResourceActions", (o,n) => { (o as ResourceAction).AllowedResourceActions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"notAllowedResourceActions", (o,n) => { (o as ResourceAction).NotAllowedResourceActions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("allowedResourceActions", AllowedResourceActions);
            writer.WriteCollectionOfPrimitiveValues<string>("notAllowedResourceActions", NotAllowedResourceActions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
