using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Communications.Calls.Item.Answer {
    public class AnswerRequestBody : IParsable {
        public List<Modality?> AcceptedModalities { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string CallbackUri { get; set; }
        public MediaConfig MediaConfig { get; set; }
        public int? ParticipantCapacity { get; set; }
        /// <summary>
        /// Instantiates a new answerRequestBody and sets the default values.
        /// </summary>
        public AnswerRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"acceptedModalities", (o,n) => { (o as AnswerRequestBody).AcceptedModalities = n.GetCollectionOfEnumValues<Modality>().ToList(); } },
                {"callbackUri", (o,n) => { (o as AnswerRequestBody).CallbackUri = n.GetStringValue(); } },
                {"mediaConfig", (o,n) => { (o as AnswerRequestBody).MediaConfig = n.GetObjectValue<MediaConfig>(); } },
                {"participantCapacity", (o,n) => { (o as AnswerRequestBody).ParticipantCapacity = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<Modality>("acceptedModalities", AcceptedModalities);
            writer.WriteStringValue("callbackUri", CallbackUri);
            writer.WriteObjectValue<MediaConfig>("mediaConfig", MediaConfig);
            writer.WriteIntValue("participantCapacity", ParticipantCapacity);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
