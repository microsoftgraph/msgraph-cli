using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ServicePrincipal : DirectoryObject, IParsable {
        /// <summary>true if the service principal account is enabled; otherwise, false. Supports $filter (eq, ne, not, in).</summary>
        public bool? AccountEnabled { get; set; }
        /// <summary>Defines custom behavior that a consuming service can use to call an app in specific contexts. For example, applications that can render file streams may set the addIns property for its 'FileHandler' functionality. This will let services like Microsoft 365 call the application in the context of a document the user is working on.</summary>
        public List<AddIn> AddIns { get; set; }
        /// <summary>Used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities. Supports $filter (eq, not, ge, le, startsWith).</summary>
        public List<string> AlternativeNames { get; set; }
        /// <summary>The description exposed by the associated application.</summary>
        public string AppDescription { get; set; }
        /// <summary>The display name exposed by the associated application.</summary>
        public string AppDisplayName { get; set; }
        /// <summary>The unique identifier for the associated application (its appId property). Supports $filter (eq, ne, not, in, startsWith).</summary>
        public string AppId { get; set; }
        /// <summary>Unique identifier of the applicationTemplate that the servicePrincipal was created from. Read-only. Supports $filter (eq, ne, NOT, startsWith).</summary>
        public string ApplicationTemplateId { get; set; }
        /// <summary>Contains the tenant id where the application is registered. This is applicable only to service principals backed by applications.Supports $filter (eq, ne, NOT, ge, le).</summary>
        public string AppOwnerOrganizationId { get; set; }
        /// <summary>App role assignments for this app or service, granted to users, groups, and other service principals.Supports $expand.</summary>
        public List<AppRoleAssignment> AppRoleAssignedTo { get; set; }
        /// <summary>Specifies whether users or other service principals need to be granted an app role assignment for this service principal before users can sign in or apps can get tokens. The default value is false. Not nullable. Supports $filter (eq, ne, NOT).</summary>
        public bool? AppRoleAssignmentRequired { get; set; }
        /// <summary>App role assignment for another app or service, granted to this service principal. Supports $expand.</summary>
        public List<AppRoleAssignment> AppRoleAssignments { get; set; }
        /// <summary>The roles exposed by the application which this service principal represents. For more information see the appRoles property definition on the application entity. Not nullable.</summary>
        public List<AppRole> AppRoles { get; set; }
        /// <summary>The claimsMappingPolicies assigned to this service principal. Supports $expand.</summary>
        public List<ClaimsMappingPolicy> ClaimsMappingPolicies { get; set; }
        /// <summary>Directory objects created by this service principal. Read-only. Nullable.</summary>
        public List<DirectoryObject> CreatedObjects { get; set; }
        /// <summary>The permission classifications for delegated permissions exposed by the app that this service principal represents. Supports $expand.</summary>
        public List<DelegatedPermissionClassification> DelegatedPermissionClassifications { get; set; }
        /// <summary>Free text field to provide an internal end-user facing description of the service principal. End-user portals such MyApps will display the application description in this field. The maximum allowed size is 1024 characters. Supports $filter (eq, ne, not, ge, le, startsWith) and $search.</summary>
        public string Description { get; set; }
        /// <summary>Specifies whether Microsoft has disabled the registered application. Possible values are: null (default value), NotDisabled, and DisabledDueToViolationOfServicesAgreement (reasons may include suspicious, abusive, or malicious activity, or a violation of the Microsoft Services Agreement).  Supports $filter (eq, ne, not).</summary>
        public string DisabledByMicrosoftStatus { get; set; }
        /// <summary>The display name for the service principal. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.</summary>
        public string DisplayName { get; set; }
        /// <summary>Endpoints available for discovery. Services like Sharepoint populate this property with a tenant specific SharePoint endpoints that other applications can discover and use in their experiences.</summary>
        public List<Endpoint> Endpoints { get; set; }
        /// <summary>Home page or landing page of the application.</summary>
        public string Homepage { get; set; }
        /// <summary>The homeRealmDiscoveryPolicies assigned to this service principal. Supports $expand.</summary>
        public List<HomeRealmDiscoveryPolicy> HomeRealmDiscoveryPolicies { get; set; }
        /// <summary>Basic profile information of the acquired application such as app's marketing, support, terms of service and privacy statement URLs. The terms of service and privacy statement are surfaced to users through the user consent experience. For more info, see How to: Add Terms of service and privacy statement for registered Azure AD apps. Supports $filter (eq, ne, not, ge, le, and eq on null values).</summary>
        public InformationalUrl Info { get; set; }
        /// <summary>The collection of key credentials associated with the service principal. Not nullable. Supports $filter (eq, not, ge, le).</summary>
        public List<KeyCredential> KeyCredentials { get; set; }
        /// <summary>Specifies the URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps. When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on. The user launches the application from Microsoft 365, the Azure AD My Apps, or the Azure AD SSO URL.</summary>
        public string LoginUrl { get; set; }
        /// <summary>Specifies the URL that will be used by Microsoft's authorization service to logout an user using OpenId Connect front-channel, back-channel or SAML logout protocols.</summary>
        public string LogoutUrl { get; set; }
        /// <summary>Roles that this service principal is a member of. HTTP Methods: GET Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> MemberOf { get; set; }
        /// <summary>Free text field to capture information about the service principal, typically used for operational purposes. Maximum allowed size is 1024 characters.</summary>
        public string Notes { get; set; }
        /// <summary>Specifies the list of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications.</summary>
        public List<string> NotificationEmailAddresses { get; set; }
        /// <summary>Delegated permission grants authorizing this service principal to access an API on behalf of a signed-in user. Read-only. Nullable.</summary>
        public List<OAuth2PermissionGrant> Oauth2PermissionGrants { get; set; }
        /// <summary>The delegated permissions exposed by the application. For more information see the oauth2PermissionScopes property on the application entity's api property. Not nullable.</summary>
        public List<PermissionScope> Oauth2PermissionScopes { get; set; }
        /// <summary>Directory objects that are owned by this service principal. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> OwnedObjects { get; set; }
        /// <summary>Directory objects that are owners of this servicePrincipal. The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> Owners { get; set; }
        /// <summary>The collection of password credentials associated with the service principal. Not nullable.</summary>
        public List<PasswordCredential> PasswordCredentials { get; set; }
        /// <summary>Specifies the single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps. The supported values are password, saml, notSupported, and oidc.</summary>
        public string PreferredSingleSignOnMode { get; set; }
        /// <summary>Reserved for internal use only. Do not write or otherwise rely on this property. May be removed in future versions.</summary>
        public string PreferredTokenSigningKeyThumbprint { get; set; }
        /// <summary>The URLs that user tokens are sent to for sign in with the associated application, or the redirect URIs that OAuth 2.0 authorization codes and access tokens are sent to for the associated application. Not nullable.</summary>
        public List<string> ReplyUrls { get; set; }
        /// <summary>The collection for settings related to saml single sign-on.</summary>
        public SamlSingleSignOnSettings SamlSingleSignOnSettings { get; set; }
        /// <summary>Contains the list of identifiersUris, copied over from the associated application. Additional values can be added to hybrid applications. These values can be used to identify the permissions exposed by this app within Azure AD. For example,Client apps can specify a resource URI which is based on the values of this property to acquire an access token, which is the URI returned in the 'aud' claim.The any operator is required for filter expressions on multi-valued properties. Not nullable.  Supports $filter (eq, not, ge, le, startsWith).</summary>
        public List<string> ServicePrincipalNames { get; set; }
        /// <summary>Identifies if the service principal represents an application or a managed identity. This is set by Azure AD internally. For a service principal that represents an application this is set as Application. For a service principal that represent a managed identity this is set as ManagedIdentity. The SocialIdp type is for internal use.</summary>
        public string ServicePrincipalType { get; set; }
        /// <summary>Specifies the Microsoft accounts that are supported for the current application. Read-only. Supported values are:AzureADMyOrg: Users with a Microsoft work or school account in my organization’s Azure AD tenant (single-tenant).AzureADMultipleOrgs: Users with a Microsoft work or school account in any organization’s Azure AD tenant (multi-tenant).AzureADandPersonalMicrosoftAccount: Users with a personal Microsoft account, or a work or school account in any organization’s Azure AD tenant.PersonalMicrosoftAccount: Users with a personal Microsoft account only.</summary>
        public string SignInAudience { get; set; }
        /// <summary>Custom strings that can be used to categorize and identify the service principal. Not nullable. Supports $filter (eq, not, ge, le, startsWith).</summary>
        public List<string> Tags { get; set; }
        /// <summary>Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD issues tokens for this application encrypted using the key specified by this property. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.</summary>
        public string TokenEncryptionKeyId { get; set; }
        /// <summary>The tokenIssuancePolicies assigned to this service principal. Supports $expand.</summary>
        public List<TokenIssuancePolicy> TokenIssuancePolicies { get; set; }
        /// <summary>The tokenLifetimePolicies assigned to this service principal. Supports $expand.</summary>
        public List<TokenLifetimePolicy> TokenLifetimePolicies { get; set; }
        public List<DirectoryObject> TransitiveMemberOf { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accountEnabled", (o,n) => { (o as ServicePrincipal).AccountEnabled = n.GetBoolValue(); } },
                {"addIns", (o,n) => { (o as ServicePrincipal).AddIns = n.GetCollectionOfObjectValues<AddIn>().ToList(); } },
                {"alternativeNames", (o,n) => { (o as ServicePrincipal).AlternativeNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"appDescription", (o,n) => { (o as ServicePrincipal).AppDescription = n.GetStringValue(); } },
                {"appDisplayName", (o,n) => { (o as ServicePrincipal).AppDisplayName = n.GetStringValue(); } },
                {"appId", (o,n) => { (o as ServicePrincipal).AppId = n.GetStringValue(); } },
                {"applicationTemplateId", (o,n) => { (o as ServicePrincipal).ApplicationTemplateId = n.GetStringValue(); } },
                {"appOwnerOrganizationId", (o,n) => { (o as ServicePrincipal).AppOwnerOrganizationId = n.GetStringValue(); } },
                {"appRoleAssignedTo", (o,n) => { (o as ServicePrincipal).AppRoleAssignedTo = n.GetCollectionOfObjectValues<AppRoleAssignment>().ToList(); } },
                {"appRoleAssignmentRequired", (o,n) => { (o as ServicePrincipal).AppRoleAssignmentRequired = n.GetBoolValue(); } },
                {"appRoleAssignments", (o,n) => { (o as ServicePrincipal).AppRoleAssignments = n.GetCollectionOfObjectValues<AppRoleAssignment>().ToList(); } },
                {"appRoles", (o,n) => { (o as ServicePrincipal).AppRoles = n.GetCollectionOfObjectValues<AppRole>().ToList(); } },
                {"claimsMappingPolicies", (o,n) => { (o as ServicePrincipal).ClaimsMappingPolicies = n.GetCollectionOfObjectValues<ClaimsMappingPolicy>().ToList(); } },
                {"createdObjects", (o,n) => { (o as ServicePrincipal).CreatedObjects = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
                {"delegatedPermissionClassifications", (o,n) => { (o as ServicePrincipal).DelegatedPermissionClassifications = n.GetCollectionOfObjectValues<DelegatedPermissionClassification>().ToList(); } },
                {"description", (o,n) => { (o as ServicePrincipal).Description = n.GetStringValue(); } },
                {"disabledByMicrosoftStatus", (o,n) => { (o as ServicePrincipal).DisabledByMicrosoftStatus = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ServicePrincipal).DisplayName = n.GetStringValue(); } },
                {"endpoints", (o,n) => { (o as ServicePrincipal).Endpoints = n.GetCollectionOfObjectValues<Endpoint>().ToList(); } },
                {"homepage", (o,n) => { (o as ServicePrincipal).Homepage = n.GetStringValue(); } },
                {"homeRealmDiscoveryPolicies", (o,n) => { (o as ServicePrincipal).HomeRealmDiscoveryPolicies = n.GetCollectionOfObjectValues<HomeRealmDiscoveryPolicy>().ToList(); } },
                {"info", (o,n) => { (o as ServicePrincipal).Info = n.GetObjectValue<InformationalUrl>(); } },
                {"keyCredentials", (o,n) => { (o as ServicePrincipal).KeyCredentials = n.GetCollectionOfObjectValues<KeyCredential>().ToList(); } },
                {"loginUrl", (o,n) => { (o as ServicePrincipal).LoginUrl = n.GetStringValue(); } },
                {"logoutUrl", (o,n) => { (o as ServicePrincipal).LogoutUrl = n.GetStringValue(); } },
                {"memberOf", (o,n) => { (o as ServicePrincipal).MemberOf = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
                {"notes", (o,n) => { (o as ServicePrincipal).Notes = n.GetStringValue(); } },
                {"notificationEmailAddresses", (o,n) => { (o as ServicePrincipal).NotificationEmailAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"oauth2PermissionGrants", (o,n) => { (o as ServicePrincipal).Oauth2PermissionGrants = n.GetCollectionOfObjectValues<OAuth2PermissionGrant>().ToList(); } },
                {"oauth2PermissionScopes", (o,n) => { (o as ServicePrincipal).Oauth2PermissionScopes = n.GetCollectionOfObjectValues<PermissionScope>().ToList(); } },
                {"ownedObjects", (o,n) => { (o as ServicePrincipal).OwnedObjects = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
                {"owners", (o,n) => { (o as ServicePrincipal).Owners = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
                {"passwordCredentials", (o,n) => { (o as ServicePrincipal).PasswordCredentials = n.GetCollectionOfObjectValues<PasswordCredential>().ToList(); } },
                {"preferredSingleSignOnMode", (o,n) => { (o as ServicePrincipal).PreferredSingleSignOnMode = n.GetStringValue(); } },
                {"preferredTokenSigningKeyThumbprint", (o,n) => { (o as ServicePrincipal).PreferredTokenSigningKeyThumbprint = n.GetStringValue(); } },
                {"replyUrls", (o,n) => { (o as ServicePrincipal).ReplyUrls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"samlSingleSignOnSettings", (o,n) => { (o as ServicePrincipal).SamlSingleSignOnSettings = n.GetObjectValue<SamlSingleSignOnSettings>(); } },
                {"servicePrincipalNames", (o,n) => { (o as ServicePrincipal).ServicePrincipalNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"servicePrincipalType", (o,n) => { (o as ServicePrincipal).ServicePrincipalType = n.GetStringValue(); } },
                {"signInAudience", (o,n) => { (o as ServicePrincipal).SignInAudience = n.GetStringValue(); } },
                {"tags", (o,n) => { (o as ServicePrincipal).Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"tokenEncryptionKeyId", (o,n) => { (o as ServicePrincipal).TokenEncryptionKeyId = n.GetStringValue(); } },
                {"tokenIssuancePolicies", (o,n) => { (o as ServicePrincipal).TokenIssuancePolicies = n.GetCollectionOfObjectValues<TokenIssuancePolicy>().ToList(); } },
                {"tokenLifetimePolicies", (o,n) => { (o as ServicePrincipal).TokenLifetimePolicies = n.GetCollectionOfObjectValues<TokenLifetimePolicy>().ToList(); } },
                {"transitiveMemberOf", (o,n) => { (o as ServicePrincipal).TransitiveMemberOf = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("accountEnabled", AccountEnabled);
            writer.WriteCollectionOfObjectValues<AddIn>("addIns", AddIns);
            writer.WriteCollectionOfPrimitiveValues<string>("alternativeNames", AlternativeNames);
            writer.WriteStringValue("appDescription", AppDescription);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("applicationTemplateId", ApplicationTemplateId);
            writer.WriteStringValue("appOwnerOrganizationId", AppOwnerOrganizationId);
            writer.WriteCollectionOfObjectValues<AppRoleAssignment>("appRoleAssignedTo", AppRoleAssignedTo);
            writer.WriteBoolValue("appRoleAssignmentRequired", AppRoleAssignmentRequired);
            writer.WriteCollectionOfObjectValues<AppRoleAssignment>("appRoleAssignments", AppRoleAssignments);
            writer.WriteCollectionOfObjectValues<AppRole>("appRoles", AppRoles);
            writer.WriteCollectionOfObjectValues<ClaimsMappingPolicy>("claimsMappingPolicies", ClaimsMappingPolicies);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("createdObjects", CreatedObjects);
            writer.WriteCollectionOfObjectValues<DelegatedPermissionClassification>("delegatedPermissionClassifications", DelegatedPermissionClassifications);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("disabledByMicrosoftStatus", DisabledByMicrosoftStatus);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<Endpoint>("endpoints", Endpoints);
            writer.WriteStringValue("homepage", Homepage);
            writer.WriteCollectionOfObjectValues<HomeRealmDiscoveryPolicy>("homeRealmDiscoveryPolicies", HomeRealmDiscoveryPolicies);
            writer.WriteObjectValue<InformationalUrl>("info", Info);
            writer.WriteCollectionOfObjectValues<KeyCredential>("keyCredentials", KeyCredentials);
            writer.WriteStringValue("loginUrl", LoginUrl);
            writer.WriteStringValue("logoutUrl", LogoutUrl);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("memberOf", MemberOf);
            writer.WriteStringValue("notes", Notes);
            writer.WriteCollectionOfPrimitiveValues<string>("notificationEmailAddresses", NotificationEmailAddresses);
            writer.WriteCollectionOfObjectValues<OAuth2PermissionGrant>("oauth2PermissionGrants", Oauth2PermissionGrants);
            writer.WriteCollectionOfObjectValues<PermissionScope>("oauth2PermissionScopes", Oauth2PermissionScopes);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("ownedObjects", OwnedObjects);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("owners", Owners);
            writer.WriteCollectionOfObjectValues<PasswordCredential>("passwordCredentials", PasswordCredentials);
            writer.WriteStringValue("preferredSingleSignOnMode", PreferredSingleSignOnMode);
            writer.WriteStringValue("preferredTokenSigningKeyThumbprint", PreferredTokenSigningKeyThumbprint);
            writer.WriteCollectionOfPrimitiveValues<string>("replyUrls", ReplyUrls);
            writer.WriteObjectValue<SamlSingleSignOnSettings>("samlSingleSignOnSettings", SamlSingleSignOnSettings);
            writer.WriteCollectionOfPrimitiveValues<string>("servicePrincipalNames", ServicePrincipalNames);
            writer.WriteStringValue("servicePrincipalType", ServicePrincipalType);
            writer.WriteStringValue("signInAudience", SignInAudience);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("tokenEncryptionKeyId", TokenEncryptionKeyId);
            writer.WriteCollectionOfObjectValues<TokenIssuancePolicy>("tokenIssuancePolicies", TokenIssuancePolicies);
            writer.WriteCollectionOfObjectValues<TokenLifetimePolicy>("tokenLifetimePolicies", TokenLifetimePolicies);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("transitiveMemberOf", TransitiveMemberOf);
        }
    }
}
