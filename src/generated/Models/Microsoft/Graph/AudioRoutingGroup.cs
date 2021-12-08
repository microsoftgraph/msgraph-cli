using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AudioRoutingGroup : Entity, IParsable {
        /// <summary>List of receiving participant ids.</summary>
        public List<string> Receivers { get; set; }
        /// <summary>Routing group mode.  Possible values are: oneToOne, multicast.</summary>
        public RoutingMode? RoutingMode { get; set; }
        /// <summary>List of source participant ids.</summary>
        public List<string> Sources { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"receivers", (o,n) => { (o as AudioRoutingGroup).Receivers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"routingMode", (o,n) => { (o as AudioRoutingGroup).RoutingMode = n.GetEnumValue<RoutingMode>(); } },
                {"sources", (o,n) => { (o as AudioRoutingGroup).Sources = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
