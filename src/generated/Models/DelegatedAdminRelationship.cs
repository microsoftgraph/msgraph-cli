using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class DelegatedAdminRelationship : Entity, IParsable {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DelegatedAdminAccessAssignment>? AccessAssignments { get; set; }
#nullable restore
#else
        public List<DelegatedAdminAccessAssignment> AccessAssignments { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DelegatedAdminAccessDetails? AccessDetails { get; set; }
#nullable restore
#else
        public DelegatedAdminAccessDetails AccessDetails { get; set; }
#endif
        public DateTimeOffset? ActivatedDateTime { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DelegatedAdminRelationshipCustomerParticipant? Customer { get; set; }
#nullable restore
#else
        public DelegatedAdminRelationshipCustomerParticipant Customer { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        public TimeSpan? Duration { get; set; }
        public DateTimeOffset? EndDateTime { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DelegatedAdminRelationshipOperation>? Operations { get; set; }
#nullable restore
#else
        public List<DelegatedAdminRelationshipOperation> Operations { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DelegatedAdminRelationshipRequest>? Requests { get; set; }
#nullable restore
#else
        public List<DelegatedAdminRelationshipRequest> Requests { get; set; }
#endif
        public DelegatedAdminRelationshipStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new DelegatedAdminRelationship CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new DelegatedAdminRelationship CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DelegatedAdminRelationship();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessAssignments", n => { AccessAssignments = n.GetCollectionOfObjectValues<DelegatedAdminAccessAssignment>(DelegatedAdminAccessAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"accessDetails", n => { AccessDetails = n.GetObjectValue<DelegatedAdminAccessDetails>(DelegatedAdminAccessDetails.CreateFromDiscriminatorValue); } },
                {"activatedDateTime", n => { ActivatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customer", n => { Customer = n.GetObjectValue<DelegatedAdminRelationshipCustomerParticipant>(DelegatedAdminRelationshipCustomerParticipant.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"duration", n => { Duration = n.GetTimeSpanValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<DelegatedAdminRelationshipOperation>(DelegatedAdminRelationshipOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"requests", n => { Requests = n.GetCollectionOfObjectValues<DelegatedAdminRelationshipRequest>(DelegatedAdminRelationshipRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"status", n => { Status = n.GetEnumValue<DelegatedAdminRelationshipStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DelegatedAdminAccessAssignment>("accessAssignments", AccessAssignments);
            writer.WriteObjectValue<DelegatedAdminAccessDetails>("accessDetails", AccessDetails);
            writer.WriteDateTimeOffsetValue("activatedDateTime", ActivatedDateTime);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<DelegatedAdminRelationshipCustomerParticipant>("customer", Customer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteTimeSpanValue("duration", Duration);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<DelegatedAdminRelationshipOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<DelegatedAdminRelationshipRequest>("requests", Requests);
            writer.WriteEnumValue<DelegatedAdminRelationshipStatus>("status", Status);
        }
    }
}
