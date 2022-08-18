using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ManagedAndroidStoreApp : ManagedApp, IParsable {
        /// <summary>The Android AppStoreUrl.</summary>
        public string AppStoreUrl { get; set; }
        /// <summary>Contains properties for the minimum operating system required for an Android mobile app.</summary>
        public AndroidMinimumOperatingSystem MinimumSupportedOperatingSystem { get; set; }
        /// <summary>The app&apos;s package ID.</summary>
        public string PackageId { get; set; }
        /// <summary>
        /// Instantiates a new ManagedAndroidStoreApp and sets the default values.
        /// </summary>
        public ManagedAndroidStoreApp() : base() {
            OdataType = "#microsoft.graph.managedAndroidStoreApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedAndroidStoreApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedAndroidStoreApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appStoreUrl", n => { AppStoreUrl = n.GetStringValue(); } },
                {"minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<AndroidMinimumOperatingSystem>(AndroidMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
                {"packageId", n => { PackageId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appStoreUrl", AppStoreUrl);
            writer.WriteObjectValue<AndroidMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
            writer.WriteStringValue("packageId", PackageId);
        }
    }
}
