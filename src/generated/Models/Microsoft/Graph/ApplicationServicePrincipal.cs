using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ApplicationServicePrincipal : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public ApiSdk.Models.Microsoft.Graph.Application Application { get; set; }
        public ApiSdk.Models.Microsoft.Graph.ServicePrincipal ServicePrincipal { get; set; }
        /// <summary>
        /// Instantiates a new applicationServicePrincipal and sets the default values.
        /// </summary>
        public ApplicationServicePrincipal() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApplicationServicePrincipal CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplicationServicePrincipal();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"application", (o,n) => { (o as ApplicationServicePrincipal).Application = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Application>(ApiSdk.Models.Microsoft.Graph.Application.CreateFromDiscriminatorValue); } },
                {"servicePrincipal", (o,n) => { (o as ApplicationServicePrincipal).ServicePrincipal = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ServicePrincipal>(ApiSdk.Models.Microsoft.Graph.ServicePrincipal.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Application>("application", Application);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ServicePrincipal>("servicePrincipal", ServicePrincipal);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
