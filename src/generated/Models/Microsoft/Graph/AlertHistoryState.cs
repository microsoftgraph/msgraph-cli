using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AlertHistoryState : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Application ID of the calling application that submitted an update (PATCH) to the alert. The appId should be extracted from the auth token and not entered manually by the calling application.</summary>
        public string AppId { get; set; }
        /// <summary>UPN of user the alert was assigned to (note: alert.assignedTo only stores the last value/UPN).</summary>
        public string AssignedTo { get; set; }
        /// <summary>Comment entered by signed-in user.</summary>
        public List<string> Comments { get; set; }
        /// <summary>Analyst feedback on the alert in this update. Possible values are: unknown, truePositive, falsePositive, benignPositive.</summary>
        public AlertFeedback? Feedback { get; set; }
        /// <summary>Alert status value (if updated). Possible values are: unknown, newAlert, inProgress, resolved, dismissed.</summary>
        public AlertStatus? Status { get; set; }
        /// <summary>Date and time of the alert update. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? UpdatedDateTime { get; set; }
        /// <summary>UPN of the signed-in user that updated the alert (taken from the bearer token - if in user/delegated auth mode).</summary>
        public string User { get; set; }
        /// <summary>
        /// Instantiates a new alertHistoryState and sets the default values.
        /// </summary>
        public AlertHistoryState() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"appId", (o,n) => { (o as AlertHistoryState).AppId = n.GetStringValue(); } },
                {"assignedTo", (o,n) => { (o as AlertHistoryState).AssignedTo = n.GetStringValue(); } },
                {"comments", (o,n) => { (o as AlertHistoryState).Comments = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"feedback", (o,n) => { (o as AlertHistoryState).Feedback = n.GetEnumValue<AlertFeedback>(); } },
                {"status", (o,n) => { (o as AlertHistoryState).Status = n.GetEnumValue<AlertStatus>(); } },
                {"updatedDateTime", (o,n) => { (o as AlertHistoryState).UpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"user", (o,n) => { (o as AlertHistoryState).User = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteCollectionOfPrimitiveValues<string>("comments", Comments);
            writer.WriteEnumValue<AlertFeedback>("feedback", Feedback);
            writer.WriteEnumValue<AlertStatus>("status", Status);
            writer.WriteDateTimeOffsetValue("updatedDateTime", UpdatedDateTime);
            writer.WriteStringValue("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
