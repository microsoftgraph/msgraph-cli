using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class CallOptions : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The hideBotAfterEscalation property</summary>
        public bool? HideBotAfterEscalation { get; set; }
        /// <summary>The isContentSharingNotificationEnabled property</summary>
        public bool? IsContentSharingNotificationEnabled { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>
        /// Instantiates a new callOptions and sets the default values.
        /// </summary>
        public CallOptions() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.callOptions";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CallOptions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.incomingCallOptions" => new IncomingCallOptions(),
                "#microsoft.graph.outgoingCallOptions" => new OutgoingCallOptions(),
                _ => new CallOptions(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"hideBotAfterEscalation", n => { HideBotAfterEscalation = n.GetBoolValue(); } },
                {"isContentSharingNotificationEnabled", n => { IsContentSharingNotificationEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("hideBotAfterEscalation", HideBotAfterEscalation);
            writer.WriteBoolValue("isContentSharingNotificationEnabled", IsContentSharingNotificationEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
