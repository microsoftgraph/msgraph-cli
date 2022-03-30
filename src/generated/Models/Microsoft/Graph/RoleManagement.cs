using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class RoleManagement : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public ApiSdk.Models.Microsoft.Graph.RbacApplication Directory { get; set; }
        /// <summary>Container for roles and assignments for entitlement management resources.</summary>
        public ApiSdk.Models.Microsoft.Graph.RbacApplication EntitlementManagement { get; set; }
        /// <summary>
        /// Instantiates a new RoleManagement and sets the default values.
        /// </summary>
        public RoleManagement() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.RoleManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RoleManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"directory", (o,n) => { (o as RoleManagement).Directory = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.RbacApplication>(ApiSdk.Models.Microsoft.Graph.RbacApplication.CreateFromDiscriminatorValue); } },
                {"entitlementManagement", (o,n) => { (o as RoleManagement).EntitlementManagement = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.RbacApplication>(ApiSdk.Models.Microsoft.Graph.RbacApplication.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.RbacApplication>("directory", Directory);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.RbacApplication>("entitlementManagement", EntitlementManagement);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
