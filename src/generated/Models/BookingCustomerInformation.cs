using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class BookingCustomerInformation : BookingCustomerInformationBase, IParsable {
        /// <summary>The ID of the bookingCustomer for this appointment. If no ID is specified when an appointment is created, then a new bookingCustomer object is created. Once set, you should consider the customerId immutable.</summary>
        public string CustomerId { get; set; }
        /// <summary>It consists of the list of custom questions and answers given by the customer as part of the appointment</summary>
        public List<BookingQuestionAnswer> CustomQuestionAnswers { get; set; }
        /// <summary>The SMTP address of the bookingCustomer who is booking the appointment</summary>
        public string EmailAddress { get; set; }
        /// <summary>Represents location information for the bookingCustomer who is booking the appointment.</summary>
        public ApiSdk.Models.Location Location { get; set; }
        /// <summary>The customer&apos;s name.</summary>
        public string Name { get; set; }
        /// <summary>Notes from the customer associated with this appointment. You can get the value only when reading this bookingAppointment by its ID. You can set this property only when initially creating an appointment with a new customer. After that point, the value is computed from the customer represented by the customerId.</summary>
        public string Notes { get; set; }
        /// <summary>The customer&apos;s phone number.</summary>
        public string Phone { get; set; }
        /// <summary>The time zone of the customer. For a list of possible values, see dateTimeTimeZone.</summary>
        public string TimeZone { get; set; }
        /// <summary>
        /// Instantiates a new BookingCustomerInformation and sets the default values.
        /// </summary>
        public BookingCustomerInformation() : base() {
            OdataType = "#microsoft.graph.bookingCustomerInformation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new BookingCustomerInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingCustomerInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"customerId", n => { CustomerId = n.GetStringValue(); } },
                {"customQuestionAnswers", n => { CustomQuestionAnswers = n.GetCollectionOfObjectValues<BookingQuestionAnswer>(BookingQuestionAnswer.CreateFromDiscriminatorValue).ToList(); } },
                {"emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                {"location", n => { Location = n.GetObjectValue<ApiSdk.Models.Location>(ApiSdk.Models.Location.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"phone", n => { Phone = n.GetStringValue(); } },
                {"timeZone", n => { TimeZone = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("customerId", CustomerId);
            writer.WriteCollectionOfObjectValues<BookingQuestionAnswer>("customQuestionAnswers", CustomQuestionAnswers);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteObjectValue<ApiSdk.Models.Location>("location", Location);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("notes", Notes);
            writer.WriteStringValue("phone", Phone);
            writer.WriteStringValue("timeZone", TimeZone);
        }
    }
}
