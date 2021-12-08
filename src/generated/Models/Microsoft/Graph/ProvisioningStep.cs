using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ProvisioningStep : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Summary of what occurred during the step.</summary>
        public string Description { get; set; }
        /// <summary>Details of what occurred during the step.</summary>
        public DetailsInfo Details { get; set; }
        /// <summary>Name of the step.</summary>
        public string Name { get; set; }
        /// <summary>Type of step. Possible values are: import, scoping, matching, processing, referenceResolution, export, unknownFutureValue.</summary>
        public ProvisioningStepType? ProvisioningStepType { get; set; }
        /// <summary>Status of the step. Possible values are: success, warning,  failure, skipped, unknownFutureValue.</summary>
        public ProvisioningResult? Status { get; set; }
        /// <summary>
        /// Instantiates a new provisioningStep and sets the default values.
        /// </summary>
        public ProvisioningStep() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"description", (o,n) => { (o as ProvisioningStep).Description = n.GetStringValue(); } },
                {"details", (o,n) => { (o as ProvisioningStep).Details = n.GetObjectValue<DetailsInfo>(); } },
                {"name", (o,n) => { (o as ProvisioningStep).Name = n.GetStringValue(); } },
                {"provisioningStepType", (o,n) => { (o as ProvisioningStep).ProvisioningStepType = n.GetEnumValue<ProvisioningStepType>(); } },
                {"status", (o,n) => { (o as ProvisioningStep).Status = n.GetEnumValue<ProvisioningResult>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<DetailsInfo>("details", Details);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<ProvisioningStepType>("provisioningStepType", ProvisioningStepType);
            writer.WriteEnumValue<ProvisioningResult>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
