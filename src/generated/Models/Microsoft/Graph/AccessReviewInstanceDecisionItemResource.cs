using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AccessReviewInstanceDecisionItemResource : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Display name of the resource</summary>
        public string DisplayName { get; set; }
        /// <summary>Resource ID</summary>
        public string Id { get; set; }
        /// <summary>Type of resource. Types include: Group, ServicePrincipal, DirectoryRole, AzureRole, AccessPackageAssignmentPolicy.</summary>
        public string Type { get; set; }
        /// <summary>
        /// Instantiates a new accessReviewInstanceDecisionItemResource and sets the default values.
        /// </summary>
        public AccessReviewInstanceDecisionItemResource() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as AccessReviewInstanceDecisionItemResource).DisplayName = n.GetStringValue(); } },
                {"id", (o,n) => { (o as AccessReviewInstanceDecisionItemResource).Id = n.GetStringValue(); } },
                {"type", (o,n) => { (o as AccessReviewInstanceDecisionItemResource).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
