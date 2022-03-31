using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Shares.Item.List.ContentTypes.Item.AssociateWithHubSites {
    /// <summary>Provides operations to call the associateWithHubSites method.</summary>
    public class AssociateWithHubSitesRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> HubSiteUrls { get; set; }
        public bool? PropagateToExistingLists { get; set; }
        /// <summary>
        /// Instantiates a new associateWithHubSitesRequestBody and sets the default values.
        /// </summary>
        public AssociateWithHubSitesRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Shares.Item.List.ContentTypes.Item.AssociateWithHubSites.AssociateWithHubSitesRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssociateWithHubSitesRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"hubSiteUrls", (o,n) => { (o as AssociateWithHubSitesRequestBody).HubSiteUrls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"propagateToExistingLists", (o,n) => { (o as AssociateWithHubSitesRequestBody).PropagateToExistingLists = n.GetBoolValue(); } },
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
