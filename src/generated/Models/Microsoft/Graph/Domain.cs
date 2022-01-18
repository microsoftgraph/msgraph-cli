using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Domain : Entity, IParsable {
        /// <summary>Indicates the configured authentication type for the domain. The value is either Managed or Federated. Managed indicates a cloud managed domain where Azure AD performs user authentication. Federated indicates authentication is federated with an identity provider such as the tenant's on-premises Active Directory via Active Directory Federation Services. This property is read-only and is not nullable.</summary>
        public string AuthenticationType { get; set; }
        /// <summary>This property is always null except when the verify action is used. When the verify action is used, a domain entity is returned in the response. The availabilityStatus property of the domain entity in the response is either AvailableImmediately or EmailVerifiedDomainTakeoverScheduled.</summary>
        public string AvailabilityStatus { get; set; }
        /// <summary>Read-only, Nullable</summary>
        public List<DirectoryObject> DomainNameReferences { get; set; }
        /// <summary>The value of the property is false if the DNS record management of the domain has been delegated to Microsoft 365. Otherwise, the value is true. Not nullable</summary>
        public bool? IsAdminManaged { get; set; }
        /// <summary>true if this is the default domain that is used for user creation. There is only one default domain per company. Not nullable</summary>
        public bool? IsDefault { get; set; }
        /// <summary>true if this is the initial domain created by Microsoft Online Services (companyname.onmicrosoft.com). There is only one initial domain per company. Not nullable</summary>
        public bool? IsInitial { get; set; }
        /// <summary>true if the domain is a verified root domain. Otherwise, false if the domain is a subdomain or unverified. Not nullable</summary>
        public bool? IsRoot { get; set; }
        /// <summary>true if the domain has completed domain ownership verification. Not nullable</summary>
        public bool? IsVerified { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        /// <summary>Specifies the number of days before a user receives notification that their password will expire. If the property is not set, a default value of 14 days will be used.</summary>
        public int? PasswordNotificationWindowInDays { get; set; }
        /// <summary>Specifies the length of time that a password is valid before it must be changed. If the property is not set, a default value of 90 days will be used.</summary>
        public int? PasswordValidityPeriodInDays { get; set; }
        /// <summary>DNS records the customer adds to the DNS zone file of the domain before the domain can be used by Microsoft Online services. Read-only, Nullable</summary>
        public List<DomainDnsRecord> ServiceConfigurationRecords { get; set; }
        /// <summary>Status of asynchronous operations scheduled for the domain.</summary>
        public DomainState State { get; set; }
        /// <summary>The capabilities assigned to the domain. Can include 0, 1 or more of following values: Email, Sharepoint, EmailInternalRelayOnly, OfficeCommunicationsOnline,SharePointDefaultDomain, FullRedelegation, SharePointPublic, OrgIdAuthentication, Yammer, Intune. The values which you can add/remove using Graph API include: Email, OfficeCommunicationsOnline, Yammer. Not nullable</summary>
        public List<string> SupportedServices { get; set; }
        /// <summary>DNS records that the customer adds to the DNS zone file of the domain before the customer can complete domain ownership verification with Azure AD. Read-only, Nullable</summary>
        public List<DomainDnsRecord> VerificationDnsRecords { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"authenticationType", (o,n) => { (o as Domain).AuthenticationType = n.GetStringValue(); } },
                {"availabilityStatus", (o,n) => { (o as Domain).AvailabilityStatus = n.GetStringValue(); } },
                {"domainNameReferences", (o,n) => { (o as Domain).DomainNameReferences = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
                {"isAdminManaged", (o,n) => { (o as Domain).IsAdminManaged = n.GetBoolValue(); } },
                {"isDefault", (o,n) => { (o as Domain).IsDefault = n.GetBoolValue(); } },
                {"isInitial", (o,n) => { (o as Domain).IsInitial = n.GetBoolValue(); } },
                {"isRoot", (o,n) => { (o as Domain).IsRoot = n.GetBoolValue(); } },
                {"isVerified", (o,n) => { (o as Domain).IsVerified = n.GetBoolValue(); } },
                {"manufacturer", (o,n) => { (o as Domain).Manufacturer = n.GetStringValue(); } },
                {"model", (o,n) => { (o as Domain).Model = n.GetStringValue(); } },
                {"passwordNotificationWindowInDays", (o,n) => { (o as Domain).PasswordNotificationWindowInDays = n.GetIntValue(); } },
                {"passwordValidityPeriodInDays", (o,n) => { (o as Domain).PasswordValidityPeriodInDays = n.GetIntValue(); } },
                {"serviceConfigurationRecords", (o,n) => { (o as Domain).ServiceConfigurationRecords = n.GetCollectionOfObjectValues<DomainDnsRecord>().ToList(); } },
                {"state", (o,n) => { (o as Domain).State = n.GetObjectValue<DomainState>(); } },
                {"supportedServices", (o,n) => { (o as Domain).SupportedServices = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"verificationDnsRecords", (o,n) => { (o as Domain).VerificationDnsRecords = n.GetCollectionOfObjectValues<DomainDnsRecord>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("authenticationType", AuthenticationType);
            writer.WriteStringValue("availabilityStatus", AvailabilityStatus);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("domainNameReferences", DomainNameReferences);
            writer.WriteBoolValue("isAdminManaged", IsAdminManaged);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isInitial", IsInitial);
            writer.WriteBoolValue("isRoot", IsRoot);
            writer.WriteBoolValue("isVerified", IsVerified);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteIntValue("passwordNotificationWindowInDays", PasswordNotificationWindowInDays);
            writer.WriteIntValue("passwordValidityPeriodInDays", PasswordValidityPeriodInDays);
            writer.WriteCollectionOfObjectValues<DomainDnsRecord>("serviceConfigurationRecords", ServiceConfigurationRecords);
            writer.WriteObjectValue<DomainState>("state", State);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedServices", SupportedServices);
            writer.WriteCollectionOfObjectValues<DomainDnsRecord>("verificationDnsRecords", VerificationDnsRecords);
        }
    }
}
