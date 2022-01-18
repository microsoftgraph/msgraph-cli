using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Person : Entity, IParsable {
        /// <summary>The person's birthday.</summary>
        public string Birthday { get; set; }
        /// <summary>The name of the person's company.</summary>
        public string CompanyName { get; set; }
        /// <summary>The person's department.</summary>
        public string Department { get; set; }
        /// <summary>The person's display name.</summary>
        public string DisplayName { get; set; }
        /// <summary>The person's given name.</summary>
        public string GivenName { get; set; }
        /// <summary>The instant message voice over IP (VOIP) session initiation protocol (SIP) address for the user. Read-only.</summary>
        public string ImAddress { get; set; }
        /// <summary>true if the user has flagged this person as a favorite.</summary>
        public bool? IsFavorite { get; set; }
        /// <summary>The person's job title.</summary>
        public string JobTitle { get; set; }
        /// <summary>The location of the person's office.</summary>
        public string OfficeLocation { get; set; }
        /// <summary>Free-form notes that the user has taken about this person.</summary>
        public string PersonNotes { get; set; }
        /// <summary>The type of person, for example distribution list.</summary>
        public PersonType PersonType { get; set; }
        /// <summary>The person's phone numbers.</summary>
        public List<Phone> Phones { get; set; }
        /// <summary>The person's addresses.</summary>
        public List<Location> PostalAddresses { get; set; }
        /// <summary>The person's profession.</summary>
        public string Profession { get; set; }
        /// <summary>The person's email addresses.</summary>
        public List<ScoredEmailAddress> ScoredEmailAddresses { get; set; }
        /// <summary>The person's surname.</summary>
        public string Surname { get; set; }
        /// <summary>The user principal name (UPN) of the person. The UPN is an Internet-style login name for the person based on the Internet standard RFC 822. By convention, this should map to the person's email name. The general format is alias@domain.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>The person's websites.</summary>
        public List<Website> Websites { get; set; }
        /// <summary>The phonetic Japanese name of the person's company.</summary>
        public string YomiCompany { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"birthday", (o,n) => { (o as Person).Birthday = n.GetStringValue(); } },
                {"companyName", (o,n) => { (o as Person).CompanyName = n.GetStringValue(); } },
                {"department", (o,n) => { (o as Person).Department = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Person).DisplayName = n.GetStringValue(); } },
                {"givenName", (o,n) => { (o as Person).GivenName = n.GetStringValue(); } },
                {"imAddress", (o,n) => { (o as Person).ImAddress = n.GetStringValue(); } },
                {"isFavorite", (o,n) => { (o as Person).IsFavorite = n.GetBoolValue(); } },
                {"jobTitle", (o,n) => { (o as Person).JobTitle = n.GetStringValue(); } },
                {"officeLocation", (o,n) => { (o as Person).OfficeLocation = n.GetStringValue(); } },
                {"personNotes", (o,n) => { (o as Person).PersonNotes = n.GetStringValue(); } },
                {"personType", (o,n) => { (o as Person).PersonType = n.GetObjectValue<PersonType>(); } },
                {"phones", (o,n) => { (o as Person).Phones = n.GetCollectionOfObjectValues<Phone>().ToList(); } },
                {"postalAddresses", (o,n) => { (o as Person).PostalAddresses = n.GetCollectionOfObjectValues<Location>().ToList(); } },
                {"profession", (o,n) => { (o as Person).Profession = n.GetStringValue(); } },
                {"scoredEmailAddresses", (o,n) => { (o as Person).ScoredEmailAddresses = n.GetCollectionOfObjectValues<ScoredEmailAddress>().ToList(); } },
                {"surname", (o,n) => { (o as Person).Surname = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as Person).UserPrincipalName = n.GetStringValue(); } },
                {"websites", (o,n) => { (o as Person).Websites = n.GetCollectionOfObjectValues<Website>().ToList(); } },
                {"yomiCompany", (o,n) => { (o as Person).YomiCompany = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("birthday", Birthday);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("department", Department);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteStringValue("imAddress", ImAddress);
            writer.WriteBoolValue("isFavorite", IsFavorite);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("officeLocation", OfficeLocation);
            writer.WriteStringValue("personNotes", PersonNotes);
            writer.WriteObjectValue<PersonType>("personType", PersonType);
            writer.WriteCollectionOfObjectValues<Phone>("phones", Phones);
            writer.WriteCollectionOfObjectValues<Location>("postalAddresses", PostalAddresses);
            writer.WriteStringValue("profession", Profession);
            writer.WriteCollectionOfObjectValues<ScoredEmailAddress>("scoredEmailAddresses", ScoredEmailAddresses);
            writer.WriteStringValue("surname", Surname);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteCollectionOfObjectValues<Website>("websites", Websites);
            writer.WriteStringValue("yomiCompany", YomiCompany);
        }
    }
}
