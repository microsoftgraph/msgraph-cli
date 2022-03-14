using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SiteCollection : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The geographic region code for where this site collection resides. Read-only.</summary>
        public string DataLocationCode { get; set; }
        /// <summary>The hostname for the site collection. Read-only.</summary>
        public string Hostname { get; set; }
        /// <summary>If present, indicates that this is a root site collection in SharePoint. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.Root Root { get; set; }
        /// <summary>
        /// Instantiates a new siteCollection and sets the default values.
        /// </summary>
        public SiteCollection() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SiteCollection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SiteCollection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"dataLocationCode", (o,n) => { (o as SiteCollection).DataLocationCode = n.GetStringValue(); } },
                {"hostname", (o,n) => { (o as SiteCollection).Hostname = n.GetStringValue(); } },
                {"root", (o,n) => { (o as SiteCollection).Root = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Root>(ApiSdk.Models.Microsoft.Graph.Root.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("dataLocationCode", DataLocationCode);
            writer.WriteStringValue("hostname", Hostname);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Root>("root", Root);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
