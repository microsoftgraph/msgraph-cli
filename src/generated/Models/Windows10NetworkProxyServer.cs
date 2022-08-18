using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Network Proxy Server Policy.</summary>
    public class Windows10NetworkProxyServer : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Address to the proxy server. Specify an address in the format [&apos;:&apos;]</summary>
        public string Address { get; set; }
        /// <summary>Addresses that should not use the proxy server. The system will not use the proxy server for addresses beginning with what is specified in this node.</summary>
        public List<string> Exceptions { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Specifies whether the proxy server should be used for local (intranet) addresses.</summary>
        public bool? UseForLocalAddresses { get; set; }
        /// <summary>
        /// Instantiates a new windows10NetworkProxyServer and sets the default values.
        /// </summary>
        public Windows10NetworkProxyServer() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.windows10NetworkProxyServer";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Windows10NetworkProxyServer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10NetworkProxyServer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"address", n => { Address = n.GetStringValue(); } },
                {"exceptions", n => { Exceptions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"useForLocalAddresses", n => { UseForLocalAddresses = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("address", Address);
            writer.WriteCollectionOfPrimitiveValues<string>("exceptions", Exceptions);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("useForLocalAddresses", UseForLocalAddresses);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
