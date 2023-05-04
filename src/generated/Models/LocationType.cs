using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum LocationType {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "conferenceRoom")]
        ConferenceRoom,
        [EnumMember(Value = "homeAddress")]
        HomeAddress,
        [EnumMember(Value = "businessAddress")]
        BusinessAddress,
        [EnumMember(Value = "geoCoordinates")]
        GeoCoordinates,
        [EnumMember(Value = "streetAddress")]
        StreetAddress,
        [EnumMember(Value = "hotel")]
        Hotel,
        [EnumMember(Value = "restaurant")]
        Restaurant,
        [EnumMember(Value = "localBusiness")]
        LocalBusiness,
        [EnumMember(Value = "postalAddress")]
        PostalAddress,
    }
}
