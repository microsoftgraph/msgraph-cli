using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>App for Windows information protection</summary>
    public class WindowsInformationProtectionApp : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If true, app is denied protection or exemption.</summary>
        public bool? Denied { get; set; }
        /// <summary>The app's description.</summary>
        public string Description { get; set; }
        /// <summary>App display name.</summary>
        public string DisplayName { get; set; }
        /// <summary>The product name.</summary>
        public string ProductName { get; set; }
        /// <summary>The publisher name</summary>
        public string PublisherName { get; set; }
        /// <summary>
        /// Instantiates a new windowsInformationProtectionApp and sets the default values.
        /// </summary>
        public WindowsInformationProtectionApp() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.WindowsInformationProtectionApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsInformationProtectionApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"denied", (o,n) => { (o as WindowsInformationProtectionApp).Denied = n.GetBoolValue(); } },
                {"description", (o,n) => { (o as WindowsInformationProtectionApp).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as WindowsInformationProtectionApp).DisplayName = n.GetStringValue(); } },
                {"productName", (o,n) => { (o as WindowsInformationProtectionApp).ProductName = n.GetStringValue(); } },
                {"publisherName", (o,n) => { (o as WindowsInformationProtectionApp).PublisherName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("denied", Denied);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("productName", ProductName);
            writer.WriteStringValue("publisherName", PublisherName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
