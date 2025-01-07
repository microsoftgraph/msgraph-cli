// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class PolicyRoot : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The policy that controls the idle time out for web sessions for applications.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ActivityBasedTimeoutPolicy>? ActivityBasedTimeoutPolicies { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ActivityBasedTimeoutPolicy> ActivityBasedTimeoutPolicies { get; set; }
#endif
        /// <summary>The policy by which consent requests are created and managed for the entire tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AdminConsentRequestPolicy? AdminConsentRequestPolicy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AdminConsentRequestPolicy AdminConsentRequestPolicy { get; set; }
#endif
        /// <summary>The policies that enforce app management restrictions for specific applications and service principals, overriding the defaultAppManagementPolicy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AppManagementPolicy>? AppManagementPolicies { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AppManagementPolicy> AppManagementPolicies { get; set; }
#endif
        /// <summary>The policy configuration of the self-service sign-up experience of external users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AuthenticationFlowsPolicy? AuthenticationFlowsPolicy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AuthenticationFlowsPolicy AuthenticationFlowsPolicy { get; set; }
#endif
        /// <summary>The authentication methods and the users that are allowed to use them to sign in and perform multifactor authentication (MFA) in Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AuthenticationMethodsPolicy? AuthenticationMethodsPolicy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AuthenticationMethodsPolicy AuthenticationMethodsPolicy { get; set; }
#endif
        /// <summary>The authentication method combinations that are to be used in scenarios defined by Microsoft Entra Conditional Access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AuthenticationStrengthPolicy>? AuthenticationStrengthPolicies { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AuthenticationStrengthPolicy> AuthenticationStrengthPolicies { get; set; }
#endif
        /// <summary>The policy that controls Microsoft Entra authorization settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.AuthorizationPolicy? AuthorizationPolicy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.AuthorizationPolicy AuthorizationPolicy { get; set; }
#endif
        /// <summary>The claim-mapping policies for WS-Fed, SAML, OAuth 2.0, and OpenID Connect protocols, for tokens issued to a specific application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ClaimsMappingPolicy>? ClaimsMappingPolicies { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ClaimsMappingPolicy> ClaimsMappingPolicies { get; set; }
#endif
        /// <summary>The custom rules that define an access scenario.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ConditionalAccessPolicy>? ConditionalAccessPolicies { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ConditionalAccessPolicy> ConditionalAccessPolicies { get; set; }
#endif
        /// <summary>The custom rules that define an access scenario when interacting with external Microsoft Entra tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.CrossTenantAccessPolicy? CrossTenantAccessPolicy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.CrossTenantAccessPolicy CrossTenantAccessPolicy { get; set; }
#endif
        /// <summary>The tenant-wide policy that enforces app management restrictions for all applications and service principals.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.TenantAppManagementPolicy? DefaultAppManagementPolicy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.TenantAppManagementPolicy DefaultAppManagementPolicy { get; set; }
#endif
        /// <summary>The deviceRegistrationPolicy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DeviceRegistrationPolicy? DeviceRegistrationPolicy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DeviceRegistrationPolicy DeviceRegistrationPolicy { get; set; }
#endif
        /// <summary>The feature rollout policy associated with a directory object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.FeatureRolloutPolicy>? FeatureRolloutPolicies { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.FeatureRolloutPolicy> FeatureRolloutPolicies { get; set; }
#endif
        /// <summary>The policy to control Microsoft Entra authentication behavior for federated users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.HomeRealmDiscoveryPolicy>? HomeRealmDiscoveryPolicies { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.HomeRealmDiscoveryPolicy> HomeRealmDiscoveryPolicies { get; set; }
#endif
        /// <summary>The policy that represents the security defaults that protect against common attacks.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySecurityDefaultsEnforcementPolicy? IdentitySecurityDefaultsEnforcementPolicy { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySecurityDefaultsEnforcementPolicy IdentitySecurityDefaultsEnforcementPolicy { get; set; }
#endif
        /// <summary>The policy that specifies the conditions under which consent can be granted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PermissionGrantPolicy>? PermissionGrantPolicies { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PermissionGrantPolicy> PermissionGrantPolicies { get; set; }
#endif
        /// <summary>Specifies the various policies associated with scopes and roles.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.UnifiedRoleManagementPolicy>? RoleManagementPolicies { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.UnifiedRoleManagementPolicy> RoleManagementPolicies { get; set; }
