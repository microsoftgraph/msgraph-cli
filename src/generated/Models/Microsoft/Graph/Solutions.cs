using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Solutions : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<BookingBusiness> BookingBusinesses { get; set; }
        public List<BookingCurrency> BookingCurrencies { get; set; }
        /// <summary>
        /// Instantiates a new solutions and sets the default values.
        /// </summary>
        public Solutions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"bookingBusinesses", (o,n) => { (o as Solutions).BookingBusinesses = n.GetCollectionOfObjectValues<BookingBusiness>().ToList(); } },
                {"bookingCurrencies", (o,n) => { (o as Solutions).BookingCurrencies = n.GetCollectionOfObjectValues<BookingCurrency>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<BookingBusiness>("bookingBusinesses", BookingBusinesses);
            writer.WriteCollectionOfObjectValues<BookingCurrency>("bookingCurrencies", BookingCurrencies);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
