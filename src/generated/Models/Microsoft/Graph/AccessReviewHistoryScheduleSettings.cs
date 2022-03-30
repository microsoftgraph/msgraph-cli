using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AccessReviewHistoryScheduleSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public ApiSdk.Models.Microsoft.Graph.PatternedRecurrence Recurrence { get; set; }
        /// <summary>A duration string in ISO 8601 duration format specifying the lookback period of the generated review history data. For example, if a history definition is scheduled to run on the 1st of every month, the reportRange is P1M. In this case, on the first of every month, access review history data will be collected containing only the previous month's review data. Note: Only years, months, and days ISO 8601 properties are supported. Required.</summary>
        public string ReportRange { get; set; }
        /// <summary>
        /// Instantiates a new accessReviewHistoryScheduleSettings and sets the default values.
        /// </summary>
        public AccessReviewHistoryScheduleSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.AccessReviewHistoryScheduleSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewHistoryScheduleSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"recurrence", (o,n) => { (o as AccessReviewHistoryScheduleSettings).Recurrence = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PatternedRecurrence>(ApiSdk.Models.Microsoft.Graph.PatternedRecurrence.CreateFromDiscriminatorValue); } },
                {"reportRange", (o,n) => { (o as AccessReviewHistoryScheduleSettings).ReportRange = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteStringValue("reportRange", ReportRange);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
