using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Fido2AuthenticationMethod : AuthenticationMethod, IParsable {
        /// <summary>Authenticator Attestation GUID, an identifier that indicates the type (e.g. make and model) of the authenticator.</summary>
        public string AaGuid { get; set; }
        /// <summary>The attestation certificate(s) attached to this security key.</summary>
        public List<string> AttestationCertificates { get; set; }
        /// <summary>The attestation level of this FIDO2 security key. Possible values are: attested, notAttested, unknownFutureValue.</summary>
        public AttestationLevel? AttestationLevel { get; set; }
        /// <summary>The timestamp when this key was registered to the user.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The display name of the key as given by the user.</summary>
        public string DisplayName { get; set; }
        /// <summary>The manufacturer-assigned model of the FIDO2 security key.</summary>
        public string Model { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"aaGuid", (o,n) => { (o as Fido2AuthenticationMethod).AaGuid = n.GetStringValue(); } },
                {"attestationCertificates", (o,n) => { (o as Fido2AuthenticationMethod).AttestationCertificates = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"attestationLevel", (o,n) => { (o as Fido2AuthenticationMethod).AttestationLevel = n.GetEnumValue<AttestationLevel>(); } },
                {"createdDateTime", (o,n) => { (o as Fido2AuthenticationMethod).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as Fido2AuthenticationMethod).DisplayName = n.GetStringValue(); } },
                {"model", (o,n) => { (o as Fido2AuthenticationMethod).Model = n.GetStringValue(); } },
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
