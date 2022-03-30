using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ConditionalAccessApplications : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The list of application IDs explicitly excluded from the policy.</summary>
        public List<string> ExcludeApplications { get; set; }
        /// <summary>The list of application IDs the policy applies to, unless explicitly excluded (in excludeApplications). Can also be set to All.</summary>
        public List<string> IncludeApplications { get; set; }
        /// <summary>Authentication context class references include. Supported values are c1 through c25.</summary>
        public List<string> IncludeAuthenticationContextClassReferences { get; set; }
        /// <summary>User actions to include. Supported values are urn:user:registersecurityinfo and urn:user:registerdevice</summary>
        public List<string> IncludeUserActions { get; set; }
        /// <summary>
        /// Instantiates a new conditionalAccessApplications and sets the default values.
        /// </summary>
        public ConditionalAccessApplications() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.ConditionalAccessApplications CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessApplications();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"excludeApplications", (o,n) => { (o as ConditionalAccessApplications).ExcludeApplications = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"includeApplications", (o,n) => { (o as ConditionalAccessApplications).IncludeApplications = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"includeAuthenticationContextClassReferences", (o,n) => { (o as ConditionalAccessApplications).IncludeAuthenticationContextClassReferences = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"includeUserActions", (o,n) => { (o as ConditionalAccessApplications).IncludeUserActions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("excludeApplications", ExcludeApplications);
            writer.WriteCollectionOfPrimitiveValues<string>("includeApplications", IncludeApplications);
            writer.WriteCollectionOfPrimitiveValues<string>("includeAuthenticationContextClassReferences", IncludeAuthenticationContextClassReferences);
            writer.WriteCollectionOfPrimitiveValues<string>("includeUserActions", IncludeUserActions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
