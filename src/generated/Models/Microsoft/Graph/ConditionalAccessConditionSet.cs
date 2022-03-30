using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ConditionalAccessConditionSet : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Applications and user actions included in and excluded from the policy. Required.</summary>
        public ApiSdk.Models.Microsoft.Graph.ConditionalAccessApplications Applications { get; set; }
        /// <summary>Client applications (service principals and workload identities) included in and excluded from the policy. Either users or clientApplications is required.</summary>
        public ApiSdk.Models.Microsoft.Graph.ConditionalAccessClientApplications ClientApplications { get; set; }
        /// <summary>Client application types included in the policy. Possible values are: all, browser, mobileAppsAndDesktopClients, exchangeActiveSync, easSupported, other. Required.</summary>
        public List<ConditionalAccessClientApp?> ClientAppTypes { get; set; }
        /// <summary>Devices in the policy.</summary>
        public ApiSdk.Models.Microsoft.Graph.ConditionalAccessDevices Devices { get; set; }
        /// <summary>Locations included in and excluded from the policy.</summary>
        public ApiSdk.Models.Microsoft.Graph.ConditionalAccessLocations Locations { get; set; }
        /// <summary>Platforms included in and excluded from the policy.</summary>
        public ApiSdk.Models.Microsoft.Graph.ConditionalAccessPlatforms Platforms { get; set; }
        /// <summary>Sign-in risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue. Required.</summary>
        public List<RiskLevel?> SignInRiskLevels { get; set; }
        /// <summary>User risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue. Required.</summary>
        public List<RiskLevel?> UserRiskLevels { get; set; }
        /// <summary>Users, groups, and roles included in and excluded from the policy. Required.</summary>
        public ApiSdk.Models.Microsoft.Graph.ConditionalAccessUsers Users { get; set; }
        /// <summary>
        /// Instantiates a new conditionalAccessConditionSet and sets the default values.
        /// </summary>
        public ConditionalAccessConditionSet() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.ConditionalAccessConditionSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessConditionSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"applications", (o,n) => { (o as ConditionalAccessConditionSet).Applications = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ConditionalAccessApplications>(ApiSdk.Models.Microsoft.Graph.ConditionalAccessApplications.CreateFromDiscriminatorValue); } },
                {"clientApplications", (o,n) => { (o as ConditionalAccessConditionSet).ClientApplications = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ConditionalAccessClientApplications>(ApiSdk.Models.Microsoft.Graph.ConditionalAccessClientApplications.CreateFromDiscriminatorValue); } },
                {"clientAppTypes", (o,n) => { (o as ConditionalAccessConditionSet).ClientAppTypes = n.GetCollectionOfEnumValues<ConditionalAccessClientApp>().ToList(); } },
                {"devices", (o,n) => { (o as ConditionalAccessConditionSet).Devices = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ConditionalAccessDevices>(ApiSdk.Models.Microsoft.Graph.ConditionalAccessDevices.CreateFromDiscriminatorValue); } },
                {"locations", (o,n) => { (o as ConditionalAccessConditionSet).Locations = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ConditionalAccessLocations>(ApiSdk.Models.Microsoft.Graph.ConditionalAccessLocations.CreateFromDiscriminatorValue); } },
                {"platforms", (o,n) => { (o as ConditionalAccessConditionSet).Platforms = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ConditionalAccessPlatforms>(ApiSdk.Models.Microsoft.Graph.ConditionalAccessPlatforms.CreateFromDiscriminatorValue); } },
                {"signInRiskLevels", (o,n) => { (o as ConditionalAccessConditionSet).SignInRiskLevels = n.GetCollectionOfEnumValues<RiskLevel>().ToList(); } },
                {"userRiskLevels", (o,n) => { (o as ConditionalAccessConditionSet).UserRiskLevels = n.GetCollectionOfEnumValues<RiskLevel>().ToList(); } },
                {"users", (o,n) => { (o as ConditionalAccessConditionSet).Users = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ConditionalAccessUsers>(ApiSdk.Models.Microsoft.Graph.ConditionalAccessUsers.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ConditionalAccessApplications>("applications", Applications);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ConditionalAccessClientApplications>("clientApplications", ClientApplications);
            writer.WriteCollectionOfEnumValues<ConditionalAccessClientApp>("clientAppTypes", ClientAppTypes);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ConditionalAccessDevices>("devices", Devices);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ConditionalAccessLocations>("locations", Locations);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ConditionalAccessPlatforms>("platforms", Platforms);
            writer.WriteCollectionOfEnumValues<RiskLevel>("signInRiskLevels", SignInRiskLevels);
            writer.WriteCollectionOfEnumValues<RiskLevel>("userRiskLevels", UserRiskLevels);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ConditionalAccessUsers>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
