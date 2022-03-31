using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AppConsentRequestCollectionResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.AppConsentRequest> Value { get; set; }
        /// <summary>
        /// Instantiates a new AppConsentRequestCollectionResponse and sets the default values.
        /// </summary>
        public AppConsentRequestCollectionResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.AppConsentRequestCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppConsentRequestCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as AppConsentRequestCollectionResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as AppConsentRequestCollectionResponse).Value = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AppConsentRequest>(ApiSdk.Models.Microsoft.Graph.AppConsentRequest.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AppConsentRequest>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
