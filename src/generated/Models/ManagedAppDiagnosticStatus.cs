using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Represents diagnostics status.</summary>
    public class ManagedAppDiagnosticStatus : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Instruction on how to mitigate a failed validation</summary>
        public string MitigationInstruction { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The state of the operation</summary>
        public string State { get; set; }
        /// <summary>The validation friendly name</summary>
        public string ValidationName { get; set; }
        /// <summary>
        /// Instantiates a new managedAppDiagnosticStatus and sets the default values.
        /// </summary>
        public ManagedAppDiagnosticStatus() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.managedAppDiagnosticStatus";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ManagedAppDiagnosticStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedAppDiagnosticStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"mitigationInstruction", n => { MitigationInstruction = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"state", n => { State = n.GetStringValue(); } },
                {"validationName", n => { ValidationName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("mitigationInstruction", MitigationInstruction);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("validationName", ValidationName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
