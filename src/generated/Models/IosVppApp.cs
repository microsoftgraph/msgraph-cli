using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class IosVppApp : MobileApp, IParsable {
        /// <summary>The applicable iOS Device Type.</summary>
        public IosDeviceType ApplicableDeviceType { get; set; }
        /// <summary>The store URL.</summary>
        public string AppStoreUrl { get; set; }
        /// <summary>The Identity Name.</summary>
        public string BundleId { get; set; }
        /// <summary>The supported License Type.</summary>
        public VppLicensingType LicensingType { get; set; }
        /// <summary>The VPP application release date and time.</summary>
        public DateTimeOffset? ReleaseDateTime { get; set; }
        /// <summary>The total number of VPP licenses.</summary>
        public int? TotalLicenseCount { get; set; }
        /// <summary>The number of VPP licenses in use.</summary>
        public int? UsedLicenseCount { get; set; }
        /// <summary>The type of volume purchase program which the given Apple Volume Purchase Program Token is associated with. Possible values are: business, education. Possible values are: business, education.</summary>
        public ApiSdk.Models.VppTokenAccountType? VppTokenAccountType { get; set; }
        /// <summary>The Apple Id associated with the given Apple Volume Purchase Program Token.</summary>
        public string VppTokenAppleId { get; set; }
        /// <summary>The organization associated with the Apple Volume Purchase Program Token</summary>
        public string VppTokenOrganizationName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosVppApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosVppApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicableDeviceType", n => { ApplicableDeviceType = n.GetObjectValue<IosDeviceType>(IosDeviceType.CreateFromDiscriminatorValue); } },
                {"appStoreUrl", n => { AppStoreUrl = n.GetStringValue(); } },
                {"bundleId", n => { BundleId = n.GetStringValue(); } },
                {"licensingType", n => { LicensingType = n.GetObjectValue<VppLicensingType>(VppLicensingType.CreateFromDiscriminatorValue); } },
                {"releaseDateTime", n => { ReleaseDateTime = n.GetDateTimeOffsetValue(); } },
                {"totalLicenseCount", n => { TotalLicenseCount = n.GetIntValue(); } },
                {"usedLicenseCount", n => { UsedLicenseCount = n.GetIntValue(); } },
                {"vppTokenAccountType", n => { VppTokenAccountType = n.GetEnumValue<VppTokenAccountType>(); } },
                {"vppTokenAppleId", n => { VppTokenAppleId = n.GetStringValue(); } },
                {"vppTokenOrganizationName", n => { VppTokenOrganizationName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IosDeviceType>("applicableDeviceType", ApplicableDeviceType);
            writer.WriteStringValue("appStoreUrl", AppStoreUrl);
            writer.WriteStringValue("bundleId", BundleId);
            writer.WriteObjectValue<VppLicensingType>("licensingType", LicensingType);
            writer.WriteDateTimeOffsetValue("releaseDateTime", ReleaseDateTime);
            writer.WriteIntValue("totalLicenseCount", TotalLicenseCount);
            writer.WriteIntValue("usedLicenseCount", UsedLicenseCount);
            writer.WriteEnumValue<VppTokenAccountType>("vppTokenAccountType", VppTokenAccountType);
            writer.WriteStringValue("vppTokenAppleId", VppTokenAppleId);
            writer.WriteStringValue("vppTokenOrganizationName", VppTokenOrganizationName);
        }
    }
}
