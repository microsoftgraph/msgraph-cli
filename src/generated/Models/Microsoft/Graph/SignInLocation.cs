using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SignInLocation : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Provides the city where the sign-in originated. This is calculated using latitude/longitude information from the sign-in activity.</summary>
        public string City { get; set; }
        /// <summary>Provides the country code info (2 letter code) where the sign-in originated.  This is calculated using latitude/longitude information from the sign-in activity.</summary>
        public string CountryOrRegion { get; set; }
        /// <summary>Provides the latitude, longitude and altitude where the sign-in originated.</summary>
        public GeoCoordinates GeoCoordinates { get; set; }
        /// <summary>Provides the State where the sign-in originated. This is calculated using latitude/longitude information from the sign-in activity.</summary>
        public string State { get; set; }
        /// <summary>
        /// Instantiates a new signInLocation and sets the default values.
        /// </summary>
        public SignInLocation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"city", (o,n) => { (o as SignInLocation).City = n.GetStringValue(); } },
                {"countryOrRegion", (o,n) => { (o as SignInLocation).CountryOrRegion = n.GetStringValue(); } },
                {"geoCoordinates", (o,n) => { (o as SignInLocation).GeoCoordinates = n.GetObjectValue<GeoCoordinates>(); } },
                {"state", (o,n) => { (o as SignInLocation).State = n.GetStringValue(); } },
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
            writer.WriteObjectValue<GeoCoordinates>("geoCoordinates", GeoCoordinates);
            writer.WriteStringValue("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
