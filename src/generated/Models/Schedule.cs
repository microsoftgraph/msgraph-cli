using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Schedule : Entity, IParsable {
        /// <summary>Indicates whether the schedule is enabled for the team. Required.</summary>
        public bool? Enabled { get; set; }
        /// <summary>The offerShiftRequests property</summary>
        public List<OfferShiftRequest> OfferShiftRequests { get; set; }
        /// <summary>Indicates whether offer shift requests are enabled for the schedule.</summary>
        public bool? OfferShiftRequestsEnabled { get; set; }
        /// <summary>The openShiftChangeRequests property</summary>
        public List<OpenShiftChangeRequest> OpenShiftChangeRequests { get; set; }
        /// <summary>The openShifts property</summary>
        public List<OpenShift> OpenShifts { get; set; }
        /// <summary>Indicates whether open shifts are enabled for the schedule.</summary>
        public bool? OpenShiftsEnabled { get; set; }
        /// <summary>The status of the schedule provisioning. The possible values are notStarted, running, completed, failed.</summary>
        public OperationStatus? ProvisionStatus { get; set; }
        /// <summary>Additional information about why schedule provisioning failed.</summary>
        public string ProvisionStatusCode { get; set; }
        /// <summary>The logical grouping of users in the schedule (usually by role).</summary>
        public List<SchedulingGroup> SchedulingGroups { get; set; }
        /// <summary>The shifts in the schedule.</summary>
        public List<Shift> Shifts { get; set; }
        /// <summary>The swapShiftsChangeRequests property</summary>
        public List<SwapShiftsChangeRequest> SwapShiftsChangeRequests { get; set; }
        /// <summary>Indicates whether swap shifts requests are enabled for the schedule.</summary>
        public bool? SwapShiftsRequestsEnabled { get; set; }
        /// <summary>Indicates whether time clock is enabled for the schedule.</summary>
        public bool? TimeClockEnabled { get; set; }
        /// <summary>The set of reasons for a time off in the schedule.</summary>
        public List<TimeOffReason> TimeOffReasons { get; set; }
        /// <summary>The timeOffRequests property</summary>
        public List<TimeOffRequest> TimeOffRequests { get; set; }
        /// <summary>Indicates whether time off requests are enabled for the schedule.</summary>
        public bool? TimeOffRequestsEnabled { get; set; }
        /// <summary>The instances of times off in the schedule.</summary>
        public List<TimeOff> TimesOff { get; set; }
        /// <summary>Indicates the time zone of the schedule team using tz database format. Required.</summary>
        public string TimeZone { get; set; }
        /// <summary>The workforceIntegrationIds property</summary>
        public List<string> WorkforceIntegrationIds { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Schedule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Schedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"offerShiftRequests", n => { OfferShiftRequests = n.GetCollectionOfObjectValues<OfferShiftRequest>(OfferShiftRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"offerShiftRequestsEnabled", n => { OfferShiftRequestsEnabled = n.GetBoolValue(); } },
                {"openShiftChangeRequests", n => { OpenShiftChangeRequests = n.GetCollectionOfObjectValues<OpenShiftChangeRequest>(OpenShiftChangeRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"openShifts", n => { OpenShifts = n.GetCollectionOfObjectValues<OpenShift>(OpenShift.CreateFromDiscriminatorValue).ToList(); } },
                {"openShiftsEnabled", n => { OpenShiftsEnabled = n.GetBoolValue(); } },
                {"provisionStatus", n => { ProvisionStatus = n.GetEnumValue<OperationStatus>(); } },
                {"provisionStatusCode", n => { ProvisionStatusCode = n.GetStringValue(); } },
                {"schedulingGroups", n => { SchedulingGroups = n.GetCollectionOfObjectValues<SchedulingGroup>(SchedulingGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"shifts", n => { Shifts = n.GetCollectionOfObjectValues<Shift>(Shift.CreateFromDiscriminatorValue).ToList(); } },
                {"swapShiftsChangeRequests", n => { SwapShiftsChangeRequests = n.GetCollectionOfObjectValues<SwapShiftsChangeRequest>(SwapShiftsChangeRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"swapShiftsRequestsEnabled", n => { SwapShiftsRequestsEnabled = n.GetBoolValue(); } },
                {"timeClockEnabled", n => { TimeClockEnabled = n.GetBoolValue(); } },
                {"timeOffReasons", n => { TimeOffReasons = n.GetCollectionOfObjectValues<TimeOffReason>(TimeOffReason.CreateFromDiscriminatorValue).ToList(); } },
                {"timeOffRequests", n => { TimeOffRequests = n.GetCollectionOfObjectValues<TimeOffRequest>(TimeOffRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"timeOffRequestsEnabled", n => { TimeOffRequestsEnabled = n.GetBoolValue(); } },
                {"timesOff", n => { TimesOff = n.GetCollectionOfObjectValues<TimeOff>(TimeOff.CreateFromDiscriminatorValue).ToList(); } },
                {"timeZone", n => { TimeZone = n.GetStringValue(); } },
                {"workforceIntegrationIds", n => { WorkforceIntegrationIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteCollectionOfObjectValues<OfferShiftRequest>("offerShiftRequests", OfferShiftRequests);
            writer.WriteBoolValue("offerShiftRequestsEnabled", OfferShiftRequestsEnabled);
            writer.WriteCollectionOfObjectValues<OpenShiftChangeRequest>("openShiftChangeRequests", OpenShiftChangeRequests);
            writer.WriteCollectionOfObjectValues<OpenShift>("openShifts", OpenShifts);
            writer.WriteBoolValue("openShiftsEnabled", OpenShiftsEnabled);
            writer.WriteEnumValue<OperationStatus>("provisionStatus", ProvisionStatus);
            writer.WriteStringValue("provisionStatusCode", ProvisionStatusCode);
            writer.WriteCollectionOfObjectValues<SchedulingGroup>("schedulingGroups", SchedulingGroups);
            writer.WriteCollectionOfObjectValues<Shift>("shifts", Shifts);
            writer.WriteCollectionOfObjectValues<SwapShiftsChangeRequest>("swapShiftsChangeRequests", SwapShiftsChangeRequests);
            writer.WriteBoolValue("swapShiftsRequestsEnabled", SwapShiftsRequestsEnabled);
            writer.WriteBoolValue("timeClockEnabled", TimeClockEnabled);
            writer.WriteCollectionOfObjectValues<TimeOffReason>("timeOffReasons", TimeOffReasons);
            writer.WriteCollectionOfObjectValues<TimeOffRequest>("timeOffRequests", TimeOffRequests);
            writer.WriteBoolValue("timeOffRequestsEnabled", TimeOffRequestsEnabled);
            writer.WriteCollectionOfObjectValues<TimeOff>("timesOff", TimesOff);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteCollectionOfPrimitiveValues<string>("workforceIntegrationIds", WorkforceIntegrationIds);
        }
    }
}