#endif
        /// <summary>The assignment of a role management policy to a role definition object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.UnifiedRoleManagementPolicyAssignment>? RoleManagementPolicyAssignments { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.UnifiedRoleManagementPolicyAssignment> RoleManagementPolicyAssignments { get; set; }
#endif
        /// <summary>The policy that specifies the characteristics of SAML tokens issued by Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.TokenIssuancePolicy>? TokenIssuancePolicies { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.TokenIssuancePolicy> TokenIssuancePolicies { get; set; }
#endif
        /// <summary>The policy that controls the lifetime of a JWT access token, an ID token, or a SAML 1.1/2.0 token issued by Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.TokenLifetimePolicy>? TokenLifetimePolicies { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.TokenLifetimePolicy> TokenLifetimePolicies { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PolicyRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.PolicyRoot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.PolicyRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activityBasedTimeoutPolicies", n => { ActivityBasedTimeoutPolicies = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ActivityBasedTimeoutPolicy>(global::ApiSdk.Models.ActivityBasedTimeoutPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "adminConsentRequestPolicy", n => { AdminConsentRequestPolicy = n.GetObjectValue<global::ApiSdk.Models.AdminConsentRequestPolicy>(global::ApiSdk.Models.AdminConsentRequestPolicy.CreateFromDiscriminatorValue); } },
                { "appManagementPolicies", n => { AppManagementPolicies = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AppManagementPolicy>(global::ApiSdk.Models.AppManagementPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "authenticationFlowsPolicy", n => { AuthenticationFlowsPolicy = n.GetObjectValue<global::ApiSdk.Models.AuthenticationFlowsPolicy>(global::ApiSdk.Models.AuthenticationFlowsPolicy.CreateFromDiscriminatorValue); } },
                { "authenticationMethodsPolicy", n => { AuthenticationMethodsPolicy = n.GetObjectValue<global::ApiSdk.Models.AuthenticationMethodsPolicy>(global::ApiSdk.Models.AuthenticationMethodsPolicy.CreateFromDiscriminatorValue); } },
                { "authenticationStrengthPolicies", n => { AuthenticationStrengthPolicies = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AuthenticationStrengthPolicy>(global::ApiSdk.Models.AuthenticationStrengthPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "authorizationPolicy", n => { AuthorizationPolicy = n.GetObjectValue<global::ApiSdk.Models.AuthorizationPolicy>(global::ApiSdk.Models.AuthorizationPolicy.CreateFromDiscriminatorValue); } },
                { "claimsMappingPolicies", n => { ClaimsMappingPolicies = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ClaimsMappingPolicy>(global::ApiSdk.Models.ClaimsMappingPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "conditionalAccessPolicies", n => { ConditionalAccessPolicies = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ConditionalAccessPolicy>(global::ApiSdk.Models.ConditionalAccessPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "crossTenantAccessPolicy", n => { CrossTenantAccessPolicy = n.GetObjectValue<global::ApiSdk.Models.CrossTenantAccessPolicy>(global::ApiSdk.Models.CrossTenantAccessPolicy.CreateFromDiscriminatorValue); } },
                { "defaultAppManagementPolicy", n => { DefaultAppManagementPolicy = n.GetObjectValue<global::ApiSdk.Models.TenantAppManagementPolicy>(global::ApiSdk.Models.TenantAppManagementPolicy.CreateFromDiscriminatorValue); } },
                { "deviceRegistrationPolicy", n => { DeviceRegistrationPolicy = n.GetObjectValue<global::ApiSdk.Models.DeviceRegistrationPolicy>(global::ApiSdk.Models.DeviceRegistrationPolicy.CreateFromDiscriminatorValue); } },
                { "featureRolloutPolicies", n => { FeatureRolloutPolicies = n.GetCollectionOfObjectValues<global::ApiSdk.Models.FeatureRolloutPolicy>(global::ApiSdk.Models.FeatureRolloutPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "homeRealmDiscoveryPolicies", n => { HomeRealmDiscoveryPolicies = n.GetCollectionOfObjectValues<global::ApiSdk.Models.HomeRealmDiscoveryPolicy>(global::ApiSdk.Models.HomeRealmDiscoveryPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "identitySecurityDefaultsEnforcementPolicy", n => { IdentitySecurityDefaultsEnforcementPolicy = n.GetObjectValue<global::ApiSdk.Models.IdentitySecurityDefaultsEnforcementPolicy>(global::ApiSdk.Models.IdentitySecurityDefaultsEnforcementPolicy.CreateFromDiscriminatorValue); } },
                { "permissionGrantPolicies", n => { PermissionGrantPolicies = n.GetCollectionOfObjectValues<global::ApiSdk.Models.PermissionGrantPolicy>(global::ApiSdk.Models.PermissionGrantPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "roleManagementPolicies", n => { RoleManagementPolicies = n.GetCollectionOfObjectValues<global::ApiSdk.Models.UnifiedRoleManagementPolicy>(global::ApiSdk.Models.UnifiedRoleManagementPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "roleManagementPolicyAssignments", n => { RoleManagementPolicyAssignments = n.GetCollectionOfObjectValues<global::ApiSdk.Models.UnifiedRoleManagementPolicyAssignment>(global::ApiSdk.Models.UnifiedRoleManagementPolicyAssignment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tokenIssuancePolicies", n => { TokenIssuancePolicies = n.GetCollectionOfObjectValues<global::ApiSdk.Models.TokenIssuancePolicy>(global::ApiSdk.Models.TokenIssuancePolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tokenLifetimePolicies", n => { TokenLifetimePolicies = n.GetCollectionOfObjectValues<global::ApiSdk.Models.TokenLifetimePolicy>(global::ApiSdk.Models.TokenLifetimePolicy.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ActivityBasedTimeoutPolicy>("activityBasedTimeoutPolicies", ActivityBasedTimeoutPolicies);
            writer.WriteObjectValue<global::ApiSdk.Models.AdminConsentRequestPolicy>("adminConsentRequestPolicy", AdminConsentRequestPolicy);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AppManagementPolicy>("appManagementPolicies", AppManagementPolicies);
            writer.WriteObjectValue<global::ApiSdk.Models.AuthenticationFlowsPolicy>("authenticationFlowsPolicy", AuthenticationFlowsPolicy);
            writer.WriteObjectValue<global::ApiSdk.Models.AuthenticationMethodsPolicy>("authenticationMethodsPolicy", AuthenticationMethodsPolicy);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AuthenticationStrengthPolicy>("authenticationStrengthPolicies", AuthenticationStrengthPolicies);
            writer.WriteObjectValue<global::ApiSdk.Models.AuthorizationPolicy>("authorizationPolicy", AuthorizationPolicy);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ClaimsMappingPolicy>("claimsMappingPolicies", ClaimsMappingPolicies);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ConditionalAccessPolicy>("conditionalAccessPolicies", ConditionalAccessPolicies);
            writer.WriteObjectValue<global::ApiSdk.Models.CrossTenantAccessPolicy>("crossTenantAccessPolicy", CrossTenantAccessPolicy);
            writer.WriteObjectValue<global::ApiSdk.Models.TenantAppManagementPolicy>("defaultAppManagementPolicy", DefaultAppManagementPolicy);
            writer.WriteObjectValue<global::ApiSdk.Models.DeviceRegistrationPolicy>("deviceRegistrationPolicy", DeviceRegistrationPolicy);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.FeatureRolloutPolicy>("featureRolloutPolicies", FeatureRolloutPolicies);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.HomeRealmDiscoveryPolicy>("homeRealmDiscoveryPolicies", HomeRealmDiscoveryPolicies);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySecurityDefaultsEnforcementPolicy>("identitySecurityDefaultsEnforcementPolicy", IdentitySecurityDefaultsEnforcementPolicy);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.PermissionGrantPolicy>("permissionGrantPolicies", PermissionGrantPolicies);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.UnifiedRoleManagementPolicy>("roleManagementPolicies", RoleManagementPolicies);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.UnifiedRoleManagementPolicyAssignment>("roleManagementPolicyAssignments", RoleManagementPolicyAssignments);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.TokenIssuancePolicy>("tokenIssuancePolicies", TokenIssuancePolicies);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.TokenLifetimePolicy>("tokenLifetimePolicies", TokenLifetimePolicies);
        }
    }
}
#pragma warning restore CS0618
