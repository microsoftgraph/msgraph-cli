using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Entity which represents a connection to Mobile threat defense partner.</summary>
    public class MobileThreatDefenseConnector : Entity, IParsable {
        /// <summary>For Android, set whether Intune must receive data from the data sync partner prior to marking a device compliant</summary>
        public bool? AndroidDeviceBlockedOnMissingPartnerData { get; set; }
        /// <summary>For Android, set whether data from the data sync partner should be used during compliance evaluations</summary>
        public bool? AndroidEnabled { get; set; }
        /// <summary>For IOS, set whether Intune must receive data from the data sync partner prior to marking a device compliant</summary>
        public bool? IosDeviceBlockedOnMissingPartnerData { get; set; }
        /// <summary>For IOS, get or set whether data from the data sync partner should be used during compliance evaluations</summary>
        public bool? IosEnabled { get; set; }
        /// <summary>DateTime of last Heartbeat recieved from the Data Sync Partner</summary>
        public DateTimeOffset? LastHeartbeatDateTime { get; set; }
        /// <summary>Partner state of this tenant.</summary>
        public MobileThreatPartnerTenantState? PartnerState { get; set; }
        /// <summary>Get or Set days the per tenant tolerance to unresponsiveness for this partner integration</summary>
        public int? PartnerUnresponsivenessThresholdInDays { get; set; }
        /// <summary>Get or set whether to block devices on the enabled platforms that do not meet the minimum version requirements of the Data Sync Partner</summary>
        public bool? PartnerUnsupportedOsVersionBlocked { get; set; }
        /// <summary>
        /// Instantiates a new mobileThreatDefenseConnector and sets the default values.
        /// </summary>
        public MobileThreatDefenseConnector() : base() {
            OdataType = "#microsoft.graph.mobileThreatDefenseConnector";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MobileThreatDefenseConnector CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileThreatDefenseConnector();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"androidDeviceBlockedOnMissingPartnerData", n => { AndroidDeviceBlockedOnMissingPartnerData = n.GetBoolValue(); } },
                {"androidEnabled", n => { AndroidEnabled = n.GetBoolValue(); } },
                {"iosDeviceBlockedOnMissingPartnerData", n => { IosDeviceBlockedOnMissingPartnerData = n.GetBoolValue(); } },
                {"iosEnabled", n => { IosEnabled = n.GetBoolValue(); } },
                {"lastHeartbeatDateTime", n => { LastHeartbeatDateTime = n.GetDateTimeOffsetValue(); } },
                {"partnerState", n => { PartnerState = n.GetEnumValue<MobileThreatPartnerTenantState>(); } },
                {"partnerUnresponsivenessThresholdInDays", n => { PartnerUnresponsivenessThresholdInDays = n.GetIntValue(); } },
                {"partnerUnsupportedOsVersionBlocked", n => { PartnerUnsupportedOsVersionBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("androidDeviceBlockedOnMissingPartnerData", AndroidDeviceBlockedOnMissingPartnerData);
            writer.WriteBoolValue("androidEnabled", AndroidEnabled);
            writer.WriteBoolValue("iosDeviceBlockedOnMissingPartnerData", IosDeviceBlockedOnMissingPartnerData);
            writer.WriteBoolValue("iosEnabled", IosEnabled);
            writer.WriteDateTimeOffsetValue("lastHeartbeatDateTime", LastHeartbeatDateTime);
            writer.WriteEnumValue<MobileThreatPartnerTenantState>("partnerState", PartnerState);
            writer.WriteIntValue("partnerUnresponsivenessThresholdInDays", PartnerUnresponsivenessThresholdInDays);
            writer.WriteBoolValue("partnerUnsupportedOsVersionBlocked", PartnerUnsupportedOsVersionBlocked);
        }
    }
}
