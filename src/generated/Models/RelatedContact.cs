using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class RelatedContact : IAdditionalDataHolder, IParsable {
        /// <summary>Indicates whether the user has been consented to access student data.</summary>
        public bool? AccessConsent { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the contact. Required.</summary>
        public string DisplayName { get; set; }
        /// <summary>Primary email address of the contact. Required.</summary>
        public string EmailAddress { get; set; }
        /// <summary>Mobile phone number of the contact.</summary>
        public string MobilePhone { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The relationship property</summary>
        public ContactRelationship? Relationship { get; set; }
        /// <summary>
        /// Instantiates a new relatedContact and sets the default values.
        /// </summary>
        public RelatedContact() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.relatedContact";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RelatedContact CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RelatedContact();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accessConsent", n => { AccessConsent = n.GetBoolValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                {"mobilePhone", n => { MobilePhone = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"relationship", n => { Relationship = n.GetEnumValue<ContactRelationship>(); } },
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
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<ContactRelationship>("relationship", Relationship);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
