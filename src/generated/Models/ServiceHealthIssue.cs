using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class ServiceHealthIssue : ServiceAnnouncementBase, IParsable {
        /// <summary>The classification property</summary>
        public ServiceHealthClassificationType? Classification { get; set; }
        /// <summary>The feature name of the service issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Feature { get; set; }
#nullable restore
#else
        public string Feature { get; set; }
#endif
        /// <summary>The feature group name of the service issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FeatureGroup { get; set; }
#nullable restore
#else
        public string FeatureGroup { get; set; }
#endif
        /// <summary>The description of the service issue impact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImpactDescription { get; set; }
#nullable restore
#else
        public string ImpactDescription { get; set; }
#endif
        /// <summary>Indicates whether the issue is resolved.</summary>
        public bool? IsResolved { get; set; }
        /// <summary>The origin property</summary>
        public ServiceHealthOrigin? Origin { get; set; }
        /// <summary>Collection of historical posts for the service issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ServiceHealthIssuePost>? Posts { get; set; }
#nullable restore
#else
        public List<ServiceHealthIssuePost> Posts { get; set; }
#endif
        /// <summary>Indicates the service affected by the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Service { get; set; }
#nullable restore
#else
        public string Service { get; set; }
#endif
        /// <summary>The status property</summary>
        public ServiceHealthStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new ServiceHealthIssue and sets the default values.
        /// </summary>
        public ServiceHealthIssue() : base() {
            OdataType = "#microsoft.graph.serviceHealthIssue";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ServiceHealthIssue CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServiceHealthIssue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"classification", n => { Classification = n.GetEnumValue<ServiceHealthClassificationType>(); } },
                {"feature", n => { Feature = n.GetStringValue(); } },
                {"featureGroup", n => { FeatureGroup = n.GetStringValue(); } },
                {"impactDescription", n => { ImpactDescription = n.GetStringValue(); } },
                {"isResolved", n => { IsResolved = n.GetBoolValue(); } },
                {"origin", n => { Origin = n.GetEnumValue<ServiceHealthOrigin>(); } },
                {"posts", n => { Posts = n.GetCollectionOfObjectValues<ServiceHealthIssuePost>(ServiceHealthIssuePost.CreateFromDiscriminatorValue)?.ToList(); } },
                {"service", n => { Service = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<ServiceHealthStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ServiceHealthClassificationType>("classification", Classification);
            writer.WriteStringValue("feature", Feature);
            writer.WriteStringValue("featureGroup", FeatureGroup);
            writer.WriteStringValue("impactDescription", ImpactDescription);
            writer.WriteBoolValue("isResolved", IsResolved);
            writer.WriteEnumValue<ServiceHealthOrigin>("origin", Origin);
            writer.WriteCollectionOfObjectValues<ServiceHealthIssuePost>("posts", Posts);
            writer.WriteStringValue("service", Service);
            writer.WriteEnumValue<ServiceHealthStatus>("status", Status);
        }
    }
}
