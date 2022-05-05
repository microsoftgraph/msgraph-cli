using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class PlannerPlanContainer : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The identifier of the resource that contains the plan.</summary>
        public string ContainerId { get; set; }
        /// <summary>The type of the resource that contains the plan. See the previous table for supported types. Possible values are: group, unknownFutureValue, roster. Note that you must use the Prefer: include-unknown-enum-members request header to get the following value in this evolvable enum: roster.</summary>
        public PlannerContainerType? Type { get; set; }
        /// <summary>The full canonical URL of the container.</summary>
        public string Url { get; set; }
        /// <summary>
        /// Instantiates a new plannerPlanContainer and sets the default values.
        /// </summary>
        public PlannerPlanContainer() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PlannerPlanContainer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerPlanContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"containerId", n => { ContainerId = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<PlannerContainerType>(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("containerId", ContainerId);
            writer.WriteEnumValue<PlannerContainerType>("type", Type);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
