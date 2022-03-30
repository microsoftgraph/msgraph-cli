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
        public ApiSdk.Models.Microsoft.Graph.Initiator InitiatedBy { get; set; }
        /// <summary>The unique ID for the whole provisioning job.</summary>
        public string JobId { get; set; }
        /// <summary>Details of each property that was modified in this provisioning action on this object.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ModifiedProperty> ModifiedProperties { get; set; }
        /// <summary>Indicates the activity name or the operation name. Possible values are: create, update, delete, stageddelete, disable, other and unknownFutureValue. For a list of activities logged, refer to Azure AD activity list.</summary>
        public ApiSdk.Models.Microsoft.Graph.ProvisioningAction? ProvisioningAction { get; set; }
        /// <summary>Details of provisioning status.</summary>
        public ApiSdk.Models.Microsoft.Graph.ProvisioningStatusInfo ProvisioningStatusInfo { get; set; }
        /// <summary>Details of each step in provisioning.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ProvisioningStep> ProvisioningSteps { get; set; }
        /// <summary>Represents the service principal used for provisioning.</summary>
        public ApiSdk.Models.Microsoft.Graph.ProvisioningServicePrincipal ServicePrincipal { get; set; }
        /// <summary>Details of source object being provisioned.</summary>
        public ApiSdk.Models.Microsoft.Graph.ProvisionedIdentity SourceIdentity { get; set; }
        /// <summary>Details of source system of the object being provisioned.</summary>
        public ApiSdk.Models.Microsoft.Graph.ProvisioningSystem SourceSystem { get; set; }
        /// <summary>Details of target object being provisioned.</summary>
        public ApiSdk.Models.Microsoft.Graph.ProvisionedIdentity TargetIdentity { get; set; }
        /// <summary>Details of target system of the object being provisioned.</summary>
        public ApiSdk.Models.Microsoft.Graph.ProvisioningSystem TargetSystem { get; set; }
        /// <summary>Unique Azure AD tenant ID.</summary>
        public string TenantId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.ProvisioningObjectSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProvisioningObjectSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activityDateTime", (o,n) => { (o as ProvisioningObjectSummary).ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"changeId", (o,n) => { (o as ProvisioningObjectSummary).ChangeId = n.GetStringValue(); } },
                {"cycleId", (o,n) => { (o as ProvisioningObjectSummary).CycleId = n.GetStringValue(); } },
                {"durationInMilliseconds", (o,n) => { (o as ProvisioningObjectSummary).DurationInMilliseconds = n.GetIntValue(); } },
                {"initiatedBy", (o,n) => { (o as ProvisioningObjectSummary).InitiatedBy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Initiator>(ApiSdk.Models.Microsoft.Graph.Initiator.CreateFromDiscriminatorValue); } },
                {"jobId", (o,n) => { (o as ProvisioningObjectSummary).JobId = n.GetStringValue(); } },
                {"modifiedProperties", (o,n) => { (o as ProvisioningObjectSummary).ModifiedProperties = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ModifiedProperty>(ApiSdk.Models.Microsoft.Graph.ModifiedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"provisioningAction", (o,n) => { (o as ProvisioningObjectSummary).ProvisioningAction = n.GetEnumValue<ProvisioningAction>(); } },
                {"provisioningStatusInfo", (o,n) => { (o as ProvisioningObjectSummary).ProvisioningStatusInfo = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ProvisioningStatusInfo>(ApiSdk.Models.Microsoft.Graph.ProvisioningStatusInfo.CreateFromDiscriminatorValue); } },
                {"provisioningSteps", (o,n) => { (o as ProvisioningObjectSummary).ProvisioningSteps = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ProvisioningStep>(ApiSdk.Models.Microsoft.Graph.ProvisioningStep.CreateFromDiscriminatorValue).ToList(); } },
                {"servicePrincipal", (o,n) => { (o as ProvisioningObjectSummary).ServicePrincipal = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ProvisioningServicePrincipal>(ApiSdk.Models.Microsoft.Graph.ProvisioningServicePrincipal.CreateFromDiscriminatorValue); } },
                {"sourceIdentity", (o,n) => { (o as ProvisioningObjectSummary).SourceIdentity = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ProvisionedIdentity>(ApiSdk.Models.Microsoft.Graph.ProvisionedIdentity.CreateFromDiscriminatorValue); } },
                {"sourceSystem", (o,n) => { (o as ProvisioningObjectSummary).SourceSystem = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ProvisioningSystem>(ApiSdk.Models.Microsoft.Graph.ProvisioningSystem.CreateFromDiscriminatorValue); } },
                {"targetIdentity", (o,n) => { (o as ProvisioningObjectSummary).TargetIdentity = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ProvisionedIdentity>(ApiSdk.Models.Microsoft.Graph.ProvisionedIdentity.CreateFromDiscriminatorValue); } },
                {"targetSystem", (o,n) => { (o as ProvisioningObjectSummary).TargetSystem = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ProvisioningSystem>(ApiSdk.Models.Microsoft.Graph.ProvisioningSystem.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Initiator>("initiatedBy", InitiatedBy);
            writer.WriteStringValue("jobId", JobId);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ModifiedProperty>("modifiedProperties", ModifiedProperties);
            writer.WriteEnumValue<ProvisioningAction>("provisioningAction", ProvisioningAction);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ProvisioningStatusInfo>("provisioningStatusInfo", ProvisioningStatusInfo);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ProvisioningStep>("provisioningSteps", ProvisioningSteps);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ProvisioningServicePrincipal>("servicePrincipal", ServicePrincipal);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ProvisionedIdentity>("sourceIdentity", SourceIdentity);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ProvisioningSystem>("sourceSystem", SourceSystem);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ProvisionedIdentity>("targetIdentity", TargetIdentity);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ProvisioningSystem>("targetSystem", TargetSystem);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
