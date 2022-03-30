using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Communications.Calls.Item.Participants.Item.StartHoldMusic {
    /// <summary>Provides operations to call the startHoldMusic method.</summary>
    public class StartHoldMusicRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string ClientContext { get; set; }
        public Prompt CustomPrompt { get; set; }
        /// <summary>
        /// Instantiates a new startHoldMusicRequestBody and sets the default values.
        /// </summary>
        public StartHoldMusicRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Communications.Calls.Item.Participants.Item.StartHoldMusic.StartHoldMusicRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StartHoldMusicRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"clientContext", (o,n) => { (o as StartHoldMusicRequestBody).ClientContext = n.GetStringValue(); } },
                {"customPrompt", (o,n) => { (o as StartHoldMusicRequestBody).CustomPrompt = n.GetObjectValue<Prompt>(Prompt.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("clientContext", ClientContext);
            writer.WriteObjectValue<Prompt>("customPrompt", CustomPrompt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
