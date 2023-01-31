using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class PersistentBrowserSessionControl : ConditionalAccessSessionControl, IParsable {
        /// <summary>Possible values are: always, never.</summary>
        public PersistentBrowserSessionMode? Mode { get; set; }
        /// <summary>
        /// Instantiates a new PersistentBrowserSessionControl and sets the default values.
        /// </summary>
        public PersistentBrowserSessionControl() : base() {
            OdataType = "#microsoft.graph.persistentBrowserSessionControl";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new PersistentBrowserSessionControl CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new PersistentBrowserSessionControl CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PersistentBrowserSessionControl();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"mode", n => { Mode = n.GetEnumValue<PersistentBrowserSessionMode>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<PersistentBrowserSessionMode>("mode", Mode);
        }
    }
}
