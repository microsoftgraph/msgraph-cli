using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class RelatedContact : IParsable {
        /// <summary>Indicates whether the user has been consented to access student data.</summary>
        public bool? AccessConsent { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the contact. Required.</summary>
        public string DisplayName { get; set; }
        /// <summary>Email address of the contact.</summary>
        public string EmailAddress { get; set; }
        /// <summary>Mobile phone number of the contact.</summary>
        public string MobilePhone { get; set; }
        /// <summary>Relationship to the user. Possible values are: parent, relative, aide, doctor, guardian, child, other, unknownFutureValue.</summary>
        public ContactRelationship? Relationship { get; set; }
        /// <summary>
        /// Instantiates a new relatedContact and sets the default values.
        /// </summary>
        public RelatedContact() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"accessConsent", (o,n) => { (o as RelatedContact).AccessConsent = n.GetBoolValue(); } },
                {"displayName", (o,n) => { (o as RelatedContact).DisplayName = n.GetStringValue(); } },
                {"emailAddress", (o,n) => { (o as RelatedContact).EmailAddress = n.GetStringValue(); } },
                {"mobilePhone", (o,n) => { (o as RelatedContact).MobilePhone = n.GetStringValue(); } },
                {"relationship", (o,n) => { (o as RelatedContact).Relationship = n.GetEnumValue<ContactRelationship>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("accessConsent", AccessConsent);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteStringValue("mobilePhone", MobilePhone);
            writer.WriteEnumValue<ContactRelationship>("relationship", Relationship);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
