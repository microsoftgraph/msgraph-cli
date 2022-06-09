using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the identityGovernance singleton.</summary>
    public class AccessReviewHistoryInstance : Entity, IParsable {
        /// <summary>Uri which can be used to retrieve review history data. This URI will be active for 24 hours after being generated. Required.</summary>
        public string DownloadUri { get; set; }
        /// <summary>Timestamp when this instance and associated data expires and the history is deleted. Required.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>Timestamp when all of the available data for this instance was collected. This will be set after this instance&apos;s status is set to done. Required.</summary>
        public DateTimeOffset? FulfilledDateTime { get; set; }
        /// <summary>Timestamp, reviews ending on or before this date will be included in the fetched history data.</summary>
        public DateTimeOffset? ReviewHistoryPeriodEndDateTime { get; set; }
        /// <summary>Timestamp, reviews starting on or after this date will be included in the fetched history data.</summary>
        public DateTimeOffset? ReviewHistoryPeriodStartDateTime { get; set; }
        /// <summary>Timestamp when the instance&apos;s history data is scheduled to be generated.</summary>
        public DateTimeOffset? RunDateTime { get; set; }
        /// <summary>Represents the status of the review history data collection. The possible values are: done, inProgress, error, requested, unknownFutureValue. Once the status has been marked as done, a link can be generated to retrieve the instance&apos;s data by calling generateDownloadUri method.</summary>
        public AccessReviewHistoryStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessReviewHistoryInstance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewHistoryInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"downloadUri", n => { DownloadUri = n.GetStringValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"fulfilledDateTime", n => { FulfilledDateTime = n.GetDateTimeOffsetValue(); } },
                {"reviewHistoryPeriodEndDateTime", n => { ReviewHistoryPeriodEndDateTime = n.GetDateTimeOffsetValue(); } },
                {"reviewHistoryPeriodStartDateTime", n => { ReviewHistoryPeriodStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"runDateTime", n => { RunDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<AccessReviewHistoryStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("downloadUri", DownloadUri);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("fulfilledDateTime", FulfilledDateTime);
            writer.WriteDateTimeOffsetValue("reviewHistoryPeriodEndDateTime", ReviewHistoryPeriodEndDateTime);
            writer.WriteDateTimeOffsetValue("reviewHistoryPeriodStartDateTime", ReviewHistoryPeriodStartDateTime);
            writer.WriteDateTimeOffsetValue("runDateTime", RunDateTime);
            writer.WriteEnumValue<AccessReviewHistoryStatus>("status", Status);
        }
    }
}
