using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SolutionsRoot : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.BookingBusiness> BookingBusinesses { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.BookingCurrency> BookingCurrencies { get; set; }
        /// <summary>
        /// Instantiates a new SolutionsRoot and sets the default values.
        /// </summary>
        public SolutionsRoot() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.SolutionsRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SolutionsRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"bookingBusinesses", (o,n) => { (o as SolutionsRoot).BookingBusinesses = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.BookingBusiness>(ApiSdk.Models.Microsoft.Graph.BookingBusiness.CreateFromDiscriminatorValue).ToList(); } },
                {"bookingCurrencies", (o,n) => { (o as SolutionsRoot).BookingCurrencies = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.BookingCurrency>(ApiSdk.Models.Microsoft.Graph.BookingCurrency.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.BookingBusiness>("bookingBusinesses", BookingBusinesses);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.BookingCurrency>("bookingCurrencies", BookingCurrencies);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
