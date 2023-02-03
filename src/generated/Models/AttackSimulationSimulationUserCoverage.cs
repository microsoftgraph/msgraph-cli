using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AttackSimulationSimulationUserCoverage : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>User in an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.AttackSimulationUser? AttackSimulationUser { get; set; }
#nullable restore
#else
        public ApiSdk.Models.AttackSimulationUser AttackSimulationUser { get; set; }
#endif
        /// <summary>Number of link clicks in the received payloads by the user in attack simulation and training campaigns.</summary>
        public int? ClickCount { get; set; }
        /// <summary>Number of compromising actions by the user in attack simulation and training campaigns.</summary>
        public int? CompromisedCount { get; set; }
        /// <summary>Date and time of the latest attack simulation and training campaign that the user was included in.</summary>
        public DateTimeOffset? LatestSimulationDateTime { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Number of attack simulation and training campaigns that the user was included in.</summary>
        public int? SimulationCount { get; set; }
        /// <summary>
        /// Instantiates a new attackSimulationSimulationUserCoverage and sets the default values.
        /// </summary>
        public AttackSimulationSimulationUserCoverage() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AttackSimulationSimulationUserCoverage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttackSimulationSimulationUserCoverage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attackSimulationUser", n => { AttackSimulationUser = n.GetObjectValue<ApiSdk.Models.AttackSimulationUser>(ApiSdk.Models.AttackSimulationUser.CreateFromDiscriminatorValue); } },
                {"clickCount", n => { ClickCount = n.GetIntValue(); } },
                {"compromisedCount", n => { CompromisedCount = n.GetIntValue(); } },
                {"latestSimulationDateTime", n => { LatestSimulationDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"simulationCount", n => { SimulationCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.AttackSimulationUser>("attackSimulationUser", AttackSimulationUser);
            writer.WriteIntValue("clickCount", ClickCount);
            writer.WriteIntValue("compromisedCount", CompromisedCount);
            writer.WriteDateTimeOffsetValue("latestSimulationDateTime", LatestSimulationDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("simulationCount", SimulationCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
