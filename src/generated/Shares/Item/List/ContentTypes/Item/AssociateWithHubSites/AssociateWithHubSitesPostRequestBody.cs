using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Shares.Item.List.ContentTypes.Item.AssociateWithHubSites {
    /// <summary>Provides operations to call the associateWithHubSites method.</summary>
    public class AssociateWithHubSitesPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The hubSiteUrls property</summary>
        public List<string> HubSiteUrls { get; set; }
        /// <summary>The propagateToExistingLists property</summary>
        public bool? PropagateToExistingLists { get; set; }
        /// <summary>
        /// Instantiates a new associateWithHubSitesPostRequestBody and sets the default values.
        /// </summary>
        public AssociateWithHubSitesPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AssociateWithHubSitesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssociateWithHubSitesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"hubSiteUrls", n => { HubSiteUrls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"propagateToExistingLists", n => { PropagateToExistingLists = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("hubSiteUrls", HubSiteUrls);
            writer.WriteBoolValue("propagateToExistingLists", PropagateToExistingLists);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
