using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ServiceUpdateMessageViewpoint : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether the user archived the message.</summary>
        public bool? IsArchived { get; set; }
        /// <summary>Indicates whether the user marked the message as favorite.</summary>
        public bool? IsFavorited { get; set; }
        /// <summary>Indicates whether the user read the message.</summary>
        public bool? IsRead { get; set; }
        /// <summary>
        /// Instantiates a new serviceUpdateMessageViewpoint and sets the default values.
        /// </summary>
        public ServiceUpdateMessageViewpoint() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isArchived", (o,n) => { (o as ServiceUpdateMessageViewpoint).IsArchived = n.GetBoolValue(); } },
                {"isFavorited", (o,n) => { (o as ServiceUpdateMessageViewpoint).IsFavorited = n.GetBoolValue(); } },
                {"isRead", (o,n) => { (o as ServiceUpdateMessageViewpoint).IsRead = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteBoolValue("isFavorited", IsFavorited);
            writer.WriteBoolValue("isRead", IsRead);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
