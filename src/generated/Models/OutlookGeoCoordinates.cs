using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class OutlookGeoCoordinates : IAdditionalDataHolder, IParsable {
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
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>
        /// Instantiates a new outlookGeoCoordinates and sets the default values.
        /// </summary>
        public OutlookGeoCoordinates() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.outlookGeoCoordinates";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OutlookGeoCoordinates CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OutlookGeoCoordinates();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accuracy", n => { Accuracy = n.GetDoubleValue(); } },
                {"altitude", n => { Altitude = n.GetDoubleValue(); } },
                {"altitudeAccuracy", n => { AltitudeAccuracy = n.GetDoubleValue(); } },
                {"latitude", n => { Latitude = n.GetDoubleValue(); } },
                {"longitude", n => { Longitude = n.GetDoubleValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
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
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
