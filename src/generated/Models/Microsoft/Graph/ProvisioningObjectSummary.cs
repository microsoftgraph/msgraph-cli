using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ProvisioningObjectSummary : Entity, IParsable {
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ActivityDateTime { get; set; }
        /// <summary>Unique ID of this change in this cycle.</summary>
        public string ChangeId { get; set; }
        /// <summary>Unique ID per job iteration.</summary>
        public string CycleId { get; set; }
        /// <summary>Indicates how long this provisioning action took to finish. Measured in milliseconds.</summary>
        public int? DurationInMilliseconds { get; set; }
        /// <summary>Details of who initiated this provisioning.</summary>
        public Initiator InitiatedBy { get; set; }
        /// <summary>The unique ID for the whole provisioning job.</summary>
        public string JobId { get; set; }
        /// <summary>Details of each property that was modified in this provisioning action on this object.</summary>
        public List<ModifiedProperty> ModifiedProperties { get; set; }
        /// <summary>Indicates the activity name or the operation name. Possible values are: create, update, delete, stageddelete, disable, other and unknownFutureValue. For a list of activities logged, refer to Azure AD activity list.</summary>
        public ProvisioningAction? ProvisioningAction { get; set; }
        /// <summary>Details of provisioning status.</summary>
        public ProvisioningStatusInfo ProvisioningStatusInfo { get; set; }
        /// <summary>Details of each step in provisioning.</summary>
        public List<ProvisioningStep> ProvisioningSteps { get; set; }
        /// <summary>Represents the service principal used for provisioning.</summary>
        public ProvisioningServicePrincipal ServicePrincipal { get; set; }
        /// <summary>Details of source object being provisioned.</summary>
        public ProvisionedIdentity SourceIdentity { get; set; }
        /// <summary>Details of source system of the object being provisioned.</summary>
        public ProvisioningSystem SourceSystem { get; set; }
        /// <summary>Details of target object being provisioned.</summary>
        public ProvisionedIdentity TargetIdentity { get; set; }
        /// <summary>Details of target system of the object being provisioned.</summary>
        public ProvisioningSystem TargetSystem { get; set; }
        /// <summary>Unique Azure AD tenant ID.</summary>
        public string TenantId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activityDateTime", (o,n) => { (o as ProvisioningObjectSummary).ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"changeId", (o,n) => { (o as ProvisioningObjectSummary).ChangeId = n.GetStringValue(); } },
                {"cycleId", (o,n) => { (o as ProvisioningObjectSummary).CycleId = n.GetStringValue(); } },
                {"durationInMilliseconds", (o,n) => { (o as ProvisioningObjectSummary).DurationInMilliseconds = n.GetIntValue(); } },
                {"initiatedBy", (o,n) => { (o as ProvisioningObjectSummary).InitiatedBy = n.GetObjectValue<Initiator>(); } },
                {"jobId", (o,n) => { (o as ProvisioningObjectSummary).JobId = n.GetStringValue(); } },
                {"modifiedProperties", (o,n) => { (o as ProvisioningObjectSummary).ModifiedProperties = n.GetCollectionOfObjectValues<ModifiedProperty>().ToList(); } },
                {"provisioningAction", (o,n) => { (o as ProvisioningObjectSummary).ProvisioningAction = n.GetEnumValue<ProvisioningAction>(); } },
                {"provisioningStatusInfo", (o,n) => { (o as ProvisioningObjectSummary).ProvisioningStatusInfo = n.GetObjectValue<ProvisioningStatusInfo>(); } },
                {"provisioningSteps", (o,n) => { (o as ProvisioningObjectSummary).ProvisioningSteps = n.GetCollectionOfObjectValues<ProvisioningStep>().ToList(); } },
                {"servicePrincipal", (o,n) => { (o as ProvisioningObjectSummary).ServicePrincipal = n.GetObjectValue<ProvisioningServicePrincipal>(); } },
                {"sourceIdentity", (o,n) => { (o as ProvisioningObjectSummary).SourceIdentity = n.GetObjectValue<ProvisionedIdentity>(); } },
                {"sourceSystem", (o,n) => { (o as ProvisioningObjectSummary).SourceSystem = n.GetObjectValue<ProvisioningSystem>(); } },
                {"targetIdentity", (o,n) => { (o as ProvisioningObjectSummary).TargetIdentity = n.GetObjectValue<ProvisionedIdentity>(); } },
                {"targetSystem", (o,n) => { (o as ProvisioningObjectSummary).TargetSystem = n.GetObjectValue<ProvisioningSystem>(); } },
                {"tenantId", (o,n) => { (o as ProvisioningObjectSummary).TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteStringValue("changeId", ChangeId);
            writer.WriteStringValue("cycleId", CycleId);
            writer.WriteIntValue("durationInMilliseconds", DurationInMilliseconds);
            writer.WriteObjectValue<Initiator>("initiatedBy", InitiatedBy);
            writer.WriteStringValue("jobId", JobId);
            writer.WriteCollectionOfObjectValues<ModifiedProperty>("modifiedProperties", ModifiedProperties);
            writer.WriteEnumValue<ProvisioningAction>("provisioningAction", ProvisioningAction);
            writer.WriteObjectValue<ProvisioningStatusInfo>("provisioningStatusInfo", ProvisioningStatusInfo);
            writer.WriteCollectionOfObjectValues<ProvisioningStep>("provisioningSteps", ProvisioningSteps);
            writer.WriteObjectValue<ProvisioningServicePrincipal>("servicePrincipal", ServicePrincipal);
            writer.WriteObjectValue<ProvisionedIdentity>("sourceIdentity", SourceIdentity);
            writer.WriteObjectValue<ProvisioningSystem>("sourceSystem", SourceSystem);
            writer.WriteObjectValue<ProvisionedIdentity>("targetIdentity", TargetIdentity);
            writer.WriteObjectValue<ProvisioningSystem>("targetSystem", TargetSystem);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
