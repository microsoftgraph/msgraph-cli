using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class BookingBusiness : Entity, IParsable {
        /// <summary>The street address of the business. The address property, together with phone and webSiteUrl, appear in the footer of a business scheduling page. The attribute type of physicalAddress is not supported in v1.0. Internally we map the addresses to the type others.</summary>
        public ApiSdk.Models.Microsoft.Graph.PhysicalAddress Address { get; set; }
        /// <summary>All the appointments of this business. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.BookingAppointment> Appointments { get; set; }
        /// <summary>The hours of operation for the business.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.BookingWorkHours> BusinessHours { get; set; }
        /// <summary>The type of business.</summary>
        public string BusinessType { get; set; }
        /// <summary>The set of appointments of this business in a specified date range. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.BookingAppointment> CalendarView { get; set; }
        /// <summary>All the customers of this business. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.BookingCustomerBase> Customers { get; set; }
        /// <summary>All the custom questions of this business. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.BookingCustomQuestion> CustomQuestions { get; set; }
        /// <summary>The code for the currency that the business operates in on Microsoft Bookings.</summary>
        public string DefaultCurrencyIso { get; set; }
        /// <summary>The name of the business, which interfaces with customers. This name appears at the top of the business scheduling page.</summary>
        public string DisplayName { get; set; }
        /// <summary>The email address for the business.</summary>
        public string Email { get; set; }
        /// <summary>The scheduling page has been made available to external customers. Use the publish and unpublish actions to set this property. Read-only.</summary>
        public bool? IsPublished { get; set; }
        /// <summary>The telephone number for the business. The phone property, together with address and webSiteUrl, appear in the footer of a business scheduling page.</summary>
        public string Phone { get; set; }
        /// <summary>The URL for the scheduling page, which is set after you publish or unpublish the page. Read-only.</summary>
        public string PublicUrl { get; set; }
        /// <summary>Specifies how bookings can be created for this business.</summary>
        public ApiSdk.Models.Microsoft.Graph.BookingSchedulingPolicy SchedulingPolicy { get; set; }
        /// <summary>All the services offered by this business. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.BookingService> Services { get; set; }
        /// <summary>All the staff members that provide services in this business. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.BookingStaffMemberBase> StaffMembers { get; set; }
        /// <summary>The URL of the business web site. The webSiteUrl property, together with address, phone, appear in the footer of a business scheduling page.</summary>
        public string WebSiteUrl { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.BookingBusiness CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingBusiness();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"address", (o,n) => { (o as BookingBusiness).Address = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PhysicalAddress>(ApiSdk.Models.Microsoft.Graph.PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"appointments", (o,n) => { (o as BookingBusiness).Appointments = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.BookingAppointment>(ApiSdk.Models.Microsoft.Graph.BookingAppointment.CreateFromDiscriminatorValue).ToList(); } },
                {"businessHours", (o,n) => { (o as BookingBusiness).BusinessHours = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.BookingWorkHours>(ApiSdk.Models.Microsoft.Graph.BookingWorkHours.CreateFromDiscriminatorValue).ToList(); } },
                {"businessType", (o,n) => { (o as BookingBusiness).BusinessType = n.GetStringValue(); } },
                {"calendarView", (o,n) => { (o as BookingBusiness).CalendarView = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.BookingAppointment>(ApiSdk.Models.Microsoft.Graph.BookingAppointment.CreateFromDiscriminatorValue).ToList(); } },
                {"customers", (o,n) => { (o as BookingBusiness).Customers = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.BookingCustomerBase>(ApiSdk.Models.Microsoft.Graph.BookingCustomerBase.CreateFromDiscriminatorValue).ToList(); } },
                {"customQuestions", (o,n) => { (o as BookingBusiness).CustomQuestions = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.BookingCustomQuestion>(ApiSdk.Models.Microsoft.Graph.BookingCustomQuestion.CreateFromDiscriminatorValue).ToList(); } },
                {"defaultCurrencyIso", (o,n) => { (o as BookingBusiness).DefaultCurrencyIso = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as BookingBusiness).DisplayName = n.GetStringValue(); } },
                {"email", (o,n) => { (o as BookingBusiness).Email = n.GetStringValue(); } },
                {"isPublished", (o,n) => { (o as BookingBusiness).IsPublished = n.GetBoolValue(); } },
                {"phone", (o,n) => { (o as BookingBusiness).Phone = n.GetStringValue(); } },
                {"publicUrl", (o,n) => { (o as BookingBusiness).PublicUrl = n.GetStringValue(); } },
                {"schedulingPolicy", (o,n) => { (o as BookingBusiness).SchedulingPolicy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.BookingSchedulingPolicy>(ApiSdk.Models.Microsoft.Graph.BookingSchedulingPolicy.CreateFromDiscriminatorValue); } },
                {"services", (o,n) => { (o as BookingBusiness).Services = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.BookingService>(ApiSdk.Models.Microsoft.Graph.BookingService.CreateFromDiscriminatorValue).ToList(); } },
                {"staffMembers", (o,n) => { (o as BookingBusiness).StaffMembers = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.BookingStaffMemberBase>(ApiSdk.Models.Microsoft.Graph.BookingStaffMemberBase.CreateFromDiscriminatorValue).ToList(); } },
                {"webSiteUrl", (o,n) => { (o as BookingBusiness).WebSiteUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PhysicalAddress>("address", Address);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.BookingAppointment>("appointments", Appointments);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.BookingWorkHours>("businessHours", BusinessHours);
            writer.WriteStringValue("businessType", BusinessType);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.BookingAppointment>("calendarView", CalendarView);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.BookingCustomerBase>("customers", Customers);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.BookingCustomQuestion>("customQuestions", CustomQuestions);
            writer.WriteStringValue("defaultCurrencyIso", DefaultCurrencyIso);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteBoolValue("isPublished", IsPublished);
            writer.WriteStringValue("phone", Phone);
            writer.WriteStringValue("publicUrl", PublicUrl);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.BookingSchedulingPolicy>("schedulingPolicy", SchedulingPolicy);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.BookingService>("services", Services);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.BookingStaffMemberBase>("staffMembers", StaffMembers);
            writer.WriteStringValue("webSiteUrl", WebSiteUrl);
        }
    }
}
