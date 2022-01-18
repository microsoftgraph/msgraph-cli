using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class VppToken : Entity, IParsable {
        /// <summary>The apple Id associated with the given Apple Volume Purchase Program Token.</summary>
        public string AppleId { get; set; }
        /// <summary>Whether or not apps for the VPP token will be automatically updated.</summary>
        public bool? AutomaticallyUpdateApps { get; set; }
        /// <summary>Whether or not apps for the VPP token will be automatically updated.</summary>
        public string CountryOrRegion { get; set; }
        /// <summary>The expiration date time of the Apple Volume Purchase Program Token.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>Last modification date time associated with the Apple Volume Purchase Program Token.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The last time when an application sync was done with the Apple volume purchase program service using the the Apple Volume Purchase Program Token.</summary>
        public DateTimeOffset? LastSyncDateTime { get; set; }
        /// <summary>Current sync status of the last application sync which was triggered using the Apple Volume Purchase Program Token. Possible values are: none, inProgress, completed, failed. Possible values are: none, inProgress, completed, failed.</summary>
        public VppTokenSyncStatus? LastSyncStatus { get; set; }
        /// <summary>The organization associated with the Apple Volume Purchase Program Token</summary>
        public string OrganizationName { get; set; }
        /// <summary>Current state of the Apple Volume Purchase Program Token. Possible values are: unknown, valid, expired, invalid, assignedToExternalMDM. Possible values are: unknown, valid, expired, invalid, assignedToExternalMDM, duplicateLocationId.</summary>
        public VppTokenState? State { get; set; }
        /// <summary>The Apple Volume Purchase Program Token string downloaded from the Apple Volume Purchase Program.</summary>
        public string Token { get; set; }
        /// <summary>The type of volume purchase program which the given Apple Volume Purchase Program Token is associated with. Possible values are: business, education. Possible values are: business, education.</summary>
        public VppTokenAccountType? VppTokenAccountType { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appleId", (o,n) => { (o as VppToken).AppleId = n.GetStringValue(); } },
                {"automaticallyUpdateApps", (o,n) => { (o as VppToken).AutomaticallyUpdateApps = n.GetBoolValue(); } },
                {"countryOrRegion", (o,n) => { (o as VppToken).CountryOrRegion = n.GetStringValue(); } },
                {"expirationDateTime", (o,n) => { (o as VppToken).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as VppToken).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncDateTime", (o,n) => { (o as VppToken).LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncStatus", (o,n) => { (o as VppToken).LastSyncStatus = n.GetEnumValue<VppTokenSyncStatus>(); } },
                {"organizationName", (o,n) => { (o as VppToken).OrganizationName = n.GetStringValue(); } },
                {"state", (o,n) => { (o as VppToken).State = n.GetEnumValue<VppTokenState>(); } },
                {"token", (o,n) => { (o as VppToken).Token = n.GetStringValue(); } },
                {"vppTokenAccountType", (o,n) => { (o as VppToken).VppTokenAccountType = n.GetEnumValue<VppTokenAccountType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appleId", AppleId);
            writer.WriteBoolValue("automaticallyUpdateApps", AutomaticallyUpdateApps);
            writer.WriteStringValue("countryOrRegion", CountryOrRegion);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteEnumValue<VppTokenSyncStatus>("lastSyncStatus", LastSyncStatus);
            writer.WriteStringValue("organizationName", OrganizationName);
            writer.WriteEnumValue<VppTokenState>("state", State);
            writer.WriteStringValue("token", Token);
            writer.WriteEnumValue<VppTokenAccountType>("vppTokenAccountType", VppTokenAccountType);
        }
    }
}
