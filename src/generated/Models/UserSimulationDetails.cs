using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class UserSimulationDetails : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of trainings assigned to a user in an attack simulation and training campaign.</summary>
        public int? AssignedTrainingsCount { get; set; }
        /// <summary>Number of trainings completed by a user in an attack simulation and training campaign.</summary>
        public int? CompletedTrainingsCount { get; set; }
        /// <summary>Date and time of the compromising online action by a user in an attack simulation and training campaign.</summary>
        public DateTimeOffset? CompromisedDateTime { get; set; }
        /// <summary>Number of trainings in progress by a user in an attack simulation and training campaign.</summary>
        public int? InProgressTrainingsCount { get; set; }
        /// <summary>Indicates whether a user was compromised in an attack simulation and training campaign.</summary>
        public bool? IsCompromised { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Date and time when a user reported the delivered payload as phishing in the attack simulation and training campaign.</summary>
        public DateTimeOffset? ReportedPhishDateTime { get; set; }
        /// <summary>List of simulation events of a user in the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserSimulationEventInfo>? SimulationEvents { get; set; }
#nullable restore
#else
        public List<UserSimulationEventInfo> SimulationEvents { get; set; }
#endif
        /// <summary>User in an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AttackSimulationUser? SimulationUser { get; set; }
#nullable restore
#else
        public AttackSimulationUser SimulationUser { get; set; }
#endif
        /// <summary>List of training events of a user in the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserTrainingEventInfo>? TrainingEvents { get; set; }
#nullable restore
#else
        public List<UserTrainingEventInfo> TrainingEvents { get; set; }
#endif
        /// <summary>
        /// Instantiates a new userSimulationDetails and sets the default values.
        /// </summary>
        public UserSimulationDetails() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserSimulationDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserSimulationDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignedTrainingsCount", n => { AssignedTrainingsCount = n.GetIntValue(); } },
                {"completedTrainingsCount", n => { CompletedTrainingsCount = n.GetIntValue(); } },
                {"compromisedDateTime", n => { CompromisedDateTime = n.GetDateTimeOffsetValue(); } },
                {"inProgressTrainingsCount", n => { InProgressTrainingsCount = n.GetIntValue(); } },
                {"isCompromised", n => { IsCompromised = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"reportedPhishDateTime", n => { ReportedPhishDateTime = n.GetDateTimeOffsetValue(); } },
                {"simulationEvents", n => { SimulationEvents = n.GetCollectionOfObjectValues<UserSimulationEventInfo>(UserSimulationEventInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"simulationUser", n => { SimulationUser = n.GetObjectValue<AttackSimulationUser>(AttackSimulationUser.CreateFromDiscriminatorValue); } },
                {"trainingEvents", n => { TrainingEvents = n.GetCollectionOfObjectValues<UserTrainingEventInfo>(UserTrainingEventInfo.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("assignedTrainingsCount", AssignedTrainingsCount);
            writer.WriteIntValue("completedTrainingsCount", CompletedTrainingsCount);
            writer.WriteDateTimeOffsetValue("compromisedDateTime", CompromisedDateTime);
            writer.WriteIntValue("inProgressTrainingsCount", InProgressTrainingsCount);
            writer.WriteBoolValue("isCompromised", IsCompromised);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("reportedPhishDateTime", ReportedPhishDateTime);
            writer.WriteCollectionOfObjectValues<UserSimulationEventInfo>("simulationEvents", SimulationEvents);
            writer.WriteObjectValue<AttackSimulationUser>("simulationUser", SimulationUser);
            writer.WriteCollectionOfObjectValues<UserTrainingEventInfo>("trainingEvents", TrainingEvents);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
