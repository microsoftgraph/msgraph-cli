using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Location : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The street address of the location.</summary>
        public ApiSdk.Models.Microsoft.Graph.PhysicalAddress Address { get; set; }
        /// <summary>The geographic coordinates and elevation of the location.</summary>
        public ApiSdk.Models.Microsoft.Graph.OutlookGeoCoordinates Coordinates { get; set; }
        /// <summary>The name associated with the location.</summary>
        public string DisplayName { get; set; }
        /// <summary>Optional email address of the location.</summary>
        public string LocationEmailAddress { get; set; }
        /// <summary>The type of location. The possible values are: default, conferenceRoom, homeAddress, businessAddress,geoCoordinates, streetAddress, hotel, restaurant, localBusiness, postalAddress. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.LocationType? LocationType { get; set; }
        /// <summary>Optional URI representing the location.</summary>
        public string LocationUri { get; set; }
        /// <summary>For internal use only.</summary>
        public string UniqueId { get; set; }
        /// <summary>For internal use only.</summary>
        public LocationUniqueIdType? UniqueIdType { get; set; }
        /// <summary>
        /// Instantiates a new location and sets the default values.
        /// </summary>
        public Location() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.Location CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Location();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"address", (o,n) => { (o as Location).Address = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PhysicalAddress>(ApiSdk.Models.Microsoft.Graph.PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"coordinates", (o,n) => { (o as Location).Coordinates = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.OutlookGeoCoordinates>(ApiSdk.Models.Microsoft.Graph.OutlookGeoCoordinates.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as Location).DisplayName = n.GetStringValue(); } },
                {"locationEmailAddress", (o,n) => { (o as Location).LocationEmailAddress = n.GetStringValue(); } },
                {"locationType", (o,n) => { (o as Location).LocationType = n.GetEnumValue<LocationType>(); } },
                {"locationUri", (o,n) => { (o as Location).LocationUri = n.GetStringValue(); } },
                {"uniqueId", (o,n) => { (o as Location).UniqueId = n.GetStringValue(); } },
                {"uniqueIdType", (o,n) => { (o as Location).UniqueIdType = n.GetEnumValue<LocationUniqueIdType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PhysicalAddress>("address", Address);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.OutlookGeoCoordinates>("coordinates", Coordinates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("locationEmailAddress", LocationEmailAddress);
            writer.WriteEnumValue<LocationType>("locationType", LocationType);
            writer.WriteStringValue("locationUri", LocationUri);
            writer.WriteStringValue("uniqueId", UniqueId);
            writer.WriteEnumValue<LocationUniqueIdType>("uniqueIdType", UniqueIdType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
