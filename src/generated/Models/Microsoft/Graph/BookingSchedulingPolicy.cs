using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class BookingSchedulingPolicy : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>True if to allow customers to choose a specific person for the booking.</summary>
        public bool? AllowStaffSelection { get; set; }
        /// <summary>Maximum number of days in advance that a booking can be made. It follows the ISO 8601 format.</summary>
        public TimeSpan? MaximumAdvance { get; set; }
        /// <summary>The minimum amount of time before which bookings and cancellations must be made. It follows the ISO 8601 format.</summary>
        public TimeSpan? MinimumLeadTime { get; set; }
        /// <summary>True to notify the business via email when a booking is created or changed. Use the email address specified in the email property of the bookingBusiness entity for the business.</summary>
        public bool? SendConfirmationsToOwner { get; set; }
        /// <summary>Duration of each time slot, denoted in ISO 8601 format.</summary>
        public TimeSpan? TimeSlotInterval { get; set; }
        /// <summary>
        /// Instantiates a new bookingSchedulingPolicy and sets the default values.
        /// </summary>
        public BookingSchedulingPolicy() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowStaffSelection", (o,n) => { (o as BookingSchedulingPolicy).AllowStaffSelection = n.GetBoolValue(); } },
                {"maximumAdvance", (o,n) => { (o as BookingSchedulingPolicy).MaximumAdvance = n.GetTimeSpanValue(); } },
                {"minimumLeadTime", (o,n) => { (o as BookingSchedulingPolicy).MinimumLeadTime = n.GetTimeSpanValue(); } },
                {"sendConfirmationsToOwner", (o,n) => { (o as BookingSchedulingPolicy).SendConfirmationsToOwner = n.GetBoolValue(); } },
                {"timeSlotInterval", (o,n) => { (o as BookingSchedulingPolicy).TimeSlotInterval = n.GetTimeSpanValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowStaffSelection", AllowStaffSelection);
            writer.WriteTimeSpanValue("maximumAdvance", MaximumAdvance);
            writer.WriteTimeSpanValue("minimumLeadTime", MinimumLeadTime);
            writer.WriteBoolValue("sendConfirmationsToOwner", SendConfirmationsToOwner);
            writer.WriteTimeSpanValue("timeSlotInterval", TimeSlotInterval);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
