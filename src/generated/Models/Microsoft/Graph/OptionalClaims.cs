using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OptionalClaims : IParsable {
        /// <summary>The optional claims returned in the JWT access token.</summary>
        public List<OptionalClaim> AccessToken { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The optional claims returned in the JWT ID token.</summary>
        public List<OptionalClaim> IdToken { get; set; }
        /// <summary>The optional claims returned in the SAML token.</summary>
        public List<OptionalClaim> Saml2Token { get; set; }
        /// <summary>
        /// Instantiates a new optionalClaims and sets the default values.
        /// </summary>
        public OptionalClaims() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"accessToken", (o,n) => { (o as OptionalClaims).AccessToken = n.GetCollectionOfObjectValues<OptionalClaim>().ToList(); } },
                {"idToken", (o,n) => { (o as OptionalClaims).IdToken = n.GetCollectionOfObjectValues<OptionalClaim>().ToList(); } },
                {"saml2Token", (o,n) => { (o as OptionalClaims).Saml2Token = n.GetCollectionOfObjectValues<OptionalClaim>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<OptionalClaim>("accessToken", AccessToken);
            writer.WriteCollectionOfObjectValues<OptionalClaim>("idToken", IdToken);
            writer.WriteCollectionOfObjectValues<OptionalClaim>("saml2Token", Saml2Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
