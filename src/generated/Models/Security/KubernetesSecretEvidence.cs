// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class KubernetesSecretEvidence : global::ApiSdk.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The secret name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The secret namespace.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Security.KubernetesNamespaceEvidence? Namespace { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Security.KubernetesNamespaceEvidence Namespace { get; set; }
#endif
        /// <summary>The secret type can include both built-in types and custom ones. Examples of built-in types are: Opaque, kubernetes.io/service-account-token, kubernetes.io/dockercfg, kubernetes.io/dockerconfigjson, kubernetes.io/basic-auth, kubernetes.io/ssh-auth, kubernetes.io/tls, bootstrap.kubernetes.io/token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecretType { get; set; }
#nullable restore
#else
        public string SecretType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Security.KubernetesSecretEvidence"/> and sets the default values.
        /// </summary>
        public KubernetesSecretEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.kubernetesSecretEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Security.KubernetesSecretEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Security.KubernetesSecretEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Security.KubernetesSecretEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "name", n => { Name = n.GetStringValue(); } },
                { "namespace", n => { Namespace = n.GetObjectValue<global::ApiSdk.Models.Security.KubernetesNamespaceEvidence>(global::ApiSdk.Models.Security.KubernetesNamespaceEvidence.CreateFromDiscriminatorValue); } },
                { "secretType", n => { SecretType = n.GetStringValue(); } },
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
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::ApiSdk.Models.Security.KubernetesNamespaceEvidence>("namespace", Namespace);
            writer.WriteStringValue("secretType", SecretType);
        }
    }
}
#pragma warning restore CS0618
