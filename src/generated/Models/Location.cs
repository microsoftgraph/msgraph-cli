using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Location : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The street address of the location.</summary>
        public PhysicalAddress Address { get; set; }
        /// <summary>The geographic coordinates and elevation of the location.</summary>
        public OutlookGeoCoordinates Coordinates { get; set; }
        /// <summary>The name associated with the location.</summary>
        public string DisplayName { get; set; }
        /// <summary>Optional email address of the location.</summary>
        public string LocationEmailAddress { get; set; }
        /// <summary>The type of location. The possible values are: default, conferenceRoom, homeAddress, businessAddress,geoCoordinates, streetAddress, hotel, restaurant, localBusiness, postalAddress. Read-only.</summary>
        public ApiSdk.Models.LocationType? LocationType { get; set; }
        /// <summary>Optional URI representing the location.</summary>
        public string LocationUri { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>For internal use only.</summary>
        public string UniqueId { get; set; }
        /// <summary>For internal use only.</summary>
        public LocationUniqueIdType? UniqueIdType { get; set; }
        /// <summary>
        /// Instantiates a new location and sets the default values.
        /// </summary>
        public Location() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.location";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Location CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.locationConstraintItem" => new LocationConstraintItem(),
                _ => new Location(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"address", n => { Address = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"coordinates", n => { Coordinates = n.GetObjectValue<OutlookGeoCoordinates>(OutlookGeoCoordinates.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"locationEmailAddress", n => { LocationEmailAddress = n.GetStringValue(); } },
                {"locationType", n => { LocationType = n.GetEnumValue<LocationType>(); } },
                {"locationUri", n => { LocationUri = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"uniqueId", n => { UniqueId = n.GetStringValue(); } },
                {"uniqueIdType", n => { UniqueIdType = n.GetEnumValue<LocationUniqueIdType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PhysicalAddress>("address", Address);
            writer.WriteObjectValue<OutlookGeoCoordinates>("coordinates", Coordinates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("locationEmailAddress", LocationEmailAddress);
            writer.WriteEnumValue<LocationType>("locationType", LocationType);
            writer.WriteStringValue("locationUri", LocationUri);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("uniqueId", UniqueId);
            writer.WriteEnumValue<LocationUniqueIdType>("uniqueIdType", UniqueIdType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
