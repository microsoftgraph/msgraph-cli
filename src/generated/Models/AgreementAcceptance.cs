using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of agreement entities.</summary>
    public class AgreementAcceptance : Entity, IParsable {
        /// <summary>The identifier of the agreement file accepted by the user.</summary>
        public string AgreementFileId { get; set; }
        /// <summary>The identifier of the agreement.</summary>
        public string AgreementId { get; set; }
        /// <summary>The display name of the device used for accepting the agreement.</summary>
        public string DeviceDisplayName { get; set; }
        /// <summary>The unique identifier of the device used for accepting the agreement.</summary>
        public string DeviceId { get; set; }
        /// <summary>The operating system used to accept the agreement.</summary>
        public string DeviceOSType { get; set; }
        /// <summary>The operating system version of the device used to accept the agreement.</summary>
        public string DeviceOSVersion { get; set; }
        /// <summary>The expiration date time of the acceptance. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? RecordedDateTime { get; set; }
        /// <summary>The state of the agreement acceptance. Possible values are: accepted, declined. Supports $filter (eq).</summary>
        public AgreementAcceptanceState? State { get; set; }
        /// <summary>Display name of the user when the acceptance was recorded.</summary>
        public string UserDisplayName { get; set; }
        /// <summary>Email of the user when the acceptance was recorded.</summary>
        public string UserEmail { get; set; }
        /// <summary>The identifier of the user who accepted the agreement.</summary>
        public string UserId { get; set; }
        /// <summary>UPN of the user when the acceptance was recorded.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Instantiates a new agreementAcceptance and sets the default values.
        /// </summary>
        public AgreementAcceptance() : base() {
            OdataType = "#microsoft.graph.agreementAcceptance";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AgreementAcceptance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AgreementAcceptance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"agreementFileId", n => { AgreementFileId = n.GetStringValue(); } },
                {"agreementId", n => { AgreementId = n.GetStringValue(); } },
                {"deviceDisplayName", n => { DeviceDisplayName = n.GetStringValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceOSType", n => { DeviceOSType = n.GetStringValue(); } },
                {"deviceOSVersion", n => { DeviceOSVersion = n.GetStringValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"recordedDateTime", n => { RecordedDateTime = n.GetDateTimeOffsetValue(); } },
                {"state", n => { State = n.GetEnumValue<AgreementAcceptanceState>(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userEmail", n => { UserEmail = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
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
