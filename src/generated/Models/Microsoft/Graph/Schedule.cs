using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Schedule : Entity, IParsable {
        /// <summary>Indicates whether the schedule is enabled for the team. Required.</summary>
        public bool? Enabled { get; set; }
        public List<OfferShiftRequest> OfferShiftRequests { get; set; }
        /// <summary>Indicates whether offer shift requests are enabled for the schedule.</summary>
        public bool? OfferShiftRequestsEnabled { get; set; }
        public List<OpenShiftChangeRequest> OpenShiftChangeRequests { get; set; }
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
        public List<SwapShiftsChangeRequest> SwapShiftsChangeRequests { get; set; }
        /// <summary>Indicates whether swap shifts requests are enabled for the schedule.</summary>
        public bool? SwapShiftsRequestsEnabled { get; set; }
        /// <summary>Indicates whether time clock is enabled for the schedule.</summary>
        public bool? TimeClockEnabled { get; set; }
        /// <summary>The set of reasons for a time off in the schedule.</summary>
        public List<TimeOffReason> TimeOffReasons { get; set; }
        public List<TimeOffRequest> TimeOffRequests { get; set; }
        /// <summary>Indicates whether time off requests are enabled for the schedule.</summary>
        public bool? TimeOffRequestsEnabled { get; set; }
        /// <summary>The instances of times off in the schedule.</summary>
        public List<TimeOff> TimesOff { get; set; }
        /// <summary>Indicates the time zone of the schedule team using tz database format. Required.</summary>
        public string TimeZone { get; set; }
        public List<string> WorkforceIntegrationIds { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"enabled", (o,n) => { (o as Schedule).Enabled = n.GetBoolValue(); } },
                {"offerShiftRequests", (o,n) => { (o as Schedule).OfferShiftRequests = n.GetCollectionOfObjectValues<OfferShiftRequest>().ToList(); } },
                {"offerShiftRequestsEnabled", (o,n) => { (o as Schedule).OfferShiftRequestsEnabled = n.GetBoolValue(); } },
                {"openShiftChangeRequests", (o,n) => { (o as Schedule).OpenShiftChangeRequests = n.GetCollectionOfObjectValues<OpenShiftChangeRequest>().ToList(); } },
                {"openShifts", (o,n) => { (o as Schedule).OpenShifts = n.GetCollectionOfObjectValues<OpenShift>().ToList(); } },
                {"openShiftsEnabled", (o,n) => { (o as Schedule).OpenShiftsEnabled = n.GetBoolValue(); } },
                {"provisionStatus", (o,n) => { (o as Schedule).ProvisionStatus = n.GetEnumValue<OperationStatus>(); } },
                {"provisionStatusCode", (o,n) => { (o as Schedule).ProvisionStatusCode = n.GetStringValue(); } },
                {"schedulingGroups", (o,n) => { (o as Schedule).SchedulingGroups = n.GetCollectionOfObjectValues<SchedulingGroup>().ToList(); } },
                {"shifts", (o,n) => { (o as Schedule).Shifts = n.GetCollectionOfObjectValues<Shift>().ToList(); } },
                {"swapShiftsChangeRequests", (o,n) => { (o as Schedule).SwapShiftsChangeRequests = n.GetCollectionOfObjectValues<SwapShiftsChangeRequest>().ToList(); } },
                {"swapShiftsRequestsEnabled", (o,n) => { (o as Schedule).SwapShiftsRequestsEnabled = n.GetBoolValue(); } },
                {"timeClockEnabled", (o,n) => { (o as Schedule).TimeClockEnabled = n.GetBoolValue(); } },
                {"timeOffReasons", (o,n) => { (o as Schedule).TimeOffReasons = n.GetCollectionOfObjectValues<TimeOffReason>().ToList(); } },
                {"timeOffRequests", (o,n) => { (o as Schedule).TimeOffRequests = n.GetCollectionOfObjectValues<TimeOffRequest>().ToList(); } },
                {"timeOffRequestsEnabled", (o,n) => { (o as Schedule).TimeOffRequestsEnabled = n.GetBoolValue(); } },
                {"timesOff", (o,n) => { (o as Schedule).TimesOff = n.GetCollectionOfObjectValues<TimeOff>().ToList(); } },
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
