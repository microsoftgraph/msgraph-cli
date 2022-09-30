using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class X509CertificateAuthenticationMethodConfiguration : AuthenticationMethodConfiguration, IParsable {
        /// <summary>The authenticationModeConfiguration property</summary>
        public X509CertificateAuthenticationModeConfiguration AuthenticationModeConfiguration { get; set; }
        /// <summary>The certificateUserBindings property</summary>
        public List<X509CertificateUserBinding> CertificateUserBindings { get; set; }
        /// <summary>The includeTargets property</summary>
        public List<AuthenticationMethodTarget> IncludeTargets { get; set; }
        /// <summary>
        /// Instantiates a new X509CertificateAuthenticationMethodConfiguration and sets the default values.
        /// </summary>
        public X509CertificateAuthenticationMethodConfiguration() : base() {
            OdataType = "#microsoft.graph.x509CertificateAuthenticationMethodConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new X509CertificateAuthenticationMethodConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new X509CertificateAuthenticationMethodConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationModeConfiguration", n => { AuthenticationModeConfiguration = n.GetObjectValue<X509CertificateAuthenticationModeConfiguration>(X509CertificateAuthenticationModeConfiguration.CreateFromDiscriminatorValue); } },
                {"certificateUserBindings", n => { CertificateUserBindings = n.GetCollectionOfObjectValues<X509CertificateUserBinding>(X509CertificateUserBinding.CreateFromDiscriminatorValue)?.ToList(); } },
                {"includeTargets", n => { IncludeTargets = n.GetCollectionOfObjectValues<AuthenticationMethodTarget>(AuthenticationMethodTarget.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<X509CertificateAuthenticationModeConfiguration>("authenticationModeConfiguration", AuthenticationModeConfiguration);
            writer.WriteCollectionOfObjectValues<X509CertificateUserBinding>("certificateUserBindings", CertificateUserBindings);
            writer.WriteCollectionOfObjectValues<AuthenticationMethodTarget>("includeTargets", IncludeTargets);
        }
    }
}
