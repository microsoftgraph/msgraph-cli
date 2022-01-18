using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ThreatAssessmentRequest : Entity, IParsable {
        /// <summary>The threat category. Possible values are: spam, phishing, malware.</summary>
        public ThreatCategory? Category { get; set; }
        /// <summary>The content type of threat assessment. Possible values are: mail, url, file.</summary>
        public ThreatAssessmentContentType? ContentType { get; set; }
        /// <summary>The threat assessment request creator.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The expected assessment from submitter. Possible values are: block, unblock.</summary>
        public ThreatExpectedAssessment? ExpectedAssessment { get; set; }
        /// <summary>The source of the threat assessment request. Possible values are: user, administrator.</summary>
        public ThreatAssessmentRequestSource? RequestSource { get; set; }
        /// <summary>A collection of threat assessment results. Read-only. By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.</summary>
        public List<ThreatAssessmentResult> Results { get; set; }
        /// <summary>The assessment process status. Possible values are: pending, completed.</summary>
        public ThreatAssessmentStatus? Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"category", (o,n) => { (o as ThreatAssessmentRequest).Category = n.GetEnumValue<ThreatCategory>(); } },
                {"contentType", (o,n) => { (o as ThreatAssessmentRequest).ContentType = n.GetEnumValue<ThreatAssessmentContentType>(); } },
                {"createdBy", (o,n) => { (o as ThreatAssessmentRequest).CreatedBy = n.GetObjectValue<IdentitySet>(); } },
                {"createdDateTime", (o,n) => { (o as ThreatAssessmentRequest).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"expectedAssessment", (o,n) => { (o as ThreatAssessmentRequest).ExpectedAssessment = n.GetEnumValue<ThreatExpectedAssessment>(); } },
                {"requestSource", (o,n) => { (o as ThreatAssessmentRequest).RequestSource = n.GetEnumValue<ThreatAssessmentRequestSource>(); } },
                {"results", (o,n) => { (o as ThreatAssessmentRequest).Results = n.GetCollectionOfObjectValues<ThreatAssessmentResult>().ToList(); } },
                {"status", (o,n) => { (o as ThreatAssessmentRequest).Status = n.GetEnumValue<ThreatAssessmentStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ThreatCategory>("category", Category);
            writer.WriteEnumValue<ThreatAssessmentContentType>("contentType", ContentType);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteEnumValue<ThreatExpectedAssessment>("expectedAssessment", ExpectedAssessment);
            writer.WriteEnumValue<ThreatAssessmentRequestSource>("requestSource", RequestSource);
            writer.WriteCollectionOfObjectValues<ThreatAssessmentResult>("results", Results);
            writer.WriteEnumValue<ThreatAssessmentStatus>("status", Status);
        }
    }
}
