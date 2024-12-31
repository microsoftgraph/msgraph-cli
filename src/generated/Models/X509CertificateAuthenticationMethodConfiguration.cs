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
    public partial class X509CertificateAuthenticationMethodConfiguration : global::ApiSdk.Models.AuthenticationMethodConfiguration, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Defines strong authentication configurations. This configuration includes the default authentication mode and the different rules for strong authentication bindings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.X509CertificateAuthenticationModeConfiguration? AuthenticationModeConfiguration { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.X509CertificateAuthenticationModeConfiguration AuthenticationModeConfiguration { get; set; }
#endif
        /// <summary>Defines fields in the X.509 certificate that map to attributes of the Microsoft Entra user object in order to bind the certificate to the user. The priority of the object determines the order in which the binding is carried out. The first binding that matches will be used and the rest ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.X509CertificateUserBinding>? CertificateUserBindings { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.X509CertificateUserBinding> CertificateUserBindings { get; set; }
#endif
        /// <summary>The crlValidationConfiguration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.X509CertificateCRLValidationConfiguration? CrlValidationConfiguration { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.X509CertificateCRLValidationConfiguration CrlValidationConfiguration { get; set; }
#endif
        /// <summary>A collection of groups that are enabled to use the authentication method.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AuthenticationMethodTarget>? IncludeTargets { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AuthenticationMethodTarget> IncludeTargets { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.X509CertificateAuthenticationMethodConfiguration"/> and sets the default values.
        /// </summary>
        public X509CertificateAuthenticationMethodConfiguration() : base()
        {
            OdataType = "#microsoft.graph.x509CertificateAuthenticationMethodConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.X509CertificateAuthenticationMethodConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.X509CertificateAuthenticationMethodConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.X509CertificateAuthenticationMethodConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "authenticationModeConfiguration", n => { AuthenticationModeConfiguration = n.GetObjectValue<global::ApiSdk.Models.X509CertificateAuthenticationModeConfiguration>(global::ApiSdk.Models.X509CertificateAuthenticationModeConfiguration.CreateFromDiscriminatorValue); } },
                { "certificateUserBindings", n => { CertificateUserBindings = n.GetCollectionOfObjectValues<global::ApiSdk.Models.X509CertificateUserBinding>(global::ApiSdk.Models.X509CertificateUserBinding.CreateFromDiscriminatorValue)?.AsList(); } },
                { "crlValidationConfiguration", n => { CrlValidationConfiguration = n.GetObjectValue<global::ApiSdk.Models.X509CertificateCRLValidationConfiguration>(global::ApiSdk.Models.X509CertificateCRLValidationConfiguration.CreateFromDiscriminatorValue); } },
                { "includeTargets", n => { IncludeTargets = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AuthenticationMethodTarget>(global::ApiSdk.Models.AuthenticationMethodTarget.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.X509CertificateAuthenticationModeConfiguration>("authenticationModeConfiguration", AuthenticationModeConfiguration);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.X509CertificateUserBinding>("certificateUserBindings", CertificateUserBindings);
            writer.WriteObjectValue<global::ApiSdk.Models.X509CertificateCRLValidationConfiguration>("crlValidationConfiguration", CrlValidationConfiguration);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AuthenticationMethodTarget>("includeTargets", IncludeTargets);
        }
    }
}
#pragma warning restore CS0618
