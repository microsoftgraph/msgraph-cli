using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class MessageSecurityState : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectingIP { get; set; }
#nullable restore
#else
        public string ConnectingIP { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeliveryAction { get; set; }
#nullable restore
#else
        public string DeliveryAction { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeliveryLocation { get; set; }
#nullable restore
#else
        public string DeliveryLocation { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Directionality { get; set; }
#nullable restore
#else
        public string Directionality { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternetMessageId { get; set; }
#nullable restore
#else
        public string InternetMessageId { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessageFingerprint { get; set; }
#nullable restore
#else
        public string MessageFingerprint { get; set; }
#endif
        public DateTimeOffset? MessageReceivedDateTime { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessageSubject { get; set; }
#nullable restore
#else
        public string MessageSubject { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkMessageId { get; set; }
#nullable restore
#else
        public string NetworkMessageId { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new messageSecurityState and sets the default values.
        /// </summary>
        public MessageSecurityState() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static MessageSecurityState CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static MessageSecurityState CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MessageSecurityState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"connectingIP", n => { ConnectingIP = n.GetStringValue(); } },
                {"deliveryAction", n => { DeliveryAction = n.GetStringValue(); } },
                {"deliveryLocation", n => { DeliveryLocation = n.GetStringValue(); } },
                {"directionality", n => { Directionality = n.GetStringValue(); } },
                {"internetMessageId", n => { InternetMessageId = n.GetStringValue(); } },
                {"messageFingerprint", n => { MessageFingerprint = n.GetStringValue(); } },
                {"messageReceivedDateTime", n => { MessageReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                {"messageSubject", n => { MessageSubject = n.GetStringValue(); } },
                {"networkMessageId", n => { NetworkMessageId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
