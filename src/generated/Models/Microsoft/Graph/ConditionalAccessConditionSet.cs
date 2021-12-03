using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ConditionalAccessConditionSet : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Applications and user actions included in and excluded from the policy. Required.</summary>
        public ConditionalAccessApplications Applications { get; set; }
        /// <summary>Client application types included in the policy. Possible values are: all, browser, mobileAppsAndDesktopClients, exchangeActiveSync, easSupported, other. Required.</summary>
        public List<ConditionalAccessClientApp?> ClientAppTypes { get; set; }
        /// <summary>Devices in the policy.</summary>
        public ConditionalAccessDevices Devices { get; set; }
        /// <summary>Locations included in and excluded from the policy.</summary>
        public ConditionalAccessLocations Locations { get; set; }
        /// <summary>Platforms included in and excluded from the policy.</summary>
        public ConditionalAccessPlatforms Platforms { get; set; }
        /// <summary>Sign-in risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue. Required.</summary>
        public List<RiskLevel?> SignInRiskLevels { get; set; }
        /// <summary>User risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue. Required.</summary>
        public List<RiskLevel?> UserRiskLevels { get; set; }
        public ConditionalAccessUsers Users { get; set; }
        /// <summary>
        /// Instantiates a new conditionalAccessConditionSet and sets the default values.
        /// </summary>
        public ConditionalAccessConditionSet() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"applications", (o,n) => { (o as ConditionalAccessConditionSet).Applications = n.GetObjectValue<ConditionalAccessApplications>(); } },
                {"clientAppTypes", (o,n) => { (o as ConditionalAccessConditionSet).ClientAppTypes = n.GetCollectionOfEnumValues<ConditionalAccessClientApp>().ToList(); } },
                {"devices", (o,n) => { (o as ConditionalAccessConditionSet).Devices = n.GetObjectValue<ConditionalAccessDevices>(); } },
                {"locations", (o,n) => { (o as ConditionalAccessConditionSet).Locations = n.GetObjectValue<ConditionalAccessLocations>(); } },
                {"platforms", (o,n) => { (o as ConditionalAccessConditionSet).Platforms = n.GetObjectValue<ConditionalAccessPlatforms>(); } },
                {"signInRiskLevels", (o,n) => { (o as ConditionalAccessConditionSet).SignInRiskLevels = n.GetCollectionOfEnumValues<RiskLevel>().ToList(); } },
                {"userRiskLevels", (o,n) => { (o as ConditionalAccessConditionSet).UserRiskLevels = n.GetCollectionOfEnumValues<RiskLevel>().ToList(); } },
                {"users", (o,n) => { (o as ConditionalAccessConditionSet).Users = n.GetObjectValue<ConditionalAccessUsers>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ConditionalAccessApplications>("applications", Applications);
            writer.WriteCollectionOfEnumValues<ConditionalAccessClientApp>("clientAppTypes", ClientAppTypes);
            writer.WriteObjectValue<ConditionalAccessDevices>("devices", Devices);
            writer.WriteObjectValue<ConditionalAccessLocations>("locations", Locations);
            writer.WriteObjectValue<ConditionalAccessPlatforms>("platforms", Platforms);
            writer.WriteCollectionOfEnumValues<RiskLevel>("signInRiskLevels", SignInRiskLevels);
            writer.WriteCollectionOfEnumValues<RiskLevel>("userRiskLevels", UserRiskLevels);
            writer.WriteObjectValue<ConditionalAccessUsers>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
