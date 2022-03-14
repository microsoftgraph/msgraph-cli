using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PolicyRoot : Entity, IParsable {
        /// <summary>The policy that controls the idle time out for web sessions for applications.</summary>
        public List<ActivityBasedTimeoutPolicy> ActivityBasedTimeoutPolicies { get; set; }
        /// <summary>The policy by which consent requests are created and managed for the entire tenant.</summary>
        public ApiSdk.Models.Microsoft.Graph.AdminConsentRequestPolicy AdminConsentRequestPolicy { get; set; }
        /// <summary>The policy configuration of the self-service sign-up experience of external users.</summary>
        public ApiSdk.Models.Microsoft.Graph.AuthenticationFlowsPolicy AuthenticationFlowsPolicy { get; set; }
        /// <summary>The authentication methods and the users that are allowed to use them to sign in and perform multi-factor authentication (MFA) in Azure Active Directory (Azure AD).</summary>
        public ApiSdk.Models.Microsoft.Graph.AuthenticationMethodsPolicy AuthenticationMethodsPolicy { get; set; }
        /// <summary>The policy that controls Azure AD authorization settings.</summary>
        public ApiSdk.Models.Microsoft.Graph.AuthorizationPolicy AuthorizationPolicy { get; set; }
        /// <summary>The claim-mapping policies for WS-Fed, SAML, OAuth 2.0, and OpenID Connect protocols, for tokens issued to a specific application.</summary>
        public List<ClaimsMappingPolicy> ClaimsMappingPolicies { get; set; }
        /// <summary>The custom rules that define an access scenario.</summary>
        public List<ConditionalAccessPolicy> ConditionalAccessPolicies { get; set; }
        /// <summary>The feature rollout policy associated with a directory object.</summary>
        public List<FeatureRolloutPolicy> FeatureRolloutPolicies { get; set; }
        /// <summary>The policy to control Azure AD authentication behavior for federated users.</summary>
        public List<HomeRealmDiscoveryPolicy> HomeRealmDiscoveryPolicies { get; set; }
        /// <summary>The policy that represents the security defaults that protect against common attacks.</summary>
        public ApiSdk.Models.Microsoft.Graph.IdentitySecurityDefaultsEnforcementPolicy IdentitySecurityDefaultsEnforcementPolicy { get; set; }
        /// <summary>The policy that specifies the conditions under which consent can be granted.</summary>
        public List<PermissionGrantPolicy> PermissionGrantPolicies { get; set; }
        /// <summary>The policy that specifies the characteristics of SAML tokens issued by Azure AD.</summary>
        public List<TokenIssuancePolicy> TokenIssuancePolicies { get; set; }
        /// <summary>The policy that controls the lifetime of a JWT access token, an ID token, or a SAML 1.1/2.0 token issued by Azure AD.</summary>
        public List<TokenLifetimePolicy> TokenLifetimePolicies { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PolicyRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PolicyRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activityBasedTimeoutPolicies", (o,n) => { (o as PolicyRoot).ActivityBasedTimeoutPolicies = n.GetCollectionOfObjectValues<ActivityBasedTimeoutPolicy>(ActivityBasedTimeoutPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"adminConsentRequestPolicy", (o,n) => { (o as PolicyRoot).AdminConsentRequestPolicy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AdminConsentRequestPolicy>(ApiSdk.Models.Microsoft.Graph.AdminConsentRequestPolicy.CreateFromDiscriminatorValue); } },
                {"authenticationFlowsPolicy", (o,n) => { (o as PolicyRoot).AuthenticationFlowsPolicy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AuthenticationFlowsPolicy>(ApiSdk.Models.Microsoft.Graph.AuthenticationFlowsPolicy.CreateFromDiscriminatorValue); } },
                {"authenticationMethodsPolicy", (o,n) => { (o as PolicyRoot).AuthenticationMethodsPolicy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AuthenticationMethodsPolicy>(ApiSdk.Models.Microsoft.Graph.AuthenticationMethodsPolicy.CreateFromDiscriminatorValue); } },
                {"authorizationPolicy", (o,n) => { (o as PolicyRoot).AuthorizationPolicy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AuthorizationPolicy>(ApiSdk.Models.Microsoft.Graph.AuthorizationPolicy.CreateFromDiscriminatorValue); } },
                {"claimsMappingPolicies", (o,n) => { (o as PolicyRoot).ClaimsMappingPolicies = n.GetCollectionOfObjectValues<ClaimsMappingPolicy>(ClaimsMappingPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"conditionalAccessPolicies", (o,n) => { (o as PolicyRoot).ConditionalAccessPolicies = n.GetCollectionOfObjectValues<ConditionalAccessPolicy>(ConditionalAccessPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"featureRolloutPolicies", (o,n) => { (o as PolicyRoot).FeatureRolloutPolicies = n.GetCollectionOfObjectValues<FeatureRolloutPolicy>(FeatureRolloutPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"homeRealmDiscoveryPolicies", (o,n) => { (o as PolicyRoot).HomeRealmDiscoveryPolicies = n.GetCollectionOfObjectValues<HomeRealmDiscoveryPolicy>(HomeRealmDiscoveryPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"identitySecurityDefaultsEnforcementPolicy", (o,n) => { (o as PolicyRoot).IdentitySecurityDefaultsEnforcementPolicy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySecurityDefaultsEnforcementPolicy>(ApiSdk.Models.Microsoft.Graph.IdentitySecurityDefaultsEnforcementPolicy.CreateFromDiscriminatorValue); } },
                {"permissionGrantPolicies", (o,n) => { (o as PolicyRoot).PermissionGrantPolicies = n.GetCollectionOfObjectValues<PermissionGrantPolicy>(PermissionGrantPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"tokenIssuancePolicies", (o,n) => { (o as PolicyRoot).TokenIssuancePolicies = n.GetCollectionOfObjectValues<TokenIssuancePolicy>(TokenIssuancePolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"tokenLifetimePolicies", (o,n) => { (o as PolicyRoot).TokenLifetimePolicies = n.GetCollectionOfObjectValues<TokenLifetimePolicy>(TokenLifetimePolicy.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ActivityBasedTimeoutPolicy>("activityBasedTimeoutPolicies", ActivityBasedTimeoutPolicies);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AdminConsentRequestPolicy>("adminConsentRequestPolicy", AdminConsentRequestPolicy);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AuthenticationFlowsPolicy>("authenticationFlowsPolicy", AuthenticationFlowsPolicy);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AuthenticationMethodsPolicy>("authenticationMethodsPolicy", AuthenticationMethodsPolicy);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AuthorizationPolicy>("authorizationPolicy", AuthorizationPolicy);
            writer.WriteCollectionOfObjectValues<ClaimsMappingPolicy>("claimsMappingPolicies", ClaimsMappingPolicies);
            writer.WriteCollectionOfObjectValues<ConditionalAccessPolicy>("conditionalAccessPolicies", ConditionalAccessPolicies);
            writer.WriteCollectionOfObjectValues<FeatureRolloutPolicy>("featureRolloutPolicies", FeatureRolloutPolicies);
            writer.WriteCollectionOfObjectValues<HomeRealmDiscoveryPolicy>("homeRealmDiscoveryPolicies", HomeRealmDiscoveryPolicies);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySecurityDefaultsEnforcementPolicy>("identitySecurityDefaultsEnforcementPolicy", IdentitySecurityDefaultsEnforcementPolicy);
            writer.WriteCollectionOfObjectValues<PermissionGrantPolicy>("permissionGrantPolicies", PermissionGrantPolicies);
            writer.WriteCollectionOfObjectValues<TokenIssuancePolicy>("tokenIssuancePolicies", TokenIssuancePolicies);
            writer.WriteCollectionOfObjectValues<TokenLifetimePolicy>("tokenLifetimePolicies", TokenLifetimePolicies);
        }
    }
}
