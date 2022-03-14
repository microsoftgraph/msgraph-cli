using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.MobileAppContentFile.Commit {
    public class CommitRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public ApiSdk.Models.Microsoft.Graph.FileEncryptionInfo FileEncryptionInfo { get; set; }
        /// <summary>
        /// Instantiates a new commitRequestBody and sets the default values.
        /// </summary>
        public CommitRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CommitRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CommitRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"fileEncryptionInfo", (o,n) => { (o as CommitRequestBody).FileEncryptionInfo = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.FileEncryptionInfo>(ApiSdk.Models.Microsoft.Graph.FileEncryptionInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.FileEncryptionInfo>("fileEncryptionInfo", FileEncryptionInfo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
