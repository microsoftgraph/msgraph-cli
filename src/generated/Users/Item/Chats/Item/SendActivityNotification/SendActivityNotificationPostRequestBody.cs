using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Users.Item.Chats.Item.SendActivityNotification {
    /// <summary>Provides operations to call the sendActivityNotification method.</summary>
    public class SendActivityNotificationPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>The activityType property</summary>
        public string ActivityType { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The chainId property</summary>
        public long? ChainId { get; set; }
        /// <summary>The previewText property</summary>
        public ItemBody PreviewText { get; set; }
        /// <summary>The recipient property</summary>
        public TeamworkNotificationRecipient Recipient { get; set; }
        /// <summary>The templateParameters property</summary>
        public List<ApiSdk.Models.KeyValuePair> TemplateParameters { get; set; }
        /// <summary>The topic property</summary>
        public TeamworkActivityTopic Topic { get; set; }
        /// <summary>
        /// Instantiates a new sendActivityNotificationPostRequestBody and sets the default values.
        /// </summary>
        public SendActivityNotificationPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SendActivityNotificationPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SendActivityNotificationPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"activityType", n => { ActivityType = n.GetStringValue(); } },
                {"chainId", n => { ChainId = n.GetLongValue(); } },
                {"previewText", n => { PreviewText = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"recipient", n => { Recipient = n.GetObjectValue<TeamworkNotificationRecipient>(TeamworkNotificationRecipient.CreateFromDiscriminatorValue); } },
                {"templateParameters", n => { TemplateParameters = n.GetCollectionOfObjectValues<ApiSdk.Models.KeyValuePair>(ApiSdk.Models.KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"topic", n => { Topic = n.GetObjectValue<TeamworkActivityTopic>(TeamworkActivityTopic.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("activityType", ActivityType);
            writer.WriteLongValue("chainId", ChainId);
            writer.WriteObjectValue<ItemBody>("previewText", PreviewText);
            writer.WriteObjectValue<TeamworkNotificationRecipient>("recipient", Recipient);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.KeyValuePair>("templateParameters", TemplateParameters);
            writer.WriteObjectValue<TeamworkActivityTopic>("topic", Topic);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
