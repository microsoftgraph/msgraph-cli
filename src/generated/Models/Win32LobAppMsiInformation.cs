using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Contains MSI app properties for a Win32 App.</summary>
    public class Win32LobAppMsiInformation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Indicates the package type of an MSI Win32LobApp.</summary>
        public Win32LobAppMsiPackageType? PackageType { get; set; }
        /// <summary>The MSI product code.</summary>
        public string ProductCode { get; set; }
        /// <summary>The MSI product name.</summary>
        public string ProductName { get; set; }
        /// <summary>The MSI product version.</summary>
        public string ProductVersion { get; set; }
        /// <summary>The MSI publisher.</summary>
        public string Publisher { get; set; }
        /// <summary>Whether the MSI app requires the machine to reboot to complete installation.</summary>
        public bool? RequiresReboot { get; set; }
        /// <summary>The MSI upgrade code.</summary>
        public string UpgradeCode { get; set; }
        /// <summary>
        /// Instantiates a new win32LobAppMsiInformation and sets the default values.
        /// </summary>
        public Win32LobAppMsiInformation() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.win32LobAppMsiInformation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Win32LobAppMsiInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Win32LobAppMsiInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"packageType", n => { PackageType = n.GetEnumValue<Win32LobAppMsiPackageType>(); } },
                {"productCode", n => { ProductCode = n.GetStringValue(); } },
                {"productName", n => { ProductName = n.GetStringValue(); } },
                {"productVersion", n => { ProductVersion = n.GetStringValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"requiresReboot", n => { RequiresReboot = n.GetBoolValue(); } },
                {"upgradeCode", n => { UpgradeCode = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<Win32LobAppMsiPackageType>("packageType", PackageType);
            writer.WriteStringValue("productCode", ProductCode);
            writer.WriteStringValue("productName", ProductName);
            writer.WriteStringValue("productVersion", ProductVersion);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteBoolValue("requiresReboot", RequiresReboot);
            writer.WriteStringValue("upgradeCode", UpgradeCode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
