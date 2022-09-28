using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ApiApplication : IAdditionalDataHolder, IParsable {
        /// <summary>When true, allows an application to use claims mapping without specifying a custom signing key.</summary>
        public bool? AcceptMappedClaims { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. If you set the appID of the client app to this value, the user only consents once to the client app. Azure AD knows that consenting to the client means implicitly consenting to the web API and automatically provisions service principals for both APIs at the same time. Both the client and the web API app must be registered in the same tenant.</summary>
        public List<string> KnownClientApplications { get; set; }
        /// <summary>The definition of the delegated permissions exposed by the web API represented by this application registration. These delegated permissions may be requested by a client application, and may be granted by users or administrators during consent. Delegated permissions are sometimes referred to as OAuth 2.0 scopes.</summary>
        public List<PermissionScope> Oauth2PermissionScopes { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Lists the client applications that are pre-authorized with the specified delegated permissions to access this application&apos;s APIs. Users are not required to consent to any pre-authorized application (for the permissions specified). However, any additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.</summary>
        public List<PreAuthorizedApplication> PreAuthorizedApplications { get; set; }
        /// <summary>Specifies the access token version expected by this resource. This changes the version and format of the JWT produced independent of the endpoint or client used to request the access token.  The endpoint used, v1.0 or v2.0, is chosen by the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion to indicate the supported access token format.  Possible values for requestedAccessTokenVersion are 1, 2, or null. If the value is null, this defaults to 1, which corresponds to the v1.0 endpoint.  If signInAudience on the application is configured as AzureADandPersonalMicrosoftAccount, the value for this property must be 2</summary>
        public int? RequestedAccessTokenVersion { get; set; }
        /// <summary>
        /// Instantiates a new apiApplication and sets the default values.
        /// </summary>
        public ApiApplication() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.apiApplication";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiApplication CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApiApplication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"acceptMappedClaims", n => { AcceptMappedClaims = n.GetBoolValue(); } },
                {"knownClientApplications", n => { KnownClientApplications = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"oauth2PermissionScopes", n => { Oauth2PermissionScopes = n.GetCollectionOfObjectValues<PermissionScope>(PermissionScope.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"preAuthorizedApplications", n => { PreAuthorizedApplications = n.GetCollectionOfObjectValues<PreAuthorizedApplication>(PreAuthorizedApplication.CreateFromDiscriminatorValue)?.ToList(); } },
                {"requestedAccessTokenVersion", n => { RequestedAccessTokenVersion = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("acceptMappedClaims", AcceptMappedClaims);
            writer.WriteCollectionOfPrimitiveValues<string>("knownClientApplications", KnownClientApplications);
            writer.WriteCollectionOfObjectValues<PermissionScope>("oauth2PermissionScopes", Oauth2PermissionScopes);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<PreAuthorizedApplication>("preAuthorizedApplications", PreAuthorizedApplications);
            writer.WriteIntValue("requestedAccessTokenVersion", RequestedAccessTokenVersion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
