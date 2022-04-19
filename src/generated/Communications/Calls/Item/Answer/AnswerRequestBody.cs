using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Communications.Calls.Item.Answer {
    /// <summary>Provides operations to call the answer method.</summary>
    public class AnswerRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>The acceptedModalities property</summary>
        public List<Modality?> AcceptedModalities { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The callbackUri property</summary>
        public string CallbackUri { get; set; }
        /// <summary>The callOptions property</summary>
        public IncomingCallOptions CallOptions { get; set; }
        /// <summary>The mediaConfig property</summary>
        public ApiSdk.Models.MediaConfig MediaConfig { get; set; }
        /// <summary>The participantCapacity property</summary>
        public int? ParticipantCapacity { get; set; }
        /// <summary>
        /// Instantiates a new answerRequestBody and sets the default values.
        /// </summary>
        public AnswerRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AnswerRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AnswerRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"acceptedModalities", n => { AcceptedModalities = n.GetCollectionOfEnumValues<Modality>().ToList(); } },
                {"callbackUri", n => { CallbackUri = n.GetStringValue(); } },
                {"callOptions", n => { CallOptions = n.GetObjectValue<IncomingCallOptions>(IncomingCallOptions.CreateFromDiscriminatorValue); } },
                {"mediaConfig", n => { MediaConfig = n.GetObjectValue<ApiSdk.Models.MediaConfig>(ApiSdk.Models.MediaConfig.CreateFromDiscriminatorValue); } },
                {"participantCapacity", n => { ParticipantCapacity = n.GetIntValue(); } },
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
            writer.WriteObjectValue<IncomingCallOptions>("callOptions", CallOptions);
            writer.WriteObjectValue<ApiSdk.Models.MediaConfig>("mediaConfig", MediaConfig);
            writer.WriteIntValue("participantCapacity", ParticipantCapacity);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
