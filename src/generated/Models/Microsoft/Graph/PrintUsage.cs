using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PrintUsage : Entity, IParsable {
        public long? CompletedBlackAndWhiteJobCount { get; set; }
        public long? CompletedColorJobCount { get; set; }
        public long? IncompleteJobCount { get; set; }
        public Date? UsageDate { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrintUsage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrintUsage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"completedBlackAndWhiteJobCount", (o,n) => { (o as PrintUsage).CompletedBlackAndWhiteJobCount = n.GetLongValue(); } },
                {"completedColorJobCount", (o,n) => { (o as PrintUsage).CompletedColorJobCount = n.GetLongValue(); } },
                {"incompleteJobCount", (o,n) => { (o as PrintUsage).IncompleteJobCount = n.GetLongValue(); } },
                {"usageDate", (o,n) => { (o as PrintUsage).UsageDate = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("completedBlackAndWhiteJobCount", CompletedBlackAndWhiteJobCount);
            writer.WriteLongValue("completedColorJobCount", CompletedColorJobCount);
            writer.WriteLongValue("incompleteJobCount", IncompleteJobCount);
            writer.WriteDateValue("usageDate", UsageDate);
        }
    }
}
