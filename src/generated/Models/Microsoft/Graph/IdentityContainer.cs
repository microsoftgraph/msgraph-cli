using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class IdentityContainer : Entity, IParsable {
        /// <summary>Represents entry point for API connectors.</summary>
        public List<IdentityApiConnector> ApiConnectors { get; set; }
        /// <summary>Represents entry point for B2X and self-service sign-up identity userflows.</summary>
        public List<B2xIdentityUserFlow> B2xUserFlows { get; set; }
        /// <summary>the entry point for the Conditional Access (CA) object model.</summary>
        public ConditionalAccessRoot ConditionalAccess { get; set; }
        /// <summary>Represents entry point for identity provider base.</summary>
        public List<IdentityProviderBase> IdentityProviders { get; set; }
        /// <summary>Represents entry point for identity userflow attributes.</summary>
        public List<IdentityUserFlowAttribute> UserFlowAttributes { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IdentityContainer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IdentityContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"apiConnectors", (o,n) => { (o as IdentityContainer).ApiConnectors = n.GetCollectionOfObjectValues<IdentityApiConnector>(IdentityApiConnector.CreateFromDiscriminatorValue).ToList(); } },
                {"b2xUserFlows", (o,n) => { (o as IdentityContainer).B2xUserFlows = n.GetCollectionOfObjectValues<B2xIdentityUserFlow>(B2xIdentityUserFlow.CreateFromDiscriminatorValue).ToList(); } },
                {"conditionalAccess", (o,n) => { (o as IdentityContainer).ConditionalAccess = n.GetObjectValue<ConditionalAccessRoot>(ConditionalAccessRoot.CreateFromDiscriminatorValue); } },
                {"identityProviders", (o,n) => { (o as IdentityContainer).IdentityProviders = n.GetCollectionOfObjectValues<IdentityProviderBase>(IdentityProviderBase.CreateFromDiscriminatorValue).ToList(); } },
                {"userFlowAttributes", (o,n) => { (o as IdentityContainer).UserFlowAttributes = n.GetCollectionOfObjectValues<IdentityUserFlowAttribute>(IdentityUserFlowAttribute.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<IdentityApiConnector>("apiConnectors", ApiConnectors);
            writer.WriteCollectionOfObjectValues<B2xIdentityUserFlow>("b2xUserFlows", B2xUserFlows);
            writer.WriteObjectValue<ConditionalAccessRoot>("conditionalAccess", ConditionalAccess);
            writer.WriteCollectionOfObjectValues<IdentityProviderBase>("identityProviders", IdentityProviders);
            writer.WriteCollectionOfObjectValues<IdentityUserFlowAttribute>("userFlowAttributes", UserFlowAttributes);
        }
    }
}
