using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AccessPackage : Entity, IParsable {
        public List<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentPolicy> AssignmentPolicies { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public ApiSdk.Models.Microsoft.Graph.AccessPackageCatalog Catalog { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description of the access package.</summary>
        public string Description { get; set; }
        /// <summary>The display name of the access package. Supports $filter (eq, contains).</summary>
        public string DisplayName { get; set; }
        /// <summary>Whether the access package is hidden from the requestor.</summary>
        public bool? IsHidden { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.AccessPackage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignmentPolicies", (o,n) => { (o as AccessPackage).AssignmentPolicies = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentPolicy>(ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"catalog", (o,n) => { (o as AccessPackage).Catalog = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackageCatalog>(ApiSdk.Models.Microsoft.Graph.AccessPackageCatalog.CreateFromDiscriminatorValue); } },
                {"createdDateTime", (o,n) => { (o as AccessPackage).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as AccessPackage).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AccessPackage).DisplayName = n.GetStringValue(); } },
                {"isHidden", (o,n) => { (o as AccessPackage).IsHidden = n.GetBoolValue(); } },
                {"modifiedDateTime", (o,n) => { (o as AccessPackage).ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AccessPackageAssignmentPolicy>("assignmentPolicies", AssignmentPolicies);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AccessPackageCatalog>("catalog", Catalog);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isHidden", IsHidden);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
        }
    }
}
