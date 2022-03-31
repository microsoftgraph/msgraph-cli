using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Groups.Item.Conversations.Item.Threads.Item.Posts.Item.Reply {
    /// <summary>Provides operations to call the reply method.</summary>
    public class ReplyRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public ApiSdk.Models.Microsoft.Graph.Post Post { get; set; }
        /// <summary>
        /// Instantiates a new replyRequestBody and sets the default values.
        /// </summary>
        public ReplyRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Groups.Item.Conversations.Item.Threads.Item.Posts.Item.Reply.ReplyRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReplyRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"post", (o,n) => { (o as ReplyRequestBody).Post = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Post>(ApiSdk.Models.Microsoft.Graph.Post.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Post>("post", Post);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
