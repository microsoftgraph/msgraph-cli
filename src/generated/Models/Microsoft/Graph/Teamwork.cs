using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the teamwork singleton.</summary>
    public class Teamwork : Entity, IParsable {
        /// <summary>A workforce integration with shifts.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.WorkforceIntegration> WorkforceIntegrations { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.Teamwork CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Teamwork();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"workforceIntegrations", (o,n) => { (o as Teamwork).WorkforceIntegrations = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkforceIntegration>(ApiSdk.Models.Microsoft.Graph.WorkforceIntegration.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WorkforceIntegration>("workforceIntegrations", WorkforceIntegrations);
        }
    }
}
