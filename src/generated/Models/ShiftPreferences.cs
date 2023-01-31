using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ShiftPreferences : ChangeTrackedEntity, IParsable {
        /// <summary>Availability of the user to be scheduled for work and its recurrence pattern.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ShiftAvailability>? Availability { get; set; }
#nullable restore
#else
        public List<ShiftAvailability> Availability { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ShiftPreferences and sets the default values.
        /// </summary>
        public ShiftPreferences() : base() {
            OdataType = "#microsoft.graph.shiftPreferences";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new ShiftPreferences CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new ShiftPreferences CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ShiftPreferences();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"availability", n => { Availability = n.GetCollectionOfObjectValues<ShiftAvailability>(ShiftAvailability.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ShiftAvailability>("availability", Availability);
        }
    }
}
