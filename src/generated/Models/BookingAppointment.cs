using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Represents a booked appointment of a service by a customer in a business.
    /// </summary>
    public class BookingAppointment : Entity, IParsable {
        /// <summary>Additional information that is sent to the customer when an appointment is confirmed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdditionalInformation { get; set; }
#nullable restore
#else
        public string AdditionalInformation { get; set; }
#endif
        /// <summary>The URL of the meeting to join anonymously.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AnonymousJoinWebUrl { get; set; }
#nullable restore
#else
        public string AnonymousJoinWebUrl { get; set; }
#endif
        /// <summary>A collection of customer properties for an appointment. An appointment will contain a list of customer information and each unit will indicate the properties of a customer who is part of that appointment. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingCustomerInformationBase>? Customers { get; set; }
#nullable restore
#else
        public List<BookingCustomerInformationBase> Customers { get; set; }
#endif
        /// <summary>The time zone of the customer. For a list of possible values, see dateTimeTimeZone.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerTimeZone { get; set; }
#nullable restore
#else
        public string CustomerTimeZone { get; set; }
#endif
        /// <summary>The length of the appointment, denoted in ISO8601 format.</summary>
        public TimeSpan? Duration { get; private set; }
        /// <summary>The endDateTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? EndDateTime { get; set; }
#nullable restore
#else
        public DateTimeTimeZone EndDateTime { get; set; }
#endif
        /// <summary>The current number of customers in the appointment</summary>
        public int? FilledAttendeesCount { get; private set; }
        /// <summary>If true, indicates that the appointment will be held online. Default value is false.</summary>
        public bool? IsLocationOnline { get; set; }
        /// <summary>The URL of the online meeting for the appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JoinWebUrl { get; set; }
#nullable restore
#else
        public string JoinWebUrl { get; set; }
#endif
        /// <summary>The maximum number of customers allowed in an appointment. If maximumAttendeesCount of the service is greater than 1, pass valid customer IDs while creating or updating an appointment. To create a customer, use the Create bookingCustomer operation.</summary>
        public int? MaximumAttendeesCount { get; set; }
        /// <summary>If true indicates that the bookingCustomer for this appointment does not wish to receive a confirmation for this appointment.</summary>
        public bool? OptOutOfCustomerEmail { get; set; }
        /// <summary>The amount of time to reserve after the appointment ends, for cleaning up, as an example. The value is expressed in ISO8601 format.</summary>
        public TimeSpan? PostBuffer { get; set; }
        /// <summary>The amount of time to reserve before the appointment begins, for preparation, as an example. The value is expressed in ISO8601 format.</summary>
        public TimeSpan? PreBuffer { get; set; }
        /// <summary>The regular price for an appointment for the specified bookingService.</summary>
        public double? Price { get; set; }
        /// <summary>Represents the type of pricing of a booking service.</summary>
        public BookingPriceType? PriceType { get; set; }
        /// <summary>The collection of customer reminders sent for this appointment. The value of this property is available only when reading this bookingAppointment by its ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingReminder>? Reminders { get; set; }
#nullable restore
#else
        public List<BookingReminder> Reminders { get; set; }
#endif
        /// <summary>An additional tracking ID for the appointment, if the appointment has been created directly by the customer on the scheduling page, as opposed to by a staff member on the behalf of the customer. Only supported for appointment if maxAttendeeCount is 1.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SelfServiceAppointmentId { get; set; }
#nullable restore
#else
        public string SelfServiceAppointmentId { get; set; }
#endif
        /// <summary>The ID of the bookingService associated with this appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceId { get; set; }
#nullable restore
#else
        public string ServiceId { get; set; }
#endif
        /// <summary>The location where the service is delivered.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Location? ServiceLocation { get; set; }
#nullable restore
#else
        public Location ServiceLocation { get; set; }
#endif
        /// <summary>The name of the bookingService associated with this appointment.This property is optional when creating a new appointment. If not specified, it is computed from the service associated with the appointment by the serviceId property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceName { get; set; }
#nullable restore
#else
        public string ServiceName { get; set; }
#endif
        /// <summary>Notes from a bookingStaffMember. The value of this property is available only when reading this bookingAppointment by its ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceNotes { get; set; }
#nullable restore
#else
        public string ServiceNotes { get; set; }
#endif
        /// <summary>If true, indicates SMS notifications will be sent to the customers for the appointment. Default value is false.</summary>
        public bool? SmsNotificationsEnabled { get; set; }
        /// <summary>The ID of each bookingStaffMember who is scheduled in this appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? StaffMemberIds { get; set; }
#nullable restore
#else
        public List<string> StaffMemberIds { get; set; }
#endif
        /// <summary>The startDateTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? StartDateTime { get; set; }
#nullable restore
#else
        public DateTimeTimeZone StartDateTime { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BookingAppointment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingAppointment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"additionalInformation", n => { AdditionalInformation = n.GetStringValue(); } },
                {"anonymousJoinWebUrl", n => { AnonymousJoinWebUrl = n.GetStringValue(); } },
                {"customers", n => { Customers = n.GetCollectionOfObjectValues<BookingCustomerInformationBase>(BookingCustomerInformationBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customerTimeZone", n => { CustomerTimeZone = n.GetStringValue(); } },
                {"duration", n => { Duration = n.GetTimeSpanValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"filledAttendeesCount", n => { FilledAttendeesCount = n.GetIntValue(); } },
                {"isLocationOnline", n => { IsLocationOnline = n.GetBoolValue(); } },
                {"joinWebUrl", n => { JoinWebUrl = n.GetStringValue(); } },
                {"maximumAttendeesCount", n => { MaximumAttendeesCount = n.GetIntValue(); } },
                {"optOutOfCustomerEmail", n => { OptOutOfCustomerEmail = n.GetBoolValue(); } },
                {"postBuffer", n => { PostBuffer = n.GetTimeSpanValue(); } },
                {"preBuffer", n => { PreBuffer = n.GetTimeSpanValue(); } },
                {"price", n => { Price = n.GetDoubleValue(); } },
                {"priceType", n => { PriceType = n.GetEnumValue<BookingPriceType>(); } },
                {"reminders", n => { Reminders = n.GetCollectionOfObjectValues<BookingReminder>(BookingReminder.CreateFromDiscriminatorValue)?.ToList(); } },
                {"selfServiceAppointmentId", n => { SelfServiceAppointmentId = n.GetStringValue(); } },
                {"serviceId", n => { ServiceId = n.GetStringValue(); } },
                {"serviceLocation", n => { ServiceLocation = n.GetObjectValue<Location>(Location.CreateFromDiscriminatorValue); } },
                {"serviceName", n => { ServiceName = n.GetStringValue(); } },
                {"serviceNotes", n => { ServiceNotes = n.GetStringValue(); } },
                {"smsNotificationsEnabled", n => { SmsNotificationsEnabled = n.GetBoolValue(); } },
                {"staffMemberIds", n => { StaffMemberIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"startDateTime", n => { StartDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("additionalInformation", AdditionalInformation);
            writer.WriteStringValue("anonymousJoinWebUrl", AnonymousJoinWebUrl);
            writer.WriteCollectionOfObjectValues<BookingCustomerInformationBase>("customers", Customers);
            writer.WriteStringValue("customerTimeZone", CustomerTimeZone);
            writer.WriteObjectValue<DateTimeTimeZone>("endDateTime", EndDateTime);
            writer.WriteBoolValue("isLocationOnline", IsLocationOnline);
            writer.WriteStringValue("joinWebUrl", JoinWebUrl);
            writer.WriteIntValue("maximumAttendeesCount", MaximumAttendeesCount);
            writer.WriteBoolValue("optOutOfCustomerEmail", OptOutOfCustomerEmail);
            writer.WriteTimeSpanValue("postBuffer", PostBuffer);
            writer.WriteTimeSpanValue("preBuffer", PreBuffer);
            writer.WriteDoubleValue("price", Price);
            writer.WriteEnumValue<BookingPriceType>("priceType", PriceType);
            writer.WriteCollectionOfObjectValues<BookingReminder>("reminders", Reminders);
            writer.WriteStringValue("selfServiceAppointmentId", SelfServiceAppointmentId);
            writer.WriteStringValue("serviceId", ServiceId);
            writer.WriteObjectValue<Location>("serviceLocation", ServiceLocation);
            writer.WriteStringValue("serviceName", ServiceName);
            writer.WriteStringValue("serviceNotes", ServiceNotes);
            writer.WriteBoolValue("smsNotificationsEnabled", SmsNotificationsEnabled);
            writer.WriteCollectionOfPrimitiveValues<string>("staffMemberIds", StaffMemberIds);
            writer.WriteObjectValue<DateTimeTimeZone>("startDateTime", StartDateTime);
        }
    }
}
