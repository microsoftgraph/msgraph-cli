using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ServiceHealthIssuePost : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The published time of the post.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The content of the service issue post.</summary>
        public ApiSdk.Models.Microsoft.Graph.ItemBody Description { get; set; }
        /// <summary>The post type of the service issue historical post. Possible values are: regular, quick, strategic, unknownFutureValue.</summary>
        public ApiSdk.Models.Microsoft.Graph.PostType? PostType { get; set; }
        /// <summary>
        /// Instantiates a new serviceHealthIssuePost and sets the default values.
        /// </summary>
        public ServiceHealthIssuePost() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.ServiceHealthIssuePost CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServiceHealthIssuePost();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"createdDateTime", (o,n) => { (o as ServiceHealthIssuePost).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as ServiceHealthIssuePost).Description = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ItemBody>(ApiSdk.Models.Microsoft.Graph.ItemBody.CreateFromDiscriminatorValue); } },
                {"postType", (o,n) => { (o as ServiceHealthIssuePost).PostType = n.GetEnumValue<PostType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ItemBody>("description", Description);
            writer.WriteEnumValue<PostType>("postType", PostType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
