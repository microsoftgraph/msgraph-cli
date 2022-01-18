using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class GeoCoordinates : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Optional. The altitude (height), in feet,  above sea level for the item. Read-only.</summary>
        public double? Altitude { get; set; }
        /// <summary>Optional. The latitude, in decimal, for the item. Writable on OneDrive Personal.</summary>
        public double? Latitude { get; set; }
        /// <summary>Optional. The longitude, in decimal, for the item. Writable on OneDrive Personal.</summary>
        public double? Longitude { get; set; }
        /// <summary>
        /// Instantiates a new geoCoordinates and sets the default values.
        /// </summary>
        public GeoCoordinates() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"altitude", (o,n) => { (o as GeoCoordinates).Altitude = n.GetDoubleValue(); } },
                {"latitude", (o,n) => { (o as GeoCoordinates).Latitude = n.GetDoubleValue(); } },
                {"longitude", (o,n) => { (o as GeoCoordinates).Longitude = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("altitude", Altitude);
            writer.WriteDoubleValue("latitude", Latitude);
            writer.WriteDoubleValue("longitude", Longitude);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
