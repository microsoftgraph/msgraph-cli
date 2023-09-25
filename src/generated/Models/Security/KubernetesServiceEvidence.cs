// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    public class KubernetesServiceEvidence : AlertEvidence, IParsable {
        /// <summary>The service cluster IP.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IpEvidence? ClusterIP { get; set; }
#nullable restore
#else
        public IpEvidence ClusterIP { get; set; }
#endif
        /// <summary>The service external IPs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IpEvidence>? ExternalIPs { get; set; }
#nullable restore
#else
        public List<IpEvidence> ExternalIPs { get; set; }
#endif
        /// <summary>The service labels.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Dictionary? Labels { get; set; }
#nullable restore
#else
        public Dictionary Labels { get; set; }
#endif
        /// <summary>The service name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The service namespace.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KubernetesNamespaceEvidence? Namespace { get; set; }
#nullable restore
#else
        public KubernetesNamespaceEvidence Namespace { get; set; }
#endif
        /// <summary>The service selector.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Dictionary? Selector { get; set; }
#nullable restore
#else
        public Dictionary Selector { get; set; }
#endif
        /// <summary>The list of service ports.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KubernetesServicePort>? ServicePorts { get; set; }
#nullable restore
#else
        public List<KubernetesServicePort> ServicePorts { get; set; }
#endif
        /// <summary>The serviceType property</summary>
        public KubernetesServiceType? ServiceType { get; set; }
        /// <summary>
        /// Instantiates a new kubernetesServiceEvidence and sets the default values.
        /// </summary>
        public KubernetesServiceEvidence() : base() {
            OdataType = "#microsoft.graph.security.kubernetesServiceEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new KubernetesServiceEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KubernetesServiceEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"clusterIP", n => { ClusterIP = n.GetObjectValue<IpEvidence>(IpEvidence.CreateFromDiscriminatorValue); } },
                {"externalIPs", n => { ExternalIPs = n.GetCollectionOfObjectValues<IpEvidence>(IpEvidence.CreateFromDiscriminatorValue)?.ToList(); } },
                {"labels", n => { Labels = n.GetObjectValue<Dictionary>(Dictionary.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"namespace", n => { Namespace = n.GetObjectValue<KubernetesNamespaceEvidence>(KubernetesNamespaceEvidence.CreateFromDiscriminatorValue); } },
                {"selector", n => { Selector = n.GetObjectValue<Dictionary>(Dictionary.CreateFromDiscriminatorValue); } },
                {"servicePorts", n => { ServicePorts = n.GetCollectionOfObjectValues<KubernetesServicePort>(KubernetesServicePort.CreateFromDiscriminatorValue)?.ToList(); } },
                {"serviceType", n => { ServiceType = n.GetEnumValue<KubernetesServiceType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IpEvidence>("clusterIP", ClusterIP);
            writer.WriteCollectionOfObjectValues<IpEvidence>("externalIPs", ExternalIPs);
            writer.WriteObjectValue<Dictionary>("labels", Labels);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<KubernetesNamespaceEvidence>("namespace", Namespace);
            writer.WriteObjectValue<Dictionary>("selector", Selector);
            writer.WriteCollectionOfObjectValues<KubernetesServicePort>("servicePorts", ServicePorts);
            writer.WriteEnumValue<KubernetesServiceType>("serviceType", ServiceType);
        }
    }
}