using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class B2xIdentityUserFlow : IdentityUserFlow, IParsable {
        /// <summary>Configuration for enabling an API connector for use as part of the self-service sign up user flow. You can only obtain the value of this object using Get userFlowApiConnectorConfiguration.</summary>
        public UserFlowApiConnectorConfiguration ApiConnectorConfiguration { get; set; }
        /// <summary>The identity providers included in the user flow.</summary>
        public List<IdentityProvider> IdentityProviders { get; set; }
        /// <summary>The languages supported for customization within the user flow. Language customization is enabled by default in self-service sign up user flow. You cannot create custom languages in self-service sign up user flows.</summary>
        public List<UserFlowLanguageConfiguration> Languages { get; set; }
        /// <summary>The user attribute assignments included in the user flow.</summary>
        public List<IdentityUserFlowAttributeAssignment> UserAttributeAssignments { get; set; }
        public List<IdentityProviderBase> UserFlowIdentityProviders { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new B2xIdentityUserFlow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new B2xIdentityUserFlow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"apiConnectorConfiguration", (o,n) => { (o as B2xIdentityUserFlow).ApiConnectorConfiguration = n.GetObjectValue<UserFlowApiConnectorConfiguration>(UserFlowApiConnectorConfiguration.CreateFromDiscriminatorValue); } },
                {"identityProviders", (o,n) => { (o as B2xIdentityUserFlow).IdentityProviders = n.GetCollectionOfObjectValues<IdentityProvider>(IdentityProvider.CreateFromDiscriminatorValue).ToList(); } },
                {"languages", (o,n) => { (o as B2xIdentityUserFlow).Languages = n.GetCollectionOfObjectValues<UserFlowLanguageConfiguration>(UserFlowLanguageConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"userAttributeAssignments", (o,n) => { (o as B2xIdentityUserFlow).UserAttributeAssignments = n.GetCollectionOfObjectValues<IdentityUserFlowAttributeAssignment>(IdentityUserFlowAttributeAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"userFlowIdentityProviders", (o,n) => { (o as B2xIdentityUserFlow).UserFlowIdentityProviders = n.GetCollectionOfObjectValues<IdentityProviderBase>(IdentityProviderBase.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UserFlowApiConnectorConfiguration>("apiConnectorConfiguration", ApiConnectorConfiguration);
            writer.WriteCollectionOfObjectValues<IdentityProvider>("identityProviders", IdentityProviders);
            writer.WriteCollectionOfObjectValues<UserFlowLanguageConfiguration>("languages", Languages);
            writer.WriteCollectionOfObjectValues<IdentityUserFlowAttributeAssignment>("userAttributeAssignments", UserAttributeAssignments);
            writer.WriteCollectionOfObjectValues<IdentityProviderBase>("userFlowIdentityProviders", UserFlowIdentityProviders);
        }
    }
}
