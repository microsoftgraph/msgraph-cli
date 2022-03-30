using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Schedule : Entity, IParsable {
        /// <summary>Indicates whether the schedule is enabled for the team. Required.</summary>
        public bool? Enabled { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.OfferShiftRequest> OfferShiftRequests { get; set; }
        /// <summary>Indicates whether offer shift requests are enabled for the schedule.</summary>
        public bool? OfferShiftRequestsEnabled { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.OpenShiftChangeRequest> OpenShiftChangeRequests { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.OpenShift> OpenShifts { get; set; }
        /// <summary>Indicates whether open shifts are enabled for the schedule.</summary>
        public bool? OpenShiftsEnabled { get; set; }
        /// <summary>The status of the schedule provisioning. The possible values are notStarted, running, completed, failed.</summary>
        public OperationStatus? ProvisionStatus { get; set; }
        /// <summary>Additional information about why schedule provisioning failed.</summary>
        public string ProvisionStatusCode { get; set; }
        /// <summary>The logical grouping of users in the schedule (usually by role).</summary>
        public List<ApiSdk.Models.Microsoft.Graph.SchedulingGroup> SchedulingGroups { get; set; }
        /// <summary>The shifts in the schedule.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Shift> Shifts { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.SwapShiftsChangeRequest> SwapShiftsChangeRequests { get; set; }
        /// <summary>Indicates whether swap shifts requests are enabled for the schedule.</summary>
        public bool? SwapShiftsRequestsEnabled { get; set; }
        /// <summary>Indicates whether time clock is enabled for the schedule.</summary>
        public bool? TimeClockEnabled { get; set; }
        /// <summary>The set of reasons for a time off in the schedule.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.TimeOffReason> TimeOffReasons { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.TimeOffRequest> TimeOffRequests { get; set; }
        /// <summary>Indicates whether time off requests are enabled for the schedule.</summary>
        public bool? TimeOffRequestsEnabled { get; set; }
        /// <summary>The instances of times off in the schedule.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.TimeOff> TimesOff { get; set; }
        /// <summary>Indicates the time zone of the schedule team using tz database format. Required.</summary>
        public string TimeZone { get; set; }
        public List<string> WorkforceIntegrationIds { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.Schedule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Schedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"enabled", (o,n) => { (o as Schedule).Enabled = n.GetBoolValue(); } },
                {"offerShiftRequests", (o,n) => { (o as Schedule).OfferShiftRequests = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OfferShiftRequest>(ApiSdk.Models.Microsoft.Graph.OfferShiftRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"offerShiftRequestsEnabled", (o,n) => { (o as Schedule).OfferShiftRequestsEnabled = n.GetBoolValue(); } },
                {"openShiftChangeRequests", (o,n) => { (o as Schedule).OpenShiftChangeRequests = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OpenShiftChangeRequest>(ApiSdk.Models.Microsoft.Graph.OpenShiftChangeRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"openShifts", (o,n) => { (o as Schedule).OpenShifts = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OpenShift>(ApiSdk.Models.Microsoft.Graph.OpenShift.CreateFromDiscriminatorValue).ToList(); } },
                {"openShiftsEnabled", (o,n) => { (o as Schedule).OpenShiftsEnabled = n.GetBoolValue(); } },
                {"provisionStatus", (o,n) => { (o as Schedule).ProvisionStatus = n.GetEnumValue<OperationStatus>(); } },
                {"provisionStatusCode", (o,n) => { (o as Schedule).ProvisionStatusCode = n.GetStringValue(); } },
                {"schedulingGroups", (o,n) => { (o as Schedule).SchedulingGroups = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SchedulingGroup>(ApiSdk.Models.Microsoft.Graph.SchedulingGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"shifts", (o,n) => { (o as Schedule).Shifts = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Shift>(ApiSdk.Models.Microsoft.Graph.Shift.CreateFromDiscriminatorValue).ToList(); } },
                {"swapShiftsChangeRequests", (o,n) => { (o as Schedule).SwapShiftsChangeRequests = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SwapShiftsChangeRequest>(ApiSdk.Models.Microsoft.Graph.SwapShiftsChangeRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"swapShiftsRequestsEnabled", (o,n) => { (o as Schedule).SwapShiftsRequestsEnabled = n.GetBoolValue(); } },
                {"timeClockEnabled", (o,n) => { (o as Schedule).TimeClockEnabled = n.GetBoolValue(); } },
                {"timeOffReasons", (o,n) => { (o as Schedule).TimeOffReasons = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TimeOffReason>(ApiSdk.Models.Microsoft.Graph.TimeOffReason.CreateFromDiscriminatorValue).ToList(); } },
                {"timeOffRequests", (o,n) => { (o as Schedule).TimeOffRequests = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TimeOffRequest>(ApiSdk.Models.Microsoft.Graph.TimeOffRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"timeOffRequestsEnabled", (o,n) => { (o as Schedule).TimeOffRequestsEnabled = n.GetBoolValue(); } },
                {"timesOff", (o,n) => { (o as Schedule).TimesOff = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TimeOff>(ApiSdk.Models.Microsoft.Graph.TimeOff.CreateFromDiscriminatorValue).ToList(); } },
                {"timeZone", (o,n) => { (o as Schedule).TimeZone = n.GetStringValue(); } },
                {"workforceIntegrationIds", (o,n) => { (o as Schedule).WorkforceIntegrationIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OfferShiftRequest>("offerShiftRequests", OfferShiftRequests);
            writer.WriteBoolValue("offerShiftRequestsEnabled", OfferShiftRequestsEnabled);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OpenShiftChangeRequest>("openShiftChangeRequests", OpenShiftChangeRequests);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OpenShift>("openShifts", OpenShifts);
            writer.WriteBoolValue("openShiftsEnabled", OpenShiftsEnabled);
            writer.WriteEnumValue<OperationStatus>("provisionStatus", ProvisionStatus);
            writer.WriteStringValue("provisionStatusCode", ProvisionStatusCode);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SchedulingGroup>("schedulingGroups", SchedulingGroups);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Shift>("shifts", Shifts);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SwapShiftsChangeRequest>("swapShiftsChangeRequests", SwapShiftsChangeRequests);
            writer.WriteBoolValue("swapShiftsRequestsEnabled", SwapShiftsRequestsEnabled);
            writer.WriteBoolValue("timeClockEnabled", TimeClockEnabled);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TimeOffReason>("timeOffReasons", TimeOffReasons);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TimeOffRequest>("timeOffRequests", TimeOffRequests);
            writer.WriteBoolValue("timeOffRequestsEnabled", TimeOffRequestsEnabled);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TimeOff>("timesOff", TimesOff);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteCollectionOfPrimitiveValues<string>("workforceIntegrationIds", WorkforceIntegrationIds);
        }
    }
}
