using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OptionalClaims : IAdditionalDataHolder, IParsable {
        /// <summary>The optional claims returned in the JWT access token.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.OptionalClaim> AccessToken { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The optional claims returned in the JWT ID token.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.OptionalClaim> IdToken { get; set; }
        /// <summary>The optional claims returned in the SAML token.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.OptionalClaim> Saml2Token { get; set; }
        /// <summary>
        /// Instantiates a new optionalClaims and sets the default values.
        /// </summary>
        public OptionalClaims() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.OptionalClaims CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OptionalClaims();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"accessToken", (o,n) => { (o as OptionalClaims).AccessToken = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OptionalClaim>(ApiSdk.Models.Microsoft.Graph.OptionalClaim.CreateFromDiscriminatorValue).ToList(); } },
                {"idToken", (o,n) => { (o as OptionalClaims).IdToken = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OptionalClaim>(ApiSdk.Models.Microsoft.Graph.OptionalClaim.CreateFromDiscriminatorValue).ToList(); } },
                {"saml2Token", (o,n) => { (o as OptionalClaims).Saml2Token = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OptionalClaim>(ApiSdk.Models.Microsoft.Graph.OptionalClaim.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OptionalClaim>("accessToken", AccessToken);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OptionalClaim>("idToken", IdToken);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OptionalClaim>("saml2Token", Saml2Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
