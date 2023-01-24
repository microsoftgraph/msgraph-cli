using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>
    /// Configuration used to deliver a set of custom settings as-is to apps for users to whom the configuration is scoped
    /// </summary>
    public class ManagedAppConfiguration : ManagedAppPolicy, IParsable {
        /// <summary>A set of string key and string value pairs to be sent to apps for users to whom the configuration is scoped, unalterned by this service</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? CustomSettings { get; set; }
#nullable restore
#else
        public List<KeyValuePair> CustomSettings { get; set; }
#endif
        /// <summary>
        /// Instantiates a new managedAppConfiguration and sets the default values.
        /// </summary>
        public ManagedAppConfiguration() : base() {
            OdataType = "#microsoft.graph.managedAppConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedAppConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.targetedManagedAppConfiguration" => new TargetedManagedAppConfiguration(),
                _ => new ManagedAppConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"customSettings", n => { CustomSettings = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("customSettings", CustomSettings);
        }
    }
}
