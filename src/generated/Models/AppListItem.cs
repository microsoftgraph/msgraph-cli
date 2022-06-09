using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Represents an app in the list of managed applications</summary>
    public class AppListItem : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The application or bundle identifier of the application</summary>
        public string AppId { get; set; }
        /// <summary>The Store URL of the application</summary>
        public string AppStoreUrl { get; set; }
        /// <summary>The application name</summary>
        public string Name { get; set; }
        /// <summary>The publisher of the application</summary>
        public string Publisher { get; set; }
        /// <summary>
        /// Instantiates a new appListItem and sets the default values.
        /// </summary>
        public AppListItem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AppListItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppListItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"appStoreUrl", n => { AppStoreUrl = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("appStoreUrl", AppStoreUrl);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
