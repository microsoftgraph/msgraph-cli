using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OutlookGeoCoordinates : IParsable {
        /// <summary>The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.</summary>
        public double? Accuracy { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The altitude of the location.</summary>
        public double? Altitude { get; set; }
        /// <summary>The accuracy of the altitude.</summary>
        public double? AltitudeAccuracy { get; set; }
        /// <summary>The latitude of the location.</summary>
        public double? Latitude { get; set; }
        /// <summary>The longitude of the location.</summary>
        public double? Longitude { get; set; }
        /// <summary>
        /// Instantiates a new outlookGeoCoordinates and sets the default values.
        /// </summary>
        public OutlookGeoCoordinates() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"accuracy", (o,n) => { (o as OutlookGeoCoordinates).Accuracy = n.GetDoubleValue(); } },
                {"altitude", (o,n) => { (o as OutlookGeoCoordinates).Altitude = n.GetDoubleValue(); } },
                {"altitudeAccuracy", (o,n) => { (o as OutlookGeoCoordinates).AltitudeAccuracy = n.GetDoubleValue(); } },
                {"latitude", (o,n) => { (o as OutlookGeoCoordinates).Latitude = n.GetDoubleValue(); } },
                {"longitude", (o,n) => { (o as OutlookGeoCoordinates).Longitude = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("accuracy", Accuracy);
            writer.WriteDoubleValue("altitude", Altitude);
            writer.WriteDoubleValue("altitudeAccuracy", AltitudeAccuracy);
            writer.WriteDoubleValue("latitude", Latitude);
            writer.WriteDoubleValue("longitude", Longitude);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
