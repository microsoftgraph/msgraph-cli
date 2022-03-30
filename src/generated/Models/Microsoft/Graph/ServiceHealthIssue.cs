using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ServiceHealthIssue : ServiceAnnouncementBase, IParsable {
        /// <summary>The type of service health issue. Possible values are: advisory, incident, unknownFutureValue.</summary>
        public ServiceHealthClassificationType? Classification { get; set; }
        /// <summary>The feature name of the service issue.</summary>
        public string Feature { get; set; }
        /// <summary>The feature group name of the service issue.</summary>
        public string FeatureGroup { get; set; }
        /// <summary>The description of the service issue impact.</summary>
        public string ImpactDescription { get; set; }
        /// <summary>Indicates whether the issue is resolved.</summary>
        public bool? IsResolved { get; set; }
        /// <summary>Indicates the origin of the service issue. Possible values are: microsoft, thirdParty, customer, unknownFutureValue.</summary>
        public ServiceHealthOrigin? Origin { get; set; }
        /// <summary>Collection of historical posts for the service issue.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ServiceHealthIssuePost> Posts { get; set; }
        /// <summary>Indicates the service affected by the issue.</summary>
        public string Service { get; set; }
        /// <summary>The status of the service issue. Possible values are: serviceOperational, investigating, restoringService, verifyingService, serviceRestored, postIncidentReviewPublished, serviceDegradation, serviceInterruption, extendedRecovery, falsePositive, investigationSuspended, resolved, mitigatedExternal, mitigated, resolvedExternal, confirmed, reported, unknownFutureValue. See more in the table below.</summary>
        public ServiceHealthStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.ServiceHealthIssue CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServiceHealthIssue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"classification", (o,n) => { (o as ServiceHealthIssue).Classification = n.GetEnumValue<ServiceHealthClassificationType>(); } },
                {"feature", (o,n) => { (o as ServiceHealthIssue).Feature = n.GetStringValue(); } },
                {"featureGroup", (o,n) => { (o as ServiceHealthIssue).FeatureGroup = n.GetStringValue(); } },
                {"impactDescription", (o,n) => { (o as ServiceHealthIssue).ImpactDescription = n.GetStringValue(); } },
                {"isResolved", (o,n) => { (o as ServiceHealthIssue).IsResolved = n.GetBoolValue(); } },
                {"origin", (o,n) => { (o as ServiceHealthIssue).Origin = n.GetEnumValue<ServiceHealthOrigin>(); } },
                {"posts", (o,n) => { (o as ServiceHealthIssue).Posts = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ServiceHealthIssuePost>(ApiSdk.Models.Microsoft.Graph.ServiceHealthIssuePost.CreateFromDiscriminatorValue).ToList(); } },
                {"service", (o,n) => { (o as ServiceHealthIssue).Service = n.GetStringValue(); } },
                {"status", (o,n) => { (o as ServiceHealthIssue).Status = n.GetEnumValue<ServiceHealthStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ServiceHealthClassificationType>("classification", Classification);
            writer.WriteStringValue("feature", Feature);
            writer.WriteStringValue("featureGroup", FeatureGroup);
            writer.WriteStringValue("impactDescription", ImpactDescription);
            writer.WriteBoolValue("isResolved", IsResolved);
            writer.WriteEnumValue<ServiceHealthOrigin>("origin", Origin);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ServiceHealthIssuePost>("posts", Posts);
            writer.WriteStringValue("service", Service);
            writer.WriteEnumValue<ServiceHealthStatus>("status", Status);
        }
    }
}
