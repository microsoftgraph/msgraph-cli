using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class BookingService : Entity, IParsable {
        /// <summary>Additional information that is sent to the customer when an appointment is confirmed.</summary>
        public string AdditionalInformation { get; set; }
        /// <summary>Contains the set of custom questions associated with a particular service.</summary>
        public List<BookingQuestionAssignment> CustomQuestions { get; set; }
        /// <summary>The default length of the service, represented in numbers of days, hours, minutes, and seconds. For example, P11D23H59M59.999999999999S.</summary>
        public TimeSpan? DefaultDuration { get; set; }
        /// <summary>The default physical location for the service.</summary>
        public Location DefaultLocation { get; set; }
        /// <summary>The default monetary price for the service.</summary>
        public double? DefaultPrice { get; set; }
        /// <summary>Represents the type of pricing of a booking service.</summary>
        public BookingPriceType? DefaultPriceType { get; set; }
        /// <summary>The default set of reminders for an appointment of this service. The value of this property is available only when reading this bookingService by its ID.</summary>
        public List<BookingReminder> DefaultReminders { get; set; }
        /// <summary>A text description for the service.</summary>
        public string Description { get; set; }
        /// <summary>A service name.</summary>
        public string DisplayName { get; set; }
        /// <summary>True means this service is not available to customers for booking.</summary>
        public bool? IsHiddenFromCustomers { get; set; }
        /// <summary>True indicates that the appointments for the service will be held online. Default value is false.</summary>
        public bool? IsLocationOnline { get; set; }
        /// <summary>The maximum number of customers allowed in a service. If maximumAttendeesCount of the service is greater than 1, pass valid customer IDs while creating or updating an appointment. To create a customer, use the Create bookingCustomer operation.</summary>
        public int? MaximumAttendeesCount { get; set; }
        /// <summary>Additional information about this service.</summary>
        public string Notes { get; set; }
        /// <summary>The time to buffer after an appointment for this service ends, and before the next customer appointment can be booked.</summary>
        public TimeSpan? PostBuffer { get; set; }
        /// <summary>The time to buffer before an appointment for this service can start.</summary>
        public TimeSpan? PreBuffer { get; set; }
        /// <summary>The set of policies that determine how appointments for this type of service should be created and managed.</summary>
        public BookingSchedulingPolicy SchedulingPolicy { get; set; }
        /// <summary>True indicates SMS notifications can be sent to the customers for the appointment of the service. Default value is false.</summary>
        public bool? SmsNotificationsEnabled { get; set; }
        /// <summary>Represents those staff members who provide this service.</summary>
        public List<string> StaffMemberIds { get; set; }
        /// <summary>The URL a customer uses to access the service.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Instantiates a new BookingService and sets the default values.
        /// </summary>
        public BookingService() : base() {
            OdataType = "#microsoft.graph.bookingService";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new BookingService CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingService();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"additionalInformation", n => { AdditionalInformation = n.GetStringValue(); } },
                {"customQuestions", n => { CustomQuestions = n.GetCollectionOfObjectValues<BookingQuestionAssignment>(BookingQuestionAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"defaultDuration", n => { DefaultDuration = n.GetTimeSpanValue(); } },
                {"defaultLocation", n => { DefaultLocation = n.GetObjectValue<Location>(Location.CreateFromDiscriminatorValue); } },
                {"defaultPrice", n => { DefaultPrice = n.GetDoubleValue(); } },
                {"defaultPriceType", n => { DefaultPriceType = n.GetEnumValue<BookingPriceType>(); } },
                {"defaultReminders", n => { DefaultReminders = n.GetCollectionOfObjectValues<BookingReminder>(BookingReminder.CreateFromDiscriminatorValue).ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isHiddenFromCustomers", n => { IsHiddenFromCustomers = n.GetBoolValue(); } },
                {"isLocationOnline", n => { IsLocationOnline = n.GetBoolValue(); } },
                {"maximumAttendeesCount", n => { MaximumAttendeesCount = n.GetIntValue(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"postBuffer", n => { PostBuffer = n.GetTimeSpanValue(); } },
                {"preBuffer", n => { PreBuffer = n.GetTimeSpanValue(); } },
                {"schedulingPolicy", n => { SchedulingPolicy = n.GetObjectValue<BookingSchedulingPolicy>(BookingSchedulingPolicy.CreateFromDiscriminatorValue); } },
                {"smsNotificationsEnabled", n => { SmsNotificationsEnabled = n.GetBoolValue(); } },
                {"staffMemberIds", n => { StaffMemberIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("additionalInformation", AdditionalInformation);
            writer.WriteCollectionOfObjectValues<BookingQuestionAssignment>("customQuestions", CustomQuestions);
            writer.WriteTimeSpanValue("defaultDuration", DefaultDuration);
            writer.WriteObjectValue<Location>("defaultLocation", DefaultLocation);
            writer.WriteDoubleValue("defaultPrice", DefaultPrice);
            writer.WriteEnumValue<BookingPriceType>("defaultPriceType", DefaultPriceType);
            writer.WriteCollectionOfObjectValues<BookingReminder>("defaultReminders", DefaultReminders);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isHiddenFromCustomers", IsHiddenFromCustomers);
            writer.WriteBoolValue("isLocationOnline", IsLocationOnline);
            writer.WriteIntValue("maximumAttendeesCount", MaximumAttendeesCount);
            writer.WriteStringValue("notes", Notes);
            writer.WriteTimeSpanValue("postBuffer", PostBuffer);
            writer.WriteTimeSpanValue("preBuffer", PreBuffer);
            writer.WriteObjectValue<BookingSchedulingPolicy>("schedulingPolicy", SchedulingPolicy);
            writer.WriteBoolValue("smsNotificationsEnabled", SmsNotificationsEnabled);
            writer.WriteCollectionOfPrimitiveValues<string>("staffMemberIds", StaffMemberIds);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
