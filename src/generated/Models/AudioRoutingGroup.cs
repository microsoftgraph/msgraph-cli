using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AudioRoutingGroup : Entity, IParsable {
        /// <summary>List of receiving participant ids.</summary>
        public List<string> Receivers { get; set; }
        /// <summary>Routing group mode.  Possible values are: oneToOne, multicast.</summary>
        public ApiSdk.Models.RoutingMode? RoutingMode { get; set; }
        /// <summary>List of source participant ids.</summary>
        public List<string> Sources { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AudioRoutingGroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AudioRoutingGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"receivers", n => { Receivers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"routingMode", n => { RoutingMode = n.GetEnumValue<RoutingMode>(); } },
                {"sources", n => { Sources = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("receivers", Receivers);
            writer.WriteEnumValue<RoutingMode>("routingMode", RoutingMode);
            writer.WriteCollectionOfPrimitiveValues<string>("sources", Sources);
        }
    }
}
