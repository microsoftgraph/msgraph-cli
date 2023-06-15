using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class SynchronizationStatus : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The code property</summary>
        public SynchronizationStatusCode? Code { get; set; }
        /// <summary>The countSuccessiveCompleteFailures property</summary>
        public long? CountSuccessiveCompleteFailures { get; set; }
        /// <summary>The escrowsPruned property</summary>
        public bool? EscrowsPruned { get; set; }
        /// <summary>The lastExecution property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SynchronizationTaskExecution? LastExecution { get; set; }
#nullable restore
#else
        public SynchronizationTaskExecution LastExecution { get; set; }
#endif
        /// <summary>The lastSuccessfulExecution property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SynchronizationTaskExecution? LastSuccessfulExecution { get; set; }
#nullable restore
#else
        public SynchronizationTaskExecution LastSuccessfulExecution { get; set; }
#endif
        /// <summary>The lastSuccessfulExecutionWithExports property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SynchronizationTaskExecution? LastSuccessfulExecutionWithExports { get; set; }
#nullable restore
#else
        public SynchronizationTaskExecution LastSuccessfulExecutionWithExports { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The progress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SynchronizationProgress>? Progress { get; set; }
#nullable restore
#else
        public List<SynchronizationProgress> Progress { get; set; }
#endif
        /// <summary>The quarantine property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SynchronizationQuarantine? Quarantine { get; set; }
#nullable restore
#else
        public SynchronizationQuarantine Quarantine { get; set; }
#endif
        /// <summary>The steadyStateFirstAchievedTime property</summary>
        public DateTimeOffset? SteadyStateFirstAchievedTime { get; set; }
        /// <summary>The steadyStateLastAchievedTime property</summary>
        public DateTimeOffset? SteadyStateLastAchievedTime { get; set; }
        /// <summary>The synchronizedEntryCountByType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<StringKeyLongValuePair>? SynchronizedEntryCountByType { get; set; }
#nullable restore
#else
        public List<StringKeyLongValuePair> SynchronizedEntryCountByType { get; set; }
#endif
        /// <summary>The troubleshootingUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TroubleshootingUrl { get; set; }
#nullable restore
#else
        public string TroubleshootingUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new synchronizationStatus and sets the default values.
        /// </summary>
        public SynchronizationStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SynchronizationStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"code", n => { Code = n.GetEnumValue<SynchronizationStatusCode>(); } },
                {"countSuccessiveCompleteFailures", n => { CountSuccessiveCompleteFailures = n.GetLongValue(); } },
                {"escrowsPruned", n => { EscrowsPruned = n.GetBoolValue(); } },
                {"lastExecution", n => { LastExecution = n.GetObjectValue<SynchronizationTaskExecution>(SynchronizationTaskExecution.CreateFromDiscriminatorValue); } },
                {"lastSuccessfulExecution", n => { LastSuccessfulExecution = n.GetObjectValue<SynchronizationTaskExecution>(SynchronizationTaskExecution.CreateFromDiscriminatorValue); } },
                {"lastSuccessfulExecutionWithExports", n => { LastSuccessfulExecutionWithExports = n.GetObjectValue<SynchronizationTaskExecution>(SynchronizationTaskExecution.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"progress", n => { Progress = n.GetCollectionOfObjectValues<SynchronizationProgress>(SynchronizationProgress.CreateFromDiscriminatorValue)?.ToList(); } },
                {"quarantine", n => { Quarantine = n.GetObjectValue<SynchronizationQuarantine>(SynchronizationQuarantine.CreateFromDiscriminatorValue); } },
                {"steadyStateFirstAchievedTime", n => { SteadyStateFirstAchievedTime = n.GetDateTimeOffsetValue(); } },
                {"steadyStateLastAchievedTime", n => { SteadyStateLastAchievedTime = n.GetDateTimeOffsetValue(); } },
                {"synchronizedEntryCountByType", n => { SynchronizedEntryCountByType = n.GetCollectionOfObjectValues<StringKeyLongValuePair>(StringKeyLongValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"troubleshootingUrl", n => { TroubleshootingUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<SynchronizationStatusCode>("code", Code);
            writer.WriteLongValue("countSuccessiveCompleteFailures", CountSuccessiveCompleteFailures);
            writer.WriteBoolValue("escrowsPruned", EscrowsPruned);
            writer.WriteObjectValue<SynchronizationTaskExecution>("lastExecution", LastExecution);
            writer.WriteObjectValue<SynchronizationTaskExecution>("lastSuccessfulExecution", LastSuccessfulExecution);
            writer.WriteObjectValue<SynchronizationTaskExecution>("lastSuccessfulExecutionWithExports", LastSuccessfulExecutionWithExports);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<SynchronizationProgress>("progress", Progress);
            writer.WriteObjectValue<SynchronizationQuarantine>("quarantine", Quarantine);
            writer.WriteDateTimeOffsetValue("steadyStateFirstAchievedTime", SteadyStateFirstAchievedTime);
            writer.WriteDateTimeOffsetValue("steadyStateLastAchievedTime", SteadyStateLastAchievedTime);
            writer.WriteCollectionOfObjectValues<StringKeyLongValuePair>("synchronizedEntryCountByType", SynchronizedEntryCountByType);
            writer.WriteStringValue("troubleshootingUrl", TroubleshootingUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
