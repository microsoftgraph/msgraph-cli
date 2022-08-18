using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class BookingCustomer : BookingCustomerBase, IParsable {
        /// <summary>Addresses associated with the customer. The attribute type of physicalAddress is not supported in v1.0. Internally we map the addresses to the type others.</summary>
        public List<PhysicalAddress> Addresses { get; set; }
        /// <summary>The name of the customer.</summary>
        public string DisplayName { get; set; }
        /// <summary>The SMTP address of the customer.</summary>
        public string EmailAddress { get; set; }
        /// <summary>Phone numbers associated with the customer, including home, business and mobile numbers.</summary>
        public List<Phone> Phones { get; set; }
        /// <summary>
        /// Instantiates a new BookingCustomer and sets the default values.
        /// </summary>
        public BookingCustomer() : base() {
            OdataType = "#microsoft.graph.bookingCustomer";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new BookingCustomer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingCustomer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"addresses", n => { Addresses = n.GetCollectionOfObjectValues<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                {"phones", n => { Phones = n.GetCollectionOfObjectValues<Phone>(Phone.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PhysicalAddress>("addresses", Addresses);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteCollectionOfObjectValues<Phone>("phones", Phones);
        }
    }
}
