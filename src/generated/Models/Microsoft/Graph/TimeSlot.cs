using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TimeSlot : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone End { get; set; }
        public ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone Start { get; set; }
        /// <summary>
        /// Instantiates a new timeSlot and sets the default values.
        /// </summary>
        public TimeSlot() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.TimeSlot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeSlot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"end", (o,n) => { (o as TimeSlot).End = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone>(ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"start", (o,n) => { (o as TimeSlot).Start = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone>(ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone>("end", End);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone>("start", Start);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
