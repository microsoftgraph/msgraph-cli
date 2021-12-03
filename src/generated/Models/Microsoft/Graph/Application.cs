using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Application : DirectoryObject, IParsable {
        /// <summary>Defines custom behavior that a consuming service can use to call an app in specific contexts. For example, applications that can render file streams may set the addIns property for its 'FileHandler' functionality. This will let services like Office 365 call the application in the context of a document the user is working on.</summary>
        public List<AddIn> AddIns { get; set; }
        /// <summary>Specifies settings for an application that implements a web API.</summary>
        public ApiApplication Api { get; set; }
        /// <summary>The unique identifier for the application that is assigned to an application by Azure AD. Not nullable. Read-only.</summary>
        public string AppId { get; set; }
        /// <summary>Unique identifier of the applicationTemplate.</summary>
        public string ApplicationTemplateId { get; set; }
        /// <summary>The collection of roles assigned to the application. With app role assignments, these roles can be assigned to users, groups, or service principals associated with other applications. Not nullable.</summary>
        public List<AppRole> AppRoles { get; set; }
        /// <summary>The date and time the application was registered. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.  Supports $filter (eq, ne, not, ge, le, in, and eq on null values) and $orderBy.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Read-only.</summary>
        public DirectoryObject CreatedOnBehalfOf { get; set; }
        /// <summary>An optional description of the application. Supports $filter (eq, ne, not, ge, le, startsWith) and $search.</summary>
        public string Description { get; set; }
        /// <summary>Specifies whether Microsoft has disabled the registered application. Possible values are: null (default value), NotDisabled, and DisabledDueToViolationOfServicesAgreement (reasons may include suspicious, abusive, or malicious activity, or a violation of the Microsoft Services Agreement).  Supports $filter (eq, ne, not).</summary>
        public string DisabledByMicrosoftStatus { get; set; }
        /// <summary>The display name for the application. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.</summary>
        public string DisplayName { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<ExtensionProperty> ExtensionProperties { get; set; }
        /// <summary>Configures the groups claim issued in a user or OAuth 2.0 access token that the application expects. To set this attribute, use one of the following valid string values: None, SecurityGroup (for security groups and Azure AD roles), All (this gets all of the security groups, distribution groups, and Azure AD directory roles that the signed-in user is a member of).</summary>
        public string GroupMembershipClaims { get; set; }
        public List<HomeRealmDiscoveryPolicy> HomeRealmDiscoveryPolicies { get; set; }
        /// <summary>Also known as App ID URI, this value is set when an application is used as a resource app. The identifierUris acts as the prefix for the scopes you'll reference in your API's code, and it must be globally unique. You can use the default value provided, which is in the form api://<application-client-id>, or specify a more readable URI like https://contoso.com/api. For more information on valid identifierUris patterns and best practices, see Azure AD application registration security best practices. Not nullable. Supports $filter (eq, ne, ge, le, startsWith).</summary>
        public List<string> IdentifierUris { get; set; }
        /// <summary>Basic profile information of the application such as  app's marketing, support, terms of service and privacy statement URLs. The terms of service and privacy statement are surfaced to users through the user consent experience. For more info, see How to: Add Terms of service and privacy statement for registered Azure AD apps. Supports $filter (eq, ne, not, ge, le, and eq on null values).</summary>
        public InformationalUrl Info { get; set; }
        /// <summary>Specifies whether this application supports device authentication without a user. The default is false.</summary>
        public bool? IsDeviceOnlyAuthSupported { get; set; }
        /// <summary>Specifies the fallback application type as public client, such as an installed application running on a mobile device. The default value is false which means the fallback application type is confidential client such as a web app. There are certain scenarios where Azure AD cannot determine the client application type. For example, the ROPC flow where it is configured without specifying a redirect URI. In those cases Azure AD interprets the application type based on the value of this property.</summary>
        public bool? IsFallbackPublicClient { get; set; }
        /// <summary>The collection of key credentials associated with the application. Not nullable. Supports $filter (eq, not, ge, le).</summary>
        public List<KeyCredential> KeyCredentials { get; set; }
        /// <summary>The main logo for the application. Not nullable.</summary>
        public byte[] Logo { get; set; }
        /// <summary>Notes relevant for the management of the application.</summary>
        public string Notes { get; set; }
        public bool? Oauth2RequirePostResponse { get; set; }
        /// <summary>Application developers can configure optional claims in their Azure AD applications to specify the claims that are sent to their application by the Microsoft security token service. For more information, see How to: Provide optional claims to your app.</summary>
        public OptionalClaims OptionalClaims { get; set; }
        /// <summary>Directory objects that are owners of the application. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> Owners { get; set; }
        /// <summary>Specifies parental control settings for an application.</summary>
        public ParentalControlSettings ParentalControlSettings { get; set; }
        /// <summary>The collection of password credentials associated with the application. Not nullable.</summary>
        public List<PasswordCredential> PasswordCredentials { get; set; }
        /// <summary>Specifies settings for installed clients such as desktop or mobile devices.</summary>
        public PublicClientApplication PublicClient { get; set; }
        /// <summary>The verified publisher domain for the application. Read-only. For more information, see How to: Configure an application's publisher domain. Supports $filter (eq, ne, ge, le, startsWith).</summary>
        public string PublisherDomain { get; set; }
        /// <summary>Specifies the resources that the application needs to access. This property also specifies the set of delegated permissions and application roles that it needs for each of those resources. This configuration of access to the required resources drives the consent experience. No more than 50 resource services (APIs) can be configured. Beginning mid-October 2021, the total number of required permissions must not exceed 400. Not nullable. Supports $filter (eq, not, ge, le).</summary>
        public List<RequiredResourceAccess> RequiredResourceAccess { get; set; }
        /// <summary>Specifies the Microsoft accounts that are supported for the current application. The possible values are: AzureADMyOrg, AzureADMultipleOrgs, AzureADandPersonalMicrosoftAccount (default), and PersonalMicrosoftAccount. See more in the table below. Supports $filter (eq, ne, not).</summary>
        public string SignInAudience { get; set; }
        /// <summary>Specifies settings for a single-page application, including sign out URLs and redirect URIs for authorization codes and access tokens.</summary>
        public SpaApplication Spa { get; set; }
        /// <summary>Custom strings that can be used to categorize and identify the application. Not nullable. Supports $filter (eq, not, ge, le, startsWith).</summary>
        public List<string> Tags { get; set; }
        /// <summary>Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD encrypts all the tokens it emits by using the key this property points to. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.</summary>
        public string TokenEncryptionKeyId { get; set; }
        public List<TokenIssuancePolicy> TokenIssuancePolicies { get; set; }
        /// <summary>The tokenLifetimePolicies assigned to this application. Supports $expand.</summary>
        public List<TokenLifetimePolicy> TokenLifetimePolicies { get; set; }
        /// <summary>Specifies the verified publisher of the application.</summary>
        public VerifiedPublisher VerifiedPublisher { get; set; }
        /// <summary>Specifies settings for a web application.</summary>
        public WebApplication Web { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"addIns", (o,n) => { (o as Application).AddIns = n.GetCollectionOfObjectValues<AddIn>().ToList(); } },
                {"api", (o,n) => { (o as Application).Api = n.GetObjectValue<ApiApplication>(); } },
                {"appId", (o,n) => { (o as Application).AppId = n.GetStringValue(); } },
                {"applicationTemplateId", (o,n) => { (o as Application).ApplicationTemplateId = n.GetStringValue(); } },
                {"appRoles", (o,n) => { (o as Application).AppRoles = n.GetCollectionOfObjectValues<AppRole>().ToList(); } },
                {"createdDateTime", (o,n) => { (o as Application).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdOnBehalfOf", (o,n) => { (o as Application).CreatedOnBehalfOf = n.GetObjectValue<DirectoryObject>(); } },
                {"description", (o,n) => { (o as Application).Description = n.GetStringValue(); } },
                {"disabledByMicrosoftStatus", (o,n) => { (o as Application).DisabledByMicrosoftStatus = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Application).DisplayName = n.GetStringValue(); } },
                {"extensionProperties", (o,n) => { (o as Application).ExtensionProperties = n.GetCollectionOfObjectValues<ExtensionProperty>().ToList(); } },
                {"groupMembershipClaims", (o,n) => { (o as Application).GroupMembershipClaims = n.GetStringValue(); } },
                {"homeRealmDiscoveryPolicies", (o,n) => { (o as Application).HomeRealmDiscoveryPolicies = n.GetCollectionOfObjectValues<HomeRealmDiscoveryPolicy>().ToList(); } },
                {"identifierUris", (o,n) => { (o as Application).IdentifierUris = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"info", (o,n) => { (o as Application).Info = n.GetObjectValue<InformationalUrl>(); } },
                {"isDeviceOnlyAuthSupported", (o,n) => { (o as Application).IsDeviceOnlyAuthSupported = n.GetBoolValue(); } },
                {"isFallbackPublicClient", (o,n) => { (o as Application).IsFallbackPublicClient = n.GetBoolValue(); } },
                {"keyCredentials", (o,n) => { (o as Application).KeyCredentials = n.GetCollectionOfObjectValues<KeyCredential>().ToList(); } },
                {"logo", (o,n) => { (o as Application).Logo = n.GetByteArrayValue(); } },
                {"notes", (o,n) => { (o as Application).Notes = n.GetStringValue(); } },
                {"oauth2RequirePostResponse", (o,n) => { (o as Application).Oauth2RequirePostResponse = n.GetBoolValue(); } },
                {"optionalClaims", (o,n) => { (o as Application).OptionalClaims = n.GetObjectValue<OptionalClaims>(); } },
                {"owners", (o,n) => { (o as Application).Owners = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
                {"parentalControlSettings", (o,n) => { (o as Application).ParentalControlSettings = n.GetObjectValue<ParentalControlSettings>(); } },
                {"passwordCredentials", (o,n) => { (o as Application).PasswordCredentials = n.GetCollectionOfObjectValues<PasswordCredential>().ToList(); } },
                {"publicClient", (o,n) => { (o as Application).PublicClient = n.GetObjectValue<PublicClientApplication>(); } },
                {"publisherDomain", (o,n) => { (o as Application).PublisherDomain = n.GetStringValue(); } },
                {"requiredResourceAccess", (o,n) => { (o as Application).RequiredResourceAccess = n.GetCollectionOfObjectValues<RequiredResourceAccess>().ToList(); } },
                {"signInAudience", (o,n) => { (o as Application).SignInAudience = n.GetStringValue(); } },
                {"spa", (o,n) => { (o as Application).Spa = n.GetObjectValue<SpaApplication>(); } },
                {"tags", (o,n) => { (o as Application).Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"tokenEncryptionKeyId", (o,n) => { (o as Application).TokenEncryptionKeyId = n.GetStringValue(); } },
                {"tokenIssuancePolicies", (o,n) => { (o as Application).TokenIssuancePolicies = n.GetCollectionOfObjectValues<TokenIssuancePolicy>().ToList(); } },
                {"tokenLifetimePolicies", (o,n) => { (o as Application).TokenLifetimePolicies = n.GetCollectionOfObjectValues<TokenLifetimePolicy>().ToList(); } },
                {"verifiedPublisher", (o,n) => { (o as Application).VerifiedPublisher = n.GetObjectValue<VerifiedPublisher>(); } },
                {"web", (o,n) => { (o as Application).Web = n.GetObjectValue<WebApplication>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AddIn>("addIns", AddIns);
            writer.WriteObjectValue<ApiApplication>("api", Api);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("applicationTemplateId", ApplicationTemplateId);
            writer.WriteCollectionOfObjectValues<AppRole>("appRoles", AppRoles);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<DirectoryObject>("createdOnBehalfOf", CreatedOnBehalfOf);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("disabledByMicrosoftStatus", DisabledByMicrosoftStatus);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<ExtensionProperty>("extensionProperties", ExtensionProperties);
            writer.WriteStringValue("groupMembershipClaims", GroupMembershipClaims);
            writer.WriteCollectionOfObjectValues<HomeRealmDiscoveryPolicy>("homeRealmDiscoveryPolicies", HomeRealmDiscoveryPolicies);
            writer.WriteCollectionOfPrimitiveValues<string>("identifierUris", IdentifierUris);
            writer.WriteObjectValue<InformationalUrl>("info", Info);
            writer.WriteBoolValue("isDeviceOnlyAuthSupported", IsDeviceOnlyAuthSupported);
            writer.WriteBoolValue("isFallbackPublicClient", IsFallbackPublicClient);
            writer.WriteCollectionOfObjectValues<KeyCredential>("keyCredentials", KeyCredentials);
            writer.WriteByteArrayValue("logo", Logo);
            writer.WriteStringValue("notes", Notes);
            writer.WriteBoolValue("oauth2RequirePostResponse", Oauth2RequirePostResponse);
            writer.WriteObjectValue<OptionalClaims>("optionalClaims", OptionalClaims);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("owners", Owners);
            writer.WriteObjectValue<ParentalControlSettings>("parentalControlSettings", ParentalControlSettings);
            writer.WriteCollectionOfObjectValues<PasswordCredential>("passwordCredentials", PasswordCredentials);
            writer.WriteObjectValue<PublicClientApplication>("publicClient", PublicClient);
            writer.WriteStringValue("publisherDomain", PublisherDomain);
            writer.WriteCollectionOfObjectValues<RequiredResourceAccess>("requiredResourceAccess", RequiredResourceAccess);
            writer.WriteStringValue("signInAudience", SignInAudience);
            writer.WriteObjectValue<SpaApplication>("spa", Spa);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("tokenEncryptionKeyId", TokenEncryptionKeyId);
            writer.WriteCollectionOfObjectValues<TokenIssuancePolicy>("tokenIssuancePolicies", TokenIssuancePolicies);
            writer.WriteCollectionOfObjectValues<TokenLifetimePolicy>("tokenLifetimePolicies", TokenLifetimePolicies);
            writer.WriteObjectValue<VerifiedPublisher>("verifiedPublisher", VerifiedPublisher);
            writer.WriteObjectValue<WebApplication>("web", Web);
        }
    }
}
