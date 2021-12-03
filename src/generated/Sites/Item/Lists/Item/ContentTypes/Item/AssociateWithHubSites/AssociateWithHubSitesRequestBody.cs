using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Sites.Item.Lists.Item.ContentTypes.Item.AssociateWithHubSites {
    public class AssociateWithHubSitesRequestBody : IParsable {
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
