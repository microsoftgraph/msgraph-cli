using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Fido2AuthenticationMethod : AuthenticationMethod, IParsable {
        /// <summary>Authenticator Attestation GUID, an identifier that indicates the type (e.g. make and model) of the authenticator.</summary>
        public string AaGuid { get; set; }
        /// <summary>The attestation certificate(s) attached to this security key.</summary>
        public List<string> AttestationCertificates { get; set; }
        /// <summary>The attestation level of this FIDO2 security key. Possible values are: attested, or notAttested.</summary>
        public ApiSdk.Models.AttestationLevel? AttestationLevel { get; set; }
        /// <summary>The timestamp when this key was registered to the user.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The display name of the key as given by the user.</summary>
        public string DisplayName { get; set; }
        /// <summary>The manufacturer-assigned model of the FIDO2 security key.</summary>
        public string Model { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Fido2AuthenticationMethod CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Fido2AuthenticationMethod();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"aaGuid", n => { AaGuid = n.GetStringValue(); } },
                {"attestationCertificates", n => { AttestationCertificates = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"attestationLevel", n => { AttestationLevel = n.GetEnumValue<AttestationLevel>(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("aaGuid", AaGuid);
            writer.WriteCollectionOfPrimitiveValues<string>("attestationCertificates", AttestationCertificates);
            writer.WriteEnumValue<AttestationLevel>("attestationLevel", AttestationLevel);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("model", Model);
        }
    }
}
