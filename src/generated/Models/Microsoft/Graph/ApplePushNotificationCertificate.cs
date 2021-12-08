using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ApplePushNotificationCertificate : Entity, IParsable {
        /// <summary>Apple Id of the account used to create the MDM push certificate.</summary>
        public string AppleIdentifier { get; set; }
        /// <summary>Not yet documented</summary>
        public string Certificate { get; set; }
        /// <summary>Certificate serial number. This property is read-only.</summary>
        public string CertificateSerialNumber { get; set; }
        /// <summary>The expiration date and time for Apple push notification certificate.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>Last modified date and time for Apple push notification certificate.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Topic Id.</summary>
        public string TopicIdentifier { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appleIdentifier", (o,n) => { (o as ApplePushNotificationCertificate).AppleIdentifier = n.GetStringValue(); } },
                {"certificate", (o,n) => { (o as ApplePushNotificationCertificate).Certificate = n.GetStringValue(); } },
                {"certificateSerialNumber", (o,n) => { (o as ApplePushNotificationCertificate).CertificateSerialNumber = n.GetStringValue(); } },
                {"expirationDateTime", (o,n) => { (o as ApplePushNotificationCertificate).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as ApplePushNotificationCertificate).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"topicIdentifier", (o,n) => { (o as ApplePushNotificationCertificate).TopicIdentifier = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appleIdentifier", AppleIdentifier);
            writer.WriteStringValue("certificate", Certificate);
            writer.WriteStringValue("certificateSerialNumber", CertificateSerialNumber);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("topicIdentifier", TopicIdentifier);
        }
    }
}
