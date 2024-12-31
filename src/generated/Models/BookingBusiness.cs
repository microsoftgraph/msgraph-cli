// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Represents a Microsoft Bookings Business.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class BookingBusiness : global::ApiSdk.Models.Entity, IParsable
    {
        /// <summary>The street address of the business. The address property, together with phone and webSiteUrl, appear in the footer of a business scheduling page. The attribute type of physicalAddress is not supported in v1.0. Internally we map the addresses to the type others.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PhysicalAddress? Address { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PhysicalAddress Address { get; set; }
#endif
        /// <summary>All the appointments of this business. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.BookingAppointment>? Appointments { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.BookingAppointment> Appointments { get; set; }
#endif
        /// <summary>Settings for the published booking page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.BookingPageSettings? BookingPageSettings { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.BookingPageSettings BookingPageSettings { get; set; }
#endif
        /// <summary>The hours of operation for the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.BookingWorkHours>? BusinessHours { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.BookingWorkHours> BusinessHours { get; set; }
#endif
        /// <summary>The type of business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessType { get; set; }
#nullable restore
#else
        public string BusinessType { get; set; }
#endif
        /// <summary>The set of appointments of this business in a specified date range. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.BookingAppointment>? CalendarView { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.BookingAppointment> CalendarView { get; set; }
#endif
        /// <summary>The date, time, and time zone when the booking business was created. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>All the customers of this business. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.BookingCustomerBase>? Customers { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.BookingCustomerBase> Customers { get; set; }
#endif
        /// <summary>All the custom questions of this business. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.BookingCustomQuestion>? CustomQuestions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.BookingCustomQuestion> CustomQuestions { get; set; }
#endif
        /// <summary>The code for the currency that the business operates in on Microsoft Bookings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultCurrencyIso { get; set; }
#nullable restore
#else
        public string DefaultCurrencyIso { get; set; }
#endif
        /// <summary>The name of the business, which interfaces with customers. This name appears at the top of the business scheduling page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The email address for the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The scheduling page has been made available to external customers. Use the publish and unpublish actions to set this property. Read-only.</summary>
        public bool? IsPublished { get; private set; }
        /// <summary>The language of the self-service booking page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LanguageTag { get; set; }
#nullable restore
#else
        public string LanguageTag { get; set; }
#endif
        /// <summary>The date, time, and time zone when the booking business was last updated. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>The telephone number for the business. The phone property, together with address and webSiteUrl, appear in the footer of a business scheduling page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone { get; set; }
#nullable restore
#else
        public string Phone { get; set; }
#endif
        /// <summary>The URL for the scheduling page, which is set after you publish or unpublish the page. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublicUrl { get; private set; }
#nullable restore
#else
        public string PublicUrl { get; private set; }
#endif
        /// <summary>Specifies how bookings can be created for this business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.BookingSchedulingPolicy? SchedulingPolicy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.BookingSchedulingPolicy SchedulingPolicy { get; set; }
#endif
        /// <summary>All the services offered by this business. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.BookingService>? Services { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.BookingService> Services { get; set; }
#endif
        /// <summary>All the staff members that provide services in this business. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.BookingStaffMemberBase>? StaffMembers { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.BookingStaffMemberBase> StaffMembers { get; set; }
#endif
        /// <summary>The URL of the business web site. The webSiteUrl property, together with address, phone, appear in the footer of a business scheduling page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebSiteUrl { get; set; }
#nullable restore
#else
        public string WebSiteUrl { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.BookingBusiness"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.BookingBusiness CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.BookingBusiness();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "address", n => { Address = n.GetObjectValue<global::ApiSdk.Models.PhysicalAddress>(global::ApiSdk.Models.PhysicalAddress.CreateFromDiscriminatorValue); } },
                { "appointments", n => { Appointments = n.GetCollectionOfObjectValues<global::ApiSdk.Models.BookingAppointment>(global::ApiSdk.Models.BookingAppointment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "bookingPageSettings", n => { BookingPageSettings = n.GetObjectValue<global::ApiSdk.Models.BookingPageSettings>(global::ApiSdk.Models.BookingPageSettings.CreateFromDiscriminatorValue); } },
                { "businessHours", n => { BusinessHours = n.GetCollectionOfObjectValues<global::ApiSdk.Models.BookingWorkHours>(global::ApiSdk.Models.BookingWorkHours.CreateFromDiscriminatorValue)?.AsList(); } },
                { "businessType", n => { BusinessType = n.GetStringValue(); } },
                { "calendarView", n => { CalendarView = n.GetCollectionOfObjectValues<global::ApiSdk.Models.BookingAppointment>(global::ApiSdk.Models.BookingAppointment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "customQuestions", n => { CustomQuestions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.BookingCustomQuestion>(global::ApiSdk.Models.BookingCustomQuestion.CreateFromDiscriminatorValue)?.AsList(); } },
                { "customers", n => { Customers = n.GetCollectionOfObjectValues<global::ApiSdk.Models.BookingCustomerBase>(global::ApiSdk.Models.BookingCustomerBase.CreateFromDiscriminatorValue)?.AsList(); } },
                { "defaultCurrencyIso", n => { DefaultCurrencyIso = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "isPublished", n => { IsPublished = n.GetBoolValue(); } },
                { "languageTag", n => { LanguageTag = n.GetStringValue(); } },
                { "lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "phone", n => { Phone = n.GetStringValue(); } },
                { "publicUrl", n => { PublicUrl = n.GetStringValue(); } },
                { "schedulingPolicy", n => { SchedulingPolicy = n.GetObjectValue<global::ApiSdk.Models.BookingSchedulingPolicy>(global::ApiSdk.Models.BookingSchedulingPolicy.CreateFromDiscriminatorValue); } },
                { "services", n => { Services = n.GetCollectionOfObjectValues<global::ApiSdk.Models.BookingService>(global::ApiSdk.Models.BookingService.CreateFromDiscriminatorValue)?.AsList(); } },
                { "staffMembers", n => { StaffMembers = n.GetCollectionOfObjectValues<global::ApiSdk.Models.BookingStaffMemberBase>(global::ApiSdk.Models.BookingStaffMemberBase.CreateFromDiscriminatorValue)?.AsList(); } },
                { "webSiteUrl", n => { WebSiteUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::ApiSdk.Models.PhysicalAddress>("address", Address);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.BookingAppointment>("appointments", Appointments);
            writer.WriteObjectValue<global::ApiSdk.Models.BookingPageSettings>("bookingPageSettings", BookingPageSettings);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.BookingWorkHours>("businessHours", BusinessHours);
            writer.WriteStringValue("businessType", BusinessType);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.BookingAppointment>("calendarView", CalendarView);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.BookingCustomerBase>("customers", Customers);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.BookingCustomQuestion>("customQuestions", CustomQuestions);
            writer.WriteStringValue("defaultCurrencyIso", DefaultCurrencyIso);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteStringValue("phone", Phone);
            writer.WriteObjectValue<global::ApiSdk.Models.BookingSchedulingPolicy>("schedulingPolicy", SchedulingPolicy);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.BookingService>("services", Services);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.BookingStaffMemberBase>("staffMembers", StaffMembers);
            writer.WriteStringValue("webSiteUrl", WebSiteUrl);
        }
    }
}
#pragma warning restore CS0618
