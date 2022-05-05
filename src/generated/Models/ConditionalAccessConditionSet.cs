using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ConditionalAccessConditionSet : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Applications and user actions included in and excluded from the policy. Required.</summary>
        public ConditionalAccessApplications Applications { get; set; }
        /// <summary>Client applications (service principals and workload identities) included in and excluded from the policy. Either users or clientApplications is required.</summary>
        public ConditionalAccessClientApplications ClientApplications { get; set; }
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
        /// <summary>Users, groups, and roles included in and excluded from the policy. Either users or clientApplications is required.</summary>
        public ConditionalAccessUsers Users { get; set; }
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
        public static ConditionalAccessConditionSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessConditionSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applications", n => { Applications = n.GetObjectValue<ConditionalAccessApplications>(ConditionalAccessApplications.CreateFromDiscriminatorValue); } },
                {"clientApplications", n => { ClientApplications = n.GetObjectValue<ConditionalAccessClientApplications>(ConditionalAccessClientApplications.CreateFromDiscriminatorValue); } },
                {"clientAppTypes", n => { ClientAppTypes = n.GetCollectionOfEnumValues<ConditionalAccessClientApp>().ToList(); } },
                {"devices", n => { Devices = n.GetObjectValue<ConditionalAccessDevices>(ConditionalAccessDevices.CreateFromDiscriminatorValue); } },
                {"locations", n => { Locations = n.GetObjectValue<ConditionalAccessLocations>(ConditionalAccessLocations.CreateFromDiscriminatorValue); } },
                {"platforms", n => { Platforms = n.GetObjectValue<ConditionalAccessPlatforms>(ConditionalAccessPlatforms.CreateFromDiscriminatorValue); } },
                {"signInRiskLevels", n => { SignInRiskLevels = n.GetCollectionOfEnumValues<RiskLevel>().ToList(); } },
                {"userRiskLevels", n => { UserRiskLevels = n.GetCollectionOfEnumValues<RiskLevel>().ToList(); } },
                {"users", n => { Users = n.GetObjectValue<ConditionalAccessUsers>(ConditionalAccessUsers.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ConditionalAccessApplications>("applications", Applications);
            writer.WriteObjectValue<ConditionalAccessClientApplications>("clientApplications", ClientApplications);
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
