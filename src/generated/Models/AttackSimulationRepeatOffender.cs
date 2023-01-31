using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AttackSimulationRepeatOffender : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The user in an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.AttackSimulationUser? AttackSimulationUser { get; set; }
#nullable restore
#else
        public ApiSdk.Models.AttackSimulationUser AttackSimulationUser { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Number of repeat offences of the user in attack simulation and training campaigns.</summary>
        public int? RepeatOffenceCount { get; set; }
        /// <summary>
        /// Instantiates a new attackSimulationRepeatOffender and sets the default values.
        /// </summary>
        public AttackSimulationRepeatOffender() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static AttackSimulationRepeatOffender CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static AttackSimulationRepeatOffender CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttackSimulationRepeatOffender();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attackSimulationUser", n => { AttackSimulationUser = n.GetObjectValue<ApiSdk.Models.AttackSimulationUser>(ApiSdk.Models.AttackSimulationUser.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"repeatOffenceCount", n => { RepeatOffenceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.AttackSimulationUser>("attackSimulationUser", AttackSimulationUser);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("repeatOffenceCount", RepeatOffenceCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
