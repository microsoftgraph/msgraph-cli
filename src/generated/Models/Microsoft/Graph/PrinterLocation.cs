using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PrinterLocation : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The altitude, in meters, that the printer is located at.</summary>
        public int? AltitudeInMeters { get; set; }
        /// <summary>The building that the printer is located in.</summary>
        public string Building { get; set; }
        /// <summary>The city that the printer is located in.</summary>
        public string City { get; set; }
        /// <summary>The country or region that the printer is located in.</summary>
        public string CountryOrRegion { get; set; }
        /// <summary>The floor that the printer is located on. Only numerical values are supported right now.</summary>
        public string Floor { get; set; }
        /// <summary>The description of the floor that the printer is located on.</summary>
        public string FloorDescription { get; set; }
        /// <summary>The latitude that the printer is located at.</summary>
        public double? Latitude { get; set; }
        /// <summary>The longitude that the printer is located at.</summary>
        public double? Longitude { get; set; }
        /// <summary>The organizational hierarchy that the printer belongs to. The elements should be in hierarchical order.</summary>
        public List<string> Organization { get; set; }
        /// <summary>The postal code that the printer is located in.</summary>
        public string PostalCode { get; set; }
        /// <summary>The description of the room that the printer is located in.</summary>
        public string RoomDescription { get; set; }
        /// <summary>The room that the printer is located in. Only numerical values are supported right now.</summary>
        public string RoomName { get; set; }
        /// <summary>The site that the printer is located in.</summary>
        public string Site { get; set; }
        /// <summary>The state or province that the printer is located in.</summary>
        public string StateOrProvince { get; set; }
        /// <summary>The street address where the printer is located.</summary>
        public string StreetAddress { get; set; }
        /// <summary>The subdivision that the printer is located in. The elements should be in hierarchical order.</summary>
        public List<string> Subdivision { get; set; }
        public List<string> Subunit { get; set; }
        /// <summary>
        /// Instantiates a new printerLocation and sets the default values.
        /// </summary>
        public PrinterLocation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"altitudeInMeters", (o,n) => { (o as PrinterLocation).AltitudeInMeters = n.GetIntValue(); } },
                {"building", (o,n) => { (o as PrinterLocation).Building = n.GetStringValue(); } },
                {"city", (o,n) => { (o as PrinterLocation).City = n.GetStringValue(); } },
                {"countryOrRegion", (o,n) => { (o as PrinterLocation).CountryOrRegion = n.GetStringValue(); } },
                {"floor", (o,n) => { (o as PrinterLocation).Floor = n.GetStringValue(); } },
                {"floorDescription", (o,n) => { (o as PrinterLocation).FloorDescription = n.GetStringValue(); } },
                {"latitude", (o,n) => { (o as PrinterLocation).Latitude = n.GetDoubleValue(); } },
                {"longitude", (o,n) => { (o as PrinterLocation).Longitude = n.GetDoubleValue(); } },
                {"organization", (o,n) => { (o as PrinterLocation).Organization = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"postalCode", (o,n) => { (o as PrinterLocation).PostalCode = n.GetStringValue(); } },
                {"roomDescription", (o,n) => { (o as PrinterLocation).RoomDescription = n.GetStringValue(); } },
                {"roomName", (o,n) => { (o as PrinterLocation).RoomName = n.GetStringValue(); } },
                {"site", (o,n) => { (o as PrinterLocation).Site = n.GetStringValue(); } },
                {"stateOrProvince", (o,n) => { (o as PrinterLocation).StateOrProvince = n.GetStringValue(); } },
                {"streetAddress", (o,n) => { (o as PrinterLocation).StreetAddress = n.GetStringValue(); } },
                {"subdivision", (o,n) => { (o as PrinterLocation).Subdivision = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"subunit", (o,n) => { (o as PrinterLocation).Subunit = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("altitudeInMeters", AltitudeInMeters);
            writer.WriteStringValue("building", Building);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("countryOrRegion", CountryOrRegion);
            writer.WriteStringValue("floor", Floor);
            writer.WriteStringValue("floorDescription", FloorDescription);
            writer.WriteDoubleValue("latitude", Latitude);
            writer.WriteDoubleValue("longitude", Longitude);
            writer.WriteCollectionOfPrimitiveValues<string>("organization", Organization);
            writer.WriteStringValue("postalCode", PostalCode);
            writer.WriteStringValue("roomDescription", RoomDescription);
            writer.WriteStringValue("roomName", RoomName);
            writer.WriteStringValue("site", Site);
            writer.WriteStringValue("stateOrProvince", StateOrProvince);
            writer.WriteStringValue("streetAddress", StreetAddress);
            writer.WriteCollectionOfPrimitiveValues<string>("subdivision", Subdivision);
            writer.WriteCollectionOfPrimitiveValues<string>("subunit", Subunit);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
