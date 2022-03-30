using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AutomaticRepliesMailTips : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The automatic reply message.</summary>
        public string Message { get; set; }
        /// <summary>The language that the automatic reply message is in.</summary>
        public ApiSdk.Models.Microsoft.Graph.LocaleInfo MessageLanguage { get; set; }
        /// <summary>The date and time that automatic replies are set to end.</summary>
        public ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone ScheduledEndTime { get; set; }
        /// <summary>The date and time that automatic replies are set to begin.</summary>
        public ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone ScheduledStartTime { get; set; }
        /// <summary>
        /// Instantiates a new automaticRepliesMailTips and sets the default values.
        /// </summary>
        public AutomaticRepliesMailTips() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.AutomaticRepliesMailTips CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AutomaticRepliesMailTips();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"message", (o,n) => { (o as AutomaticRepliesMailTips).Message = n.GetStringValue(); } },
                {"messageLanguage", (o,n) => { (o as AutomaticRepliesMailTips).MessageLanguage = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.LocaleInfo>(ApiSdk.Models.Microsoft.Graph.LocaleInfo.CreateFromDiscriminatorValue); } },
                {"scheduledEndTime", (o,n) => { (o as AutomaticRepliesMailTips).ScheduledEndTime = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone>(ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"scheduledStartTime", (o,n) => { (o as AutomaticRepliesMailTips).ScheduledStartTime = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone>(ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("message", Message);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.LocaleInfo>("messageLanguage", MessageLanguage);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone>("scheduledEndTime", ScheduledEndTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DateTimeTimeZone>("scheduledStartTime", ScheduledStartTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
