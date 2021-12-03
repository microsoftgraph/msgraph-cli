using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ComplianceManagementPartner : Entity, IParsable {
        /// <summary>User groups which enroll Android devices through partner.</summary>
        public List<ComplianceManagementPartnerAssignment> AndroidEnrollmentAssignments { get; set; }
        /// <summary>Partner onboarded for Android devices.</summary>
        public bool? AndroidOnboarded { get; set; }
        /// <summary>Partner display name</summary>
        public string DisplayName { get; set; }
        /// <summary>User groups which enroll ios devices through partner.</summary>
        public List<ComplianceManagementPartnerAssignment> IosEnrollmentAssignments { get; set; }
        /// <summary>Partner onboarded for ios devices.</summary>
        public bool? IosOnboarded { get; set; }
        /// <summary>Timestamp of last heartbeat after admin onboarded to the compliance management partner</summary>
        public DateTimeOffset? LastHeartbeatDateTime { get; set; }
        /// <summary>User groups which enroll Mac devices through partner.</summary>
        public List<ComplianceManagementPartnerAssignment> MacOsEnrollmentAssignments { get; set; }
        /// <summary>Partner onboarded for Mac devices.</summary>
        public bool? MacOsOnboarded { get; set; }
        /// <summary>Partner state of this tenant. Possible values are: unknown, unavailable, enabled, terminated, rejected, unresponsive.</summary>
        public DeviceManagementPartnerTenantState? PartnerState { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"androidEnrollmentAssignments", (o,n) => { (o as ComplianceManagementPartner).AndroidEnrollmentAssignments = n.GetCollectionOfObjectValues<ComplianceManagementPartnerAssignment>().ToList(); } },
                {"androidOnboarded", (o,n) => { (o as ComplianceManagementPartner).AndroidOnboarded = n.GetBoolValue(); } },
                {"displayName", (o,n) => { (o as ComplianceManagementPartner).DisplayName = n.GetStringValue(); } },
                {"iosEnrollmentAssignments", (o,n) => { (o as ComplianceManagementPartner).IosEnrollmentAssignments = n.GetCollectionOfObjectValues<ComplianceManagementPartnerAssignment>().ToList(); } },
                {"iosOnboarded", (o,n) => { (o as ComplianceManagementPartner).IosOnboarded = n.GetBoolValue(); } },
                {"lastHeartbeatDateTime", (o,n) => { (o as ComplianceManagementPartner).LastHeartbeatDateTime = n.GetDateTimeOffsetValue(); } },
                {"macOsEnrollmentAssignments", (o,n) => { (o as ComplianceManagementPartner).MacOsEnrollmentAssignments = n.GetCollectionOfObjectValues<ComplianceManagementPartnerAssignment>().ToList(); } },
                {"macOsOnboarded", (o,n) => { (o as ComplianceManagementPartner).MacOsOnboarded = n.GetBoolValue(); } },
                {"partnerState", (o,n) => { (o as ComplianceManagementPartner).PartnerState = n.GetEnumValue<DeviceManagementPartnerTenantState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ComplianceManagementPartnerAssignment>("androidEnrollmentAssignments", AndroidEnrollmentAssignments);
            writer.WriteBoolValue("androidOnboarded", AndroidOnboarded);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<ComplianceManagementPartnerAssignment>("iosEnrollmentAssignments", IosEnrollmentAssignments);
            writer.WriteBoolValue("iosOnboarded", IosOnboarded);
            writer.WriteDateTimeOffsetValue("lastHeartbeatDateTime", LastHeartbeatDateTime);
            writer.WriteCollectionOfObjectValues<ComplianceManagementPartnerAssignment>("macOsEnrollmentAssignments", MacOsEnrollmentAssignments);
            writer.WriteBoolValue("macOsOnboarded", MacOsOnboarded);
            writer.WriteEnumValue<DeviceManagementPartnerTenantState>("partnerState", PartnerState);
        }
    }
}
