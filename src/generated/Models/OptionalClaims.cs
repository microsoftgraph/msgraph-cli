using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class OptionalClaims : IAdditionalDataHolder, IParsable {
        /// <summary>The optional claims returned in the JWT access token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OptionalClaim>? AccessToken { get; set; }
#nullable restore
#else
        public List<OptionalClaim> AccessToken { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The optional claims returned in the JWT ID token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OptionalClaim>? IdToken { get; set; }
#nullable restore
#else
        public List<OptionalClaim> IdToken { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The optional claims returned in the SAML token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OptionalClaim>? Saml2Token { get; set; }
#nullable restore
#else
        public List<OptionalClaim> Saml2Token { get; set; }
#endif
        /// <summary>
        /// Instantiates a new optionalClaims and sets the default values.
        /// </summary>
        public OptionalClaims() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static OptionalClaims CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static OptionalClaims CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OptionalClaims();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accessToken", n => { AccessToken = n.GetCollectionOfObjectValues<OptionalClaim>(OptionalClaim.CreateFromDiscriminatorValue)?.ToList(); } },
                {"idToken", n => { IdToken = n.GetCollectionOfObjectValues<OptionalClaim>(OptionalClaim.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"saml2Token", n => { Saml2Token = n.GetCollectionOfObjectValues<OptionalClaim>(OptionalClaim.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<OptionalClaim>("accessToken", AccessToken);
            writer.WriteCollectionOfObjectValues<OptionalClaim>("idToken", IdToken);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<OptionalClaim>("saml2Token", Saml2Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
