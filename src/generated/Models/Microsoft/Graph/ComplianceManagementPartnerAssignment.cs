using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>User group targeting for Compliance Management Partner</summary>
    public class ComplianceManagementPartnerAssignment : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Group assignment target.</summary>
        public ApiSdk.Models.Microsoft.Graph.DeviceAndAppManagementAssignmentTarget Target { get; set; }
        /// <summary>
        /// Instantiates a new complianceManagementPartnerAssignment and sets the default values.
        /// </summary>
        public ComplianceManagementPartnerAssignment() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.ComplianceManagementPartnerAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ComplianceManagementPartnerAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"target", (o,n) => { (o as ComplianceManagementPartnerAssignment).Target = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceAndAppManagementAssignmentTarget>(ApiSdk.Models.Microsoft.Graph.DeviceAndAppManagementAssignmentTarget.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DeviceAndAppManagementAssignmentTarget>("target", Target);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
