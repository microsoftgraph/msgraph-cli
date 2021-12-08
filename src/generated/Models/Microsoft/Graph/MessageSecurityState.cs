using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class MessageSecurityState : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string ConnectingIP { get; set; }
        public string DeliveryAction { get; set; }
        public string DeliveryLocation { get; set; }
        public string Directionality { get; set; }
        public string InternetMessageId { get; set; }
        public string MessageFingerprint { get; set; }
        public DateTimeOffset? MessageReceivedDateTime { get; set; }
        public string MessageSubject { get; set; }
        public string NetworkMessageId { get; set; }
        /// <summary>
        /// Instantiates a new messageSecurityState and sets the default values.
        /// </summary>
        public MessageSecurityState() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"connectingIP", (o,n) => { (o as MessageSecurityState).ConnectingIP = n.GetStringValue(); } },
                {"deliveryAction", (o,n) => { (o as MessageSecurityState).DeliveryAction = n.GetStringValue(); } },
                {"deliveryLocation", (o,n) => { (o as MessageSecurityState).DeliveryLocation = n.GetStringValue(); } },
                {"directionality", (o,n) => { (o as MessageSecurityState).Directionality = n.GetStringValue(); } },
                {"internetMessageId", (o,n) => { (o as MessageSecurityState).InternetMessageId = n.GetStringValue(); } },
                {"messageFingerprint", (o,n) => { (o as MessageSecurityState).MessageFingerprint = n.GetStringValue(); } },
                {"messageReceivedDateTime", (o,n) => { (o as MessageSecurityState).MessageReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                {"messageSubject", (o,n) => { (o as MessageSecurityState).MessageSubject = n.GetStringValue(); } },
                {"networkMessageId", (o,n) => { (o as MessageSecurityState).NetworkMessageId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("connectingIP", ConnectingIP);
            writer.WriteStringValue("deliveryAction", DeliveryAction);
            writer.WriteStringValue("deliveryLocation", DeliveryLocation);
            writer.WriteStringValue("directionality", Directionality);
            writer.WriteStringValue("internetMessageId", InternetMessageId);
            writer.WriteStringValue("messageFingerprint", MessageFingerprint);
            writer.WriteDateTimeOffsetValue("messageReceivedDateTime", MessageReceivedDateTime);
            writer.WriteStringValue("messageSubject", MessageSubject);
            writer.WriteStringValue("networkMessageId", NetworkMessageId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
