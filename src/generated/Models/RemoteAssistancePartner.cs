using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>RemoteAssistPartner resources represent the metadata and status of a given Remote Assistance partner service.</summary>
    public class RemoteAssistancePartner : Entity, IParsable {
        /// <summary>Display name of the partner.</summary>
        public string DisplayName { get; set; }
        /// <summary>Timestamp of the last request sent to Intune by the TEM partner.</summary>
        public DateTimeOffset? LastConnectionDateTime { get; set; }
        /// <summary>A friendly description of the current TeamViewer connector status. Possible values are: notOnboarded, onboarding, onboarded.</summary>
        public RemoteAssistanceOnboardingStatus? OnboardingStatus { get; set; }
        /// <summary>URL of the partner&apos;s onboarding portal, where an administrator can configure their Remote Assistance service.</summary>
        public string OnboardingUrl { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RemoteAssistancePartner CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RemoteAssistancePartner();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastConnectionDateTime", n => { LastConnectionDateTime = n.GetDateTimeOffsetValue(); } },
                {"onboardingStatus", n => { OnboardingStatus = n.GetEnumValue<RemoteAssistanceOnboardingStatus>(); } },
                {"onboardingUrl", n => { OnboardingUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastConnectionDateTime", LastConnectionDateTime);
            writer.WriteEnumValue<RemoteAssistanceOnboardingStatus>("onboardingStatus", OnboardingStatus);
            writer.WriteStringValue("onboardingUrl", OnboardingUrl);
        }
    }
}
