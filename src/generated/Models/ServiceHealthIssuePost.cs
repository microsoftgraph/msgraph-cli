using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ServiceHealthIssuePost : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The published time of the post.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The content of the service issue post.</summary>
        public ItemBody Description { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The post type of the service issue historical post. Possible values are: regular, quick, strategic, unknownFutureValue.</summary>
        public ApiSdk.Models.PostType? PostType { get; set; }
        /// <summary>
        /// Instantiates a new serviceHealthIssuePost and sets the default values.
        /// </summary>
        public ServiceHealthIssuePost() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.serviceHealthIssuePost";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ServiceHealthIssuePost CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServiceHealthIssuePost();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"postType", n => { PostType = n.GetEnumValue<PostType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<ItemBody>("description", Description);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<PostType>("postType", PostType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
