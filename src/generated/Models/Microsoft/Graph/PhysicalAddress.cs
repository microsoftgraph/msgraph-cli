using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PhysicalAddress : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The city.</summary>
        public string City { get; set; }
        /// <summary>The country or region. It's a free-format string value, for example, 'United States'.</summary>
        public string CountryOrRegion { get; set; }
        /// <summary>The postal code.</summary>
        public string PostalCode { get; set; }
        /// <summary>The state.</summary>
        public string State { get; set; }
        /// <summary>The street.</summary>
        public string Street { get; set; }
        /// <summary>
        /// Instantiates a new physicalAddress and sets the default values.
        /// </summary>
        public PhysicalAddress() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PhysicalAddress CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PhysicalAddress();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"city", (o,n) => { (o as PhysicalAddress).City = n.GetStringValue(); } },
                {"countryOrRegion", (o,n) => { (o as PhysicalAddress).CountryOrRegion = n.GetStringValue(); } },
                {"postalCode", (o,n) => { (o as PhysicalAddress).PostalCode = n.GetStringValue(); } },
                {"state", (o,n) => { (o as PhysicalAddress).State = n.GetStringValue(); } },
                {"street", (o,n) => { (o as PhysicalAddress).Street = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("countryOrRegion", CountryOrRegion);
            writer.WriteStringValue("postalCode", PostalCode);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("street", Street);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
