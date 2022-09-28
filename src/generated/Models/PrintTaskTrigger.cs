using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class PrintTaskTrigger : Entity, IParsable {
        /// <summary>The definition property</summary>
        public PrintTaskDefinition Definition { get; set; }
        /// <summary>The event property</summary>
        public PrintEvent? Event { get; set; }
        /// <summary>
        /// Instantiates a new printTaskTrigger and sets the default values.
        /// </summary>
        public PrintTaskTrigger() : base() {
            OdataType = "#microsoft.graph.printTaskTrigger";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrintTaskTrigger CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrintTaskTrigger();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"definition", n => { Definition = n.GetObjectValue<PrintTaskDefinition>(PrintTaskDefinition.CreateFromDiscriminatorValue); } },
                {"event", n => { Event = n.GetEnumValue<PrintEvent>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PrintTaskDefinition>("definition", Definition);
            writer.WriteEnumValue<PrintEvent>("event", Event);
        }
    }
}
