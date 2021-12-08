using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OrgContact : DirectoryObject, IParsable {
        /// <summary>Postal addresses for this organizational contact. For now a contact can only have one physical address.</summary>
        public List<PhysicalOfficeAddress> Addresses { get; set; }
        /// <summary>Name of the company that this organizational contact belong to. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string CompanyName { get; set; }
        /// <summary>The name for the department in which the contact works. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string Department { get; set; }
        /// <summary>The contact's direct reports. (The users and contacts that have their manager property set to this contact.) Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> DirectReports { get; set; }
        /// <summary>Display name for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.</summary>
        public string DisplayName { get; set; }
        /// <summary>First name for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string GivenName { get; set; }
        /// <summary>Job title for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string JobTitle { get; set; }
        /// <summary>The SMTP address for the contact, for example, 'jeff@contoso.onmicrosoft.com'. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string Mail { get; set; }
        /// <summary>Email alias (portion of email address pre-pending the @ symbol) for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string MailNickname { get; set; }
        /// <summary>The user or contact that is this contact's manager. Read-only. Supports $expand.</summary>
        public DirectoryObject Manager { get; set; }
        /// <summary>Groups that this contact is a member of. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> MemberOf { get; set; }
        /// <summary>Date and time when this organizational contact was last synchronized from on-premises AD. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $filter (eq, ne, not, ge, le, in).</summary>
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
        /// <summary>List of any synchronization provisioning errors for this organizational contact. Supports $filter (eq, not).</summary>
        public List<OnPremisesProvisioningError> OnPremisesProvisioningErrors { get; set; }
        /// <summary>true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced and now mastered in Exchange; null if this object has never been synced from an on-premises directory (default).  Supports $filter (eq, ne, not, in, and eq on null values).</summary>
        public bool? OnPremisesSyncEnabled { get; set; }
        /// <summary>List of phones for this organizational contact. Phone types can be mobile, business, and businessFax. Only one of each type can ever be present in the collection. Supports $filter (eq, ne, not, in).</summary>
        public List<Phone> Phones { get; set; }
        /// <summary>For example: 'SMTP: bob@contoso.com', 'smtp: bob@sales.contoso.com'. The any operator is required for filter expressions on multi-valued properties. Supports $filter (eq, not, ge, le, startsWith).</summary>
        public List<string> ProxyAddresses { get; set; }
        /// <summary>Last name for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values)</summary>
        public string Surname { get; set; }
        public List<DirectoryObject> TransitiveMemberOf { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"addresses", (o,n) => { (o as OrgContact).Addresses = n.GetCollectionOfObjectValues<PhysicalOfficeAddress>().ToList(); } },
                {"companyName", (o,n) => { (o as OrgContact).CompanyName = n.GetStringValue(); } },
                {"department", (o,n) => { (o as OrgContact).Department = n.GetStringValue(); } },
                {"directReports", (o,n) => { (o as OrgContact).DirectReports = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
                {"displayName", (o,n) => { (o as OrgContact).DisplayName = n.GetStringValue(); } },
                {"givenName", (o,n) => { (o as OrgContact).GivenName = n.GetStringValue(); } },
                {"jobTitle", (o,n) => { (o as OrgContact).JobTitle = n.GetStringValue(); } },
                {"mail", (o,n) => { (o as OrgContact).Mail = n.GetStringValue(); } },
                {"mailNickname", (o,n) => { (o as OrgContact).MailNickname = n.GetStringValue(); } },
                {"manager", (o,n) => { (o as OrgContact).Manager = n.GetObjectValue<DirectoryObject>(); } },
                {"memberOf", (o,n) => { (o as OrgContact).MemberOf = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
                {"onPremisesLastSyncDateTime", (o,n) => { (o as OrgContact).OnPremisesLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"onPremisesProvisioningErrors", (o,n) => { (o as OrgContact).OnPremisesProvisioningErrors = n.GetCollectionOfObjectValues<OnPremisesProvisioningError>().ToList(); } },
                {"onPremisesSyncEnabled", (o,n) => { (o as OrgContact).OnPremisesSyncEnabled = n.GetBoolValue(); } },
                {"phones", (o,n) => { (o as OrgContact).Phones = n.GetCollectionOfObjectValues<Phone>().ToList(); } },
                {"proxyAddresses", (o,n) => { (o as OrgContact).ProxyAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"surname", (o,n) => { (o as OrgContact).Surname = n.GetStringValue(); } },
                {"transitiveMemberOf", (o,n) => { (o as OrgContact).TransitiveMemberOf = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PhysicalOfficeAddress>("addresses", Addresses);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("department", Department);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("directReports", DirectReports);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("mail", Mail);
            writer.WriteStringValue("mailNickname", MailNickname);
            writer.WriteObjectValue<DirectoryObject>("manager", Manager);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("memberOf", MemberOf);
            writer.WriteDateTimeOffsetValue("onPremisesLastSyncDateTime", OnPremisesLastSyncDateTime);
            writer.WriteCollectionOfObjectValues<OnPremisesProvisioningError>("onPremisesProvisioningErrors", OnPremisesProvisioningErrors);
            writer.WriteBoolValue("onPremisesSyncEnabled", OnPremisesSyncEnabled);
            writer.WriteCollectionOfObjectValues<Phone>("phones", Phones);
            writer.WriteCollectionOfPrimitiveValues<string>("proxyAddresses", ProxyAddresses);
            writer.WriteStringValue("surname", Surname);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("transitiveMemberOf", TransitiveMemberOf);
        }
    }
}
