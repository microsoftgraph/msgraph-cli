using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Subscription : Entity, IParsable {
        /// <summary>Identifier of the application used to create the subscription. Read-only.</summary>
        public string ApplicationId { get; set; }
        /// <summary>Required. Indicates the type of change in the subscribed resource that will raise a change notification. The supported values are: created, updated, deleted. Multiple values can be combined using a comma-separated list.Note: Drive root item and list change notifications support only the updated changeType. User and group change notifications support updated and deleted changeType.</summary>
        public string ChangeType { get; set; }
        /// <summary>Optional. Specifies the value of the clientState property sent by the service in each change notification. The maximum length is 128 characters. The client can check that the change notification came from the service by comparing the value of the clientState property sent with the subscription with the value of the clientState property received with each change notification.</summary>
        public string ClientState { get; set; }
        /// <summary>Identifier of the user or service principal that created the subscription. If the app used delegated permissions to create the subscription, this field contains the id of the signed-in user the app called on behalf of. If the app used application permissions, this field contains the id of the service principal corresponding to the app. Read-only.</summary>
        public string CreatorId { get; set; }
        /// <summary>A base64-encoded representation of a certificate with a public key used to encrypt resource data in change notifications. Optional. Required when includeResourceData is true.</summary>
        public string EncryptionCertificate { get; set; }
        /// <summary>A custom app-provided identifier to help identify the certificate needed to decrypt resource data. Optional.</summary>
        public string EncryptionCertificateId { get; set; }
        /// <summary>Required. Specifies the date and time when the webhook subscription expires. The time is in UTC, and can be an amount of time from subscription creation that varies for the resource subscribed to.  See the table below for maximum supported subscription length of time.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>When set to true, change notifications include resource data (such as content of a chat message). Optional.</summary>
        public bool? IncludeResourceData { get; set; }
        /// <summary>Specifies the latest version of Transport Layer Security (TLS) that the notification endpoint, specified by notificationUrl, supports. The possible values are: v1_0, v1_1, v1_2, v1_3. For subscribers whose notification endpoint supports a version lower than the currently recommended version (TLS 1.2), specifying this property by a set timeline allows them to temporarily use their deprecated version of TLS before completing their upgrade to TLS 1.2. For these subscribers, not setting this property per the timeline would result in subscription operations failing. For subscribers whose notification endpoint already supports TLS 1.2, setting this property is optional. In such cases, Microsoft Graph defaults the property to v1_2.</summary>
        public string LatestSupportedTlsVersion { get; set; }
        /// <summary>The URL of the endpoint that receives lifecycle notifications, including subscriptionRemoved and missed notifications. This URL must make use of the HTTPS protocol. Optional. Read more about how Outlook resources use lifecycle notifications.</summary>
        public string LifecycleNotificationUrl { get; set; }
        /// <summary>OData Query Options for specifying value for the targeting resource. Clients receive notifications when resource reaches the state matching the query options provided here. With this new property in the subscription creation payload along with all existing properties, Webhooks will deliver notifications whenever a resource reaches the desired state mentioned in the notificationQueryOptions property eg  when the print job is completed, when a print job resource isFetchable property value becomes true etc.</summary>
        public string NotificationQueryOptions { get; set; }
        /// <summary>Required. The URL of the endpoint that will receive the change notifications. This URL must make use of the HTTPS protocol.</summary>
        public string NotificationUrl { get; set; }
        public string NotificationUrlAppId { get; set; }
        /// <summary>Required. Specifies the resource that will be monitored for changes. Do not include the base URL (https://graph.microsoft.com/v1.0/). See the possible resource path values for each supported resource.</summary>
        public string Resource { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"applicationId", (o,n) => { (o as Subscription).ApplicationId = n.GetStringValue(); } },
                {"changeType", (o,n) => { (o as Subscription).ChangeType = n.GetStringValue(); } },
                {"clientState", (o,n) => { (o as Subscription).ClientState = n.GetStringValue(); } },
                {"creatorId", (o,n) => { (o as Subscription).CreatorId = n.GetStringValue(); } },
                {"encryptionCertificate", (o,n) => { (o as Subscription).EncryptionCertificate = n.GetStringValue(); } },
                {"encryptionCertificateId", (o,n) => { (o as Subscription).EncryptionCertificateId = n.GetStringValue(); } },
                {"expirationDateTime", (o,n) => { (o as Subscription).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"includeResourceData", (o,n) => { (o as Subscription).IncludeResourceData = n.GetBoolValue(); } },
                {"latestSupportedTlsVersion", (o,n) => { (o as Subscription).LatestSupportedTlsVersion = n.GetStringValue(); } },
                {"lifecycleNotificationUrl", (o,n) => { (o as Subscription).LifecycleNotificationUrl = n.GetStringValue(); } },
                {"notificationQueryOptions", (o,n) => { (o as Subscription).NotificationQueryOptions = n.GetStringValue(); } },
                {"notificationUrl", (o,n) => { (o as Subscription).NotificationUrl = n.GetStringValue(); } },
                {"notificationUrlAppId", (o,n) => { (o as Subscription).NotificationUrlAppId = n.GetStringValue(); } },
                {"resource", (o,n) => { (o as Subscription).Resource = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("applicationId", ApplicationId);
            writer.WriteStringValue("changeType", ChangeType);
            writer.WriteStringValue("clientState", ClientState);
            writer.WriteStringValue("creatorId", CreatorId);
            writer.WriteStringValue("encryptionCertificate", EncryptionCertificate);
            writer.WriteStringValue("encryptionCertificateId", EncryptionCertificateId);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteBoolValue("includeResourceData", IncludeResourceData);
            writer.WriteStringValue("latestSupportedTlsVersion", LatestSupportedTlsVersion);
            writer.WriteStringValue("lifecycleNotificationUrl", LifecycleNotificationUrl);
            writer.WriteStringValue("notificationQueryOptions", NotificationQueryOptions);
            writer.WriteStringValue("notificationUrl", NotificationUrl);
            writer.WriteStringValue("notificationUrlAppId", NotificationUrlAppId);
            writer.WriteStringValue("resource", Resource);
        }
    }
}
