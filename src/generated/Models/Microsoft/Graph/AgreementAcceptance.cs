using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AgreementAcceptance : Entity, IParsable {
        /// <summary>ID of the agreement file accepted by the user.</summary>
        public string AgreementFileId { get; set; }
        /// <summary>ID of the agreement.</summary>
        public string AgreementId { get; set; }
        /// <summary>The display name of the device used for accepting the agreement.</summary>
        public string DeviceDisplayName { get; set; }
        /// <summary>The unique identifier of the device used for accepting the agreement.</summary>
        public string DeviceId { get; set; }
        /// <summary>The operating system used for accepting the agreement.</summary>
        public string DeviceOSType { get; set; }
        /// <summary>The operating system version of the device used for accepting the agreement.</summary>
        public string DeviceOSVersion { get; set; }
        /// <summary>The expiration date time of the acceptance. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? RecordedDateTime { get; set; }
        /// <summary>Possible values are: accepted, declined.</summary>
        public AgreementAcceptanceState? State { get; set; }
        /// <summary>Display name of the user when the acceptance was recorded.</summary>
        public string UserDisplayName { get; set; }
        /// <summary>Email of the user when the acceptance was recorded.</summary>
        public string UserEmail { get; set; }
        /// <summary>ID of the user who accepted the agreement.</summary>
        public string UserId { get; set; }
        /// <summary>UPN of the user when the acceptance was recorded.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"agreementFileId", (o,n) => { (o as AgreementAcceptance).AgreementFileId = n.GetStringValue(); } },
                {"agreementId", (o,n) => { (o as AgreementAcceptance).AgreementId = n.GetStringValue(); } },
                {"deviceDisplayName", (o,n) => { (o as AgreementAcceptance).DeviceDisplayName = n.GetStringValue(); } },
                {"deviceId", (o,n) => { (o as AgreementAcceptance).DeviceId = n.GetStringValue(); } },
                {"deviceOSType", (o,n) => { (o as AgreementAcceptance).DeviceOSType = n.GetStringValue(); } },
                {"deviceOSVersion", (o,n) => { (o as AgreementAcceptance).DeviceOSVersion = n.GetStringValue(); } },
                {"expirationDateTime", (o,n) => { (o as AgreementAcceptance).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"recordedDateTime", (o,n) => { (o as AgreementAcceptance).RecordedDateTime = n.GetDateTimeOffsetValue(); } },
                {"state", (o,n) => { (o as AgreementAcceptance).State = n.GetEnumValue<AgreementAcceptanceState>(); } },
                {"userDisplayName", (o,n) => { (o as AgreementAcceptance).UserDisplayName = n.GetStringValue(); } },
                {"userEmail", (o,n) => { (o as AgreementAcceptance).UserEmail = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as AgreementAcceptance).UserId = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as AgreementAcceptance).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("agreementFileId", AgreementFileId);
            writer.WriteStringValue("agreementId", AgreementId);
            writer.WriteStringValue("deviceDisplayName", DeviceDisplayName);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceOSType", DeviceOSType);
            writer.WriteStringValue("deviceOSVersion", DeviceOSVersion);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("recordedDateTime", RecordedDateTime);
            writer.WriteEnumValue<AgreementAcceptanceState>("state", State);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userEmail", UserEmail);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
