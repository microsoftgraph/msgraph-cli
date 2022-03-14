using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Contact : OutlookItem, IParsable {
        /// <summary>The name of the contact's assistant.</summary>
        public string AssistantName { get; set; }
        /// <summary>The contact's birthday. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? Birthday { get; set; }
        /// <summary>The contact's business address.</summary>
        public PhysicalAddress BusinessAddress { get; set; }
        /// <summary>The business home page of the contact.</summary>
        public string BusinessHomePage { get; set; }
        /// <summary>The contact's business phone numbers.</summary>
        public List<string> BusinessPhones { get; set; }
        /// <summary>The names of the contact's children.</summary>
        public List<string> Children { get; set; }
        /// <summary>The name of the contact's company.</summary>
        public string CompanyName { get; set; }
        /// <summary>The contact's department.</summary>
        public string Department { get; set; }
        /// <summary>The contact's display name. You can specify the display name in a create or update operation. Note that later updates to other properties may cause an automatically generated value to overwrite the displayName value you have specified. To preserve a pre-existing value, always include it as displayName in an update operation.</summary>
        public string DisplayName { get; set; }
        /// <summary>The contact's email addresses.</summary>
        public List<EmailAddress> EmailAddresses { get; set; }
        /// <summary>The collection of open extensions defined for the contact. Nullable.</summary>
        public List<Extension> Extensions { get; set; }
        /// <summary>The name the contact is filed under.</summary>
        public string FileAs { get; set; }
        /// <summary>The contact's generation.</summary>
        public string Generation { get; set; }
        /// <summary>The contact's given name.</summary>
        public string GivenName { get; set; }
        /// <summary>The contact's home address.</summary>
        public PhysicalAddress HomeAddress { get; set; }
        /// <summary>The contact's home phone numbers.</summary>
        public List<string> HomePhones { get; set; }
        public List<string> ImAddresses { get; set; }
        public string Initials { get; set; }
        public string JobTitle { get; set; }
        public string Manager { get; set; }
        public string MiddleName { get; set; }
        public string MobilePhone { get; set; }
        /// <summary>The collection of multi-value extended properties defined for the contact. Read-only. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
        public string NickName { get; set; }
        public string OfficeLocation { get; set; }
        public PhysicalAddress OtherAddress { get; set; }
        public string ParentFolderId { get; set; }
        public string PersonalNotes { get; set; }
        /// <summary>Optional contact picture. You can get or set a photo for a contact.</summary>
        public ProfilePhoto Photo { get; set; }
        public string Profession { get; set; }
        /// <summary>The collection of single-value extended properties defined for the contact. Read-only. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
        public string SpouseName { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string YomiCompanyName { get; set; }
        public string YomiGivenName { get; set; }
        public string YomiSurname { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Contact CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Contact();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assistantName", (o,n) => { (o as Contact).AssistantName = n.GetStringValue(); } },
                {"birthday", (o,n) => { (o as Contact).Birthday = n.GetDateTimeOffsetValue(); } },
                {"businessAddress", (o,n) => { (o as Contact).BusinessAddress = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"businessHomePage", (o,n) => { (o as Contact).BusinessHomePage = n.GetStringValue(); } },
                {"businessPhones", (o,n) => { (o as Contact).BusinessPhones = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"children", (o,n) => { (o as Contact).Children = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"companyName", (o,n) => { (o as Contact).CompanyName = n.GetStringValue(); } },
                {"department", (o,n) => { (o as Contact).Department = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Contact).DisplayName = n.GetStringValue(); } },
                {"emailAddresses", (o,n) => { (o as Contact).EmailAddresses = n.GetCollectionOfObjectValues<EmailAddress>(EmailAddress.CreateFromDiscriminatorValue).ToList(); } },
                {"extensions", (o,n) => { (o as Contact).Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"fileAs", (o,n) => { (o as Contact).FileAs = n.GetStringValue(); } },
                {"generation", (o,n) => { (o as Contact).Generation = n.GetStringValue(); } },
                {"givenName", (o,n) => { (o as Contact).GivenName = n.GetStringValue(); } },
                {"homeAddress", (o,n) => { (o as Contact).HomeAddress = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"homePhones", (o,n) => { (o as Contact).HomePhones = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"imAddresses", (o,n) => { (o as Contact).ImAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"initials", (o,n) => { (o as Contact).Initials = n.GetStringValue(); } },
                {"jobTitle", (o,n) => { (o as Contact).JobTitle = n.GetStringValue(); } },
                {"manager", (o,n) => { (o as Contact).Manager = n.GetStringValue(); } },
                {"middleName", (o,n) => { (o as Contact).MiddleName = n.GetStringValue(); } },
                {"mobilePhone", (o,n) => { (o as Contact).MobilePhone = n.GetStringValue(); } },
                {"multiValueExtendedProperties", (o,n) => { (o as Contact).MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"nickName", (o,n) => { (o as Contact).NickName = n.GetStringValue(); } },
                {"officeLocation", (o,n) => { (o as Contact).OfficeLocation = n.GetStringValue(); } },
                {"otherAddress", (o,n) => { (o as Contact).OtherAddress = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"parentFolderId", (o,n) => { (o as Contact).ParentFolderId = n.GetStringValue(); } },
                {"personalNotes", (o,n) => { (o as Contact).PersonalNotes = n.GetStringValue(); } },
                {"photo", (o,n) => { (o as Contact).Photo = n.GetObjectValue<ProfilePhoto>(ProfilePhoto.CreateFromDiscriminatorValue); } },
                {"profession", (o,n) => { (o as Contact).Profession = n.GetStringValue(); } },
                {"singleValueExtendedProperties", (o,n) => { (o as Contact).SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"spouseName", (o,n) => { (o as Contact).SpouseName = n.GetStringValue(); } },
                {"surname", (o,n) => { (o as Contact).Surname = n.GetStringValue(); } },
                {"title", (o,n) => { (o as Contact).Title = n.GetStringValue(); } },
                {"yomiCompanyName", (o,n) => { (o as Contact).YomiCompanyName = n.GetStringValue(); } },
                {"yomiGivenName", (o,n) => { (o as Contact).YomiGivenName = n.GetStringValue(); } },
                {"yomiSurname", (o,n) => { (o as Contact).YomiSurname = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("assistantName", AssistantName);
            writer.WriteDateTimeOffsetValue("birthday", Birthday);
            writer.WriteObjectValue<PhysicalAddress>("businessAddress", BusinessAddress);
            writer.WriteStringValue("businessHomePage", BusinessHomePage);
            writer.WriteCollectionOfPrimitiveValues<string>("businessPhones", BusinessPhones);
            writer.WriteCollectionOfPrimitiveValues<string>("children", Children);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("department", Department);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<EmailAddress>("emailAddresses", EmailAddresses);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteStringValue("fileAs", FileAs);
            writer.WriteStringValue("generation", Generation);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteObjectValue<PhysicalAddress>("homeAddress", HomeAddress);
            writer.WriteCollectionOfPrimitiveValues<string>("homePhones", HomePhones);
            writer.WriteCollectionOfPrimitiveValues<string>("imAddresses", ImAddresses);
            writer.WriteStringValue("initials", Initials);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("manager", Manager);
            writer.WriteStringValue("middleName", MiddleName);
            writer.WriteStringValue("mobilePhone", MobilePhone);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("nickName", NickName);
            writer.WriteStringValue("officeLocation", OfficeLocation);
            writer.WriteObjectValue<PhysicalAddress>("otherAddress", OtherAddress);
            writer.WriteStringValue("parentFolderId", ParentFolderId);
            writer.WriteStringValue("personalNotes", PersonalNotes);
            writer.WriteObjectValue<ProfilePhoto>("photo", Photo);
            writer.WriteStringValue("profession", Profession);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteStringValue("spouseName", SpouseName);
            writer.WriteStringValue("surname", Surname);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("yomiCompanyName", YomiCompanyName);
            writer.WriteStringValue("yomiGivenName", YomiGivenName);
            writer.WriteStringValue("yomiSurname", YomiSurname);
        }
    }
}
