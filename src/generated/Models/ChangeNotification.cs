using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ChangeNotification : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The changeType property</summary>
        public ApiSdk.Models.ChangeType? ChangeType { get; set; }
        /// <summary>Value of the clientState property sent in the subscription request (if any). The maximum length is 255 characters. The client can check whether the change notification came from the service by comparing the values of the clientState property. The value of the clientState property sent with the subscription is compared with the value of the clientState property received with each change notification. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientState { get; set; }
#nullable restore
#else
        public string ClientState { get; set; }
#endif
        /// <summary>(Preview) Encrypted content attached with the change notification. Only provided if encryptionCertificate and includeResourceData were defined during the subscription request and if the resource supports it. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ChangeNotificationEncryptedContent? EncryptedContent { get; set; }
#nullable restore
#else
        public ChangeNotificationEncryptedContent EncryptedContent { get; set; }
#endif
        /// <summary>Unique ID for the notification. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The type of lifecycle notification if the current notification is a lifecycle notification. Optional. Supported values are missed, subscriptionRemoved, reauthorizationRequired. Optional.</summary>
        public LifecycleEventType? LifecycleEvent { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The URI of the resource that emitted the change notification relative to https://graph.microsoft.com. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Resource { get; set; }
#nullable restore
#else
        public string Resource { get; set; }
#endif
        /// <summary>The content of this property depends on the type of resource being subscribed to. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ResourceData? ResourceData { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ResourceData ResourceData { get; set; }
#endif
        /// <summary>The expiration time for the subscription. Required.</summary>
        public DateTimeOffset? SubscriptionExpirationDateTime { get; set; }
        /// <summary>The unique identifier of the subscription that generated the notification.Required.</summary>
        public Guid? SubscriptionId { get; set; }
        /// <summary>The unique identifier of the tenant from which the change notification originated. Required.</summary>
        public Guid? TenantId { get; set; }
        /// <summary>
        /// Instantiates a new changeNotification and sets the default values.
        /// </summary>
        public ChangeNotification() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ChangeNotification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChangeNotification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"changeType", n => { ChangeType = n.GetEnumValue<ChangeType>(); } },
                {"clientState", n => { ClientState = n.GetStringValue(); } },
                {"encryptedContent", n => { EncryptedContent = n.GetObjectValue<ChangeNotificationEncryptedContent>(ChangeNotificationEncryptedContent.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"lifecycleEvent", n => { LifecycleEvent = n.GetEnumValue<LifecycleEventType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"resource", n => { Resource = n.GetStringValue(); } },
                {"resourceData", n => { ResourceData = n.GetObjectValue<ApiSdk.Models.ResourceData>(ApiSdk.Models.ResourceData.CreateFromDiscriminatorValue); } },
                {"subscriptionExpirationDateTime", n => { SubscriptionExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"subscriptionId", n => { SubscriptionId = n.GetGuidValue(); } },
                {"tenantId", n => { TenantId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ChangeType>("changeType", ChangeType);
            writer.WriteStringValue("clientState", ClientState);
            writer.WriteObjectValue<ChangeNotificationEncryptedContent>("encryptedContent", EncryptedContent);
            writer.WriteStringValue("id", Id);
            writer.WriteEnumValue<LifecycleEventType>("lifecycleEvent", LifecycleEvent);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("resource", Resource);
            writer.WriteObjectValue<ApiSdk.Models.ResourceData>("resourceData", ResourceData);
            writer.WriteDateTimeOffsetValue("subscriptionExpirationDateTime", SubscriptionExpirationDateTime);
            writer.WriteGuidValue("subscriptionId", SubscriptionId);
            writer.WriteGuidValue("tenantId", TenantId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
