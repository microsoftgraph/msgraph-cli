using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Identity.B2xUserFlows.Item.UserAttributeAssignments.SetOrder {
    /// <summary>Provides operations to call the setOrder method.</summary>
    public class SetOrderRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public AssignmentOrder NewAssignmentOrder { get; set; }
        /// <summary>
        /// Instantiates a new setOrderRequestBody and sets the default values.
        /// </summary>
        public SetOrderRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Identity.B2xUserFlows.Item.UserAttributeAssignments.SetOrder.SetOrderRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SetOrderRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"newAssignmentOrder", (o,n) => { (o as SetOrderRequestBody).NewAssignmentOrder = n.GetObjectValue<AssignmentOrder>(AssignmentOrder.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AssignmentOrder>("newAssignmentOrder", NewAssignmentOrder);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
