using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Organization : DirectoryObject, IParsable {
        /// <summary>The collection of service plans associated with the tenant. Not nullable.</summary>
        public List<AssignedPlan> AssignedPlans { get; set; }
        /// <summary>Branding for the organization. Nullable.</summary>
        public OrganizationalBranding Branding { get; set; }
        /// <summary>Telephone number for the organization. Although this is a string collection, only one number can be set for this property.</summary>
        public List<string> BusinessPhones { get; set; }
        /// <summary>Navigation property to manage certificate-based authentication configuration. Only a single instance of certificateBasedAuthConfiguration can be created in the collection.</summary>
        public List<ApiSdk.Models.CertificateBasedAuthConfiguration> CertificateBasedAuthConfiguration { get; set; }
        /// <summary>City name of the address for the organization.</summary>
        public string City { get; set; }
        /// <summary>Country/region name of the address for the organization.</summary>
        public string Country { get; set; }
        /// <summary>Country or region abbreviation for the organization in ISO 3166-2 format.</summary>
        public string CountryLetterCode { get; set; }
        /// <summary>Timestamp of when the organization was created. The value cannot be modified and is automatically populated when the organization is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The display name for the tenant.</summary>
        public string DisplayName { get; set; }
        /// <summary>The collection of open extensions defined for the organization. Read-only. Nullable.</summary>
        public List<Extension> Extensions { get; set; }
        /// <summary>Not nullable.</summary>
        public List<string> MarketingNotificationEmails { get; set; }
        /// <summary>Mobile device management authority.</summary>
        public MdmAuthority? MobileDeviceManagementAuthority { get; set; }
        /// <summary>The time and date at which the tenant was last synced with the on-premises directory. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
        /// <summary>true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced. Nullable. null if this object has never been synced from an on-premises directory (default).</summary>
        public bool? OnPremisesSyncEnabled { get; set; }
        /// <summary>Postal code of the address for the organization.</summary>
        public string PostalCode { get; set; }
        /// <summary>The preferred language for the organization. Should follow ISO 639-1 Code; for example, en.</summary>
        public string PreferredLanguage { get; set; }
        /// <summary>The privacy profile of an organization.</summary>
        public ApiSdk.Models.PrivacyProfile PrivacyProfile { get; set; }
        /// <summary>Not nullable.</summary>
        public List<ProvisionedPlan> ProvisionedPlans { get; set; }
        /// <summary>The securityComplianceNotificationMails property</summary>
        public List<string> SecurityComplianceNotificationMails { get; set; }
        /// <summary>The securityComplianceNotificationPhones property</summary>
        public List<string> SecurityComplianceNotificationPhones { get; set; }
        /// <summary>State name of the address for the organization.</summary>
        public string State { get; set; }
        /// <summary>Street name of the address for organization.</summary>
        public string Street { get; set; }
        /// <summary>Not nullable.</summary>
        public List<string> TechnicalNotificationMails { get; set; }
        /// <summary>The tenantType property</summary>
        public string TenantType { get; set; }
        /// <summary>The collection of domains associated with this tenant. Not nullable.</summary>
        public List<VerifiedDomain> VerifiedDomains { get; set; }
        /// <summary>
        /// Instantiates a new Organization and sets the default values.
        /// </summary>
        public Organization() : base() {
            OdataType = "#microsoft.graph.organization";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Organization CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Organization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignedPlans", n => { AssignedPlans = n.GetCollectionOfObjectValues<AssignedPlan>(AssignedPlan.CreateFromDiscriminatorValue)?.ToList(); } },
                {"branding", n => { Branding = n.GetObjectValue<OrganizationalBranding>(OrganizationalBranding.CreateFromDiscriminatorValue); } },
                {"businessPhones", n => { BusinessPhones = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"certificateBasedAuthConfiguration", n => { CertificateBasedAuthConfiguration = n.GetCollectionOfObjectValues<ApiSdk.Models.CertificateBasedAuthConfiguration>(ApiSdk.Models.CertificateBasedAuthConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"city", n => { City = n.GetStringValue(); } },
                {"country", n => { Country = n.GetStringValue(); } },
                {"countryLetterCode", n => { CountryLetterCode = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"marketingNotificationEmails", n => { MarketingNotificationEmails = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"mobileDeviceManagementAuthority", n => { MobileDeviceManagementAuthority = n.GetEnumValue<MdmAuthority>(); } },
                {"onPremisesLastSyncDateTime", n => { OnPremisesLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"onPremisesSyncEnabled", n => { OnPremisesSyncEnabled = n.GetBoolValue(); } },
                {"postalCode", n => { PostalCode = n.GetStringValue(); } },
                {"preferredLanguage", n => { PreferredLanguage = n.GetStringValue(); } },
                {"privacyProfile", n => { PrivacyProfile = n.GetObjectValue<ApiSdk.Models.PrivacyProfile>(ApiSdk.Models.PrivacyProfile.CreateFromDiscriminatorValue); } },
                {"provisionedPlans", n => { ProvisionedPlans = n.GetCollectionOfObjectValues<ProvisionedPlan>(ProvisionedPlan.CreateFromDiscriminatorValue)?.ToList(); } },
                {"securityComplianceNotificationMails", n => { SecurityComplianceNotificationMails = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"securityComplianceNotificationPhones", n => { SecurityComplianceNotificationPhones = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"state", n => { State = n.GetStringValue(); } },
                {"street", n => { Street = n.GetStringValue(); } },
                {"technicalNotificationMails", n => { TechnicalNotificationMails = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"tenantType", n => { TenantType = n.GetStringValue(); } },
                {"verifiedDomains", n => { VerifiedDomains = n.GetCollectionOfObjectValues<VerifiedDomain>(VerifiedDomain.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AssignedPlan>("assignedPlans", AssignedPlans);
            writer.WriteObjectValue<OrganizationalBranding>("branding", Branding);
            writer.WriteCollectionOfPrimitiveValues<string>("businessPhones", BusinessPhones);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.CertificateBasedAuthConfiguration>("certificateBasedAuthConfiguration", CertificateBasedAuthConfiguration);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("country", Country);
            writer.WriteStringValue("countryLetterCode", CountryLetterCode);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteCollectionOfPrimitiveValues<string>("marketingNotificationEmails", MarketingNotificationEmails);
            writer.WriteEnumValue<MdmAuthority>("mobileDeviceManagementAuthority", MobileDeviceManagementAuthority);
            writer.WriteDateTimeOffsetValue("onPremisesLastSyncDateTime", OnPremisesLastSyncDateTime);
            writer.WriteBoolValue("onPremisesSyncEnabled", OnPremisesSyncEnabled);
            writer.WriteStringValue("postalCode", PostalCode);
            writer.WriteStringValue("preferredLanguage", PreferredLanguage);
            writer.WriteObjectValue<ApiSdk.Models.PrivacyProfile>("privacyProfile", PrivacyProfile);
            writer.WriteCollectionOfObjectValues<ProvisionedPlan>("provisionedPlans", ProvisionedPlans);
            writer.WriteCollectionOfPrimitiveValues<string>("securityComplianceNotificationMails", SecurityComplianceNotificationMails);
            writer.WriteCollectionOfPrimitiveValues<string>("securityComplianceNotificationPhones", SecurityComplianceNotificationPhones);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("street", Street);
            writer.WriteCollectionOfPrimitiveValues<string>("technicalNotificationMails", TechnicalNotificationMails);
            writer.WriteStringValue("tenantType", TenantType);
            writer.WriteCollectionOfObjectValues<VerifiedDomain>("verifiedDomains", VerifiedDomains);
        }
    }
}
