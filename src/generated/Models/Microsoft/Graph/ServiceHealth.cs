using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ServiceHealth : Entity, IParsable {
        /// <summary>A collection of issues happened on the service, with detailed information for each issue.</summary>
        public List<ServiceHealthIssue> Issues { get; set; }
        /// <summary>The service name. Use the list healthOverviews operation to get exact string names for services subscribed by the tenant.</summary>
        public string Service { get; set; }
        /// <summary>Show the overral service health status. Possible values are: serviceOperational, investigating, restoringService, verifyingService, serviceRestored, postIncidentReviewPublished, serviceDegradation, serviceInterruption, extendedRecovery, falsePositive, investigationSuspended, resolved, mitigatedExternal, mitigated, resolvedExternal, confirmed, reported, unknownFutureValue.</summary>
        public ServiceHealthStatus? Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"issues", (o,n) => { (o as ServiceHealth).Issues = n.GetCollectionOfObjectValues<ServiceHealthIssue>().ToList(); } },
                {"service", (o,n) => { (o as ServiceHealth).Service = n.GetStringValue(); } },
                {"status", (o,n) => { (o as ServiceHealth).Status = n.GetEnumValue<ServiceHealthStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ServiceHealthIssue>("issues", Issues);
            writer.WriteStringValue("service", Service);
            writer.WriteEnumValue<ServiceHealthStatus>("status", Status);
        }
    }
}
