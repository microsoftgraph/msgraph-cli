using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class RequiredResourceAccess : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ResourceAccess> ResourceAccess { get; set; }
        /// <summary>The unique identifier for the resource that the application requires access to. This should be equal to the appId declared on the target resource application.</summary>
        public string ResourceAppId { get; set; }
        /// <summary>
        /// Instantiates a new requiredResourceAccess and sets the default values.
        /// </summary>
        public RequiredResourceAccess() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.RequiredResourceAccess CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RequiredResourceAccess();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"resourceAccess", (o,n) => { (o as RequiredResourceAccess).ResourceAccess = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ResourceAccess>(ApiSdk.Models.Microsoft.Graph.ResourceAccess.CreateFromDiscriminatorValue).ToList(); } },
                {"resourceAppId", (o,n) => { (o as RequiredResourceAccess).ResourceAppId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ResourceAccess>("resourceAccess", ResourceAccess);
            writer.WriteStringValue("resourceAppId", ResourceAppId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
