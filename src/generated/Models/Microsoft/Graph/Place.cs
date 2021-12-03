using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Place : Entity, IParsable {
        /// <summary>The street address of the place.</summary>
        public PhysicalAddress Address { get; set; }
        /// <summary>The name associated with the place.</summary>
        public string DisplayName { get; set; }
        /// <summary>Specifies the place location in latitude, longitude and (optionally) altitude coordinates.</summary>
        public OutlookGeoCoordinates GeoCoordinates { get; set; }
        /// <summary>The phone number of the place.</summary>
        public string Phone { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"address", (o,n) => { (o as Place).Address = n.GetObjectValue<PhysicalAddress>(); } },
                {"displayName", (o,n) => { (o as Place).DisplayName = n.GetStringValue(); } },
                {"geoCoordinates", (o,n) => { (o as Place).GeoCoordinates = n.GetObjectValue<OutlookGeoCoordinates>(); } },
                {"phone", (o,n) => { (o as Place).Phone = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PhysicalAddress>("address", Address);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<OutlookGeoCoordinates>("geoCoordinates", GeoCoordinates);
            writer.WriteStringValue("phone", Phone);
        }
    }
}
