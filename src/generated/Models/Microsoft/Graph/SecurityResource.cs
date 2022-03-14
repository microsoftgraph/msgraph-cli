using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SecurityResource : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the resource that is related to current alert. Required.</summary>
        public string Resource { get; set; }
        /// <summary>Represents type of security resources related to an alert. Possible values are: attacked, related.</summary>
        public SecurityResourceType? ResourceType { get; set; }
        /// <summary>
        /// Instantiates a new securityResource and sets the default values.
        /// </summary>
        public SecurityResource() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SecurityResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecurityResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"resource", (o,n) => { (o as SecurityResource).Resource = n.GetStringValue(); } },
                {"resourceType", (o,n) => { (o as SecurityResource).ResourceType = n.GetEnumValue<SecurityResourceType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("resource", Resource);
            writer.WriteEnumValue<SecurityResourceType>("resourceType", ResourceType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
