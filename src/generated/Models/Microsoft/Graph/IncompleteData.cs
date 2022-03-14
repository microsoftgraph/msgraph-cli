using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class IncompleteData : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The service does not have source data before the specified time.</summary>
        public DateTimeOffset? MissingDataBeforeDateTime { get; set; }
        /// <summary>Some data was not recorded due to excessive activity.</summary>
        public bool? WasThrottled { get; set; }
        /// <summary>
        /// Instantiates a new incompleteData and sets the default values.
        /// </summary>
        public IncompleteData() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static IncompleteData CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IncompleteData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"missingDataBeforeDateTime", (o,n) => { (o as IncompleteData).MissingDataBeforeDateTime = n.GetDateTimeOffsetValue(); } },
                {"wasThrottled", (o,n) => { (o as IncompleteData).WasThrottled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("missingDataBeforeDateTime", MissingDataBeforeDateTime);
            writer.WriteBoolValue("wasThrottled", WasThrottled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
