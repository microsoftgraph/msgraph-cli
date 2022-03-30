using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    /// <summary>Singleton entity that acts as a container for all device app management functionality.</summary>
    public class DeviceAppManagement : Entity, IParsable {
        /// <summary>Android managed app policies.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AndroidManagedAppProtection> AndroidManagedAppProtections { get; set; }
        /// <summary>Default managed app policies.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DefaultManagedAppProtection> DefaultManagedAppProtections { get; set; }
        /// <summary>iOS managed app policies.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.IosManagedAppProtection> IosManagedAppProtections { get; set; }
        /// <summary>Whether the account is enabled for syncing applications from the Microsoft Store for Business.</summary>
        public bool? IsEnabledForMicrosoftStoreForBusiness { get; set; }
        /// <summary>Managed app policies.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ManagedAppPolicy> ManagedAppPolicies { get; set; }
        /// <summary>The managed app registrations.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ManagedAppRegistration> ManagedAppRegistrations { get; set; }
        /// <summary>The managed app statuses.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ManagedAppStatus> ManagedAppStatuses { get; set; }
        /// <summary>The Managed eBook.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ManagedEBook> ManagedEBooks { get; set; }
        /// <summary>Windows information protection for apps running on devices which are MDM enrolled.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.MdmWindowsInformationProtectionPolicy> MdmWindowsInformationProtectionPolicies { get; set; }
        /// <summary>The locale information used to sync applications from the Microsoft Store for Business. Cultures that are specific to a country/region. The names of these cultures follow RFC 4646 (Windows Vista and later). The format is -<country/regioncode2>, where  is a lowercase two-letter code derived from ISO 639-1 and <country/regioncode2> is an uppercase two-letter code derived from ISO 3166. For example, en-US for English (United States) is a specific culture.</summary>
        public string MicrosoftStoreForBusinessLanguage { get; set; }
        /// <summary>The last time an application sync from the Microsoft Store for Business was completed.</summary>
        public DateTimeOffset? MicrosoftStoreForBusinessLastCompletedApplicationSyncTime { get; set; }
        /// <summary>The last time the apps from the Microsoft Store for Business were synced successfully for the account.</summary>
        public DateTimeOffset? MicrosoftStoreForBusinessLastSuccessfulSyncDateTime { get; set; }
        /// <summary>The mobile app categories.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.MobileAppCategory> MobileAppCategories { get; set; }
        /// <summary>The Managed Device Mobile Application Configurations.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfiguration> MobileAppConfigurations { get; set; }
        /// <summary>The mobile apps.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.MobileApp> MobileApps { get; set; }
        /// <summary>Targeted managed app configurations.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.TargetedManagedAppConfiguration> TargetedManagedAppConfigurations { get; set; }
        /// <summary>List of Vpp tokens for this organization.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.VppToken> VppTokens { get; set; }
        /// <summary>Windows information protection for apps running on devices which are not MDM enrolled.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.WindowsInformationProtectionPolicy> WindowsInformationProtectionPolicies { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.DeviceAppManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceAppManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"androidManagedAppProtections", (o,n) => { (o as DeviceAppManagement).AndroidManagedAppProtections = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AndroidManagedAppProtection>(ApiSdk.Models.Microsoft.Graph.AndroidManagedAppProtection.CreateFromDiscriminatorValue).ToList(); } },
                {"defaultManagedAppProtections", (o,n) => { (o as DeviceAppManagement).DefaultManagedAppProtections = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DefaultManagedAppProtection>(ApiSdk.Models.Microsoft.Graph.DefaultManagedAppProtection.CreateFromDiscriminatorValue).ToList(); } },
                {"iosManagedAppProtections", (o,n) => { (o as DeviceAppManagement).IosManagedAppProtections = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.IosManagedAppProtection>(ApiSdk.Models.Microsoft.Graph.IosManagedAppProtection.CreateFromDiscriminatorValue).ToList(); } },
                {"isEnabledForMicrosoftStoreForBusiness", (o,n) => { (o as DeviceAppManagement).IsEnabledForMicrosoftStoreForBusiness = n.GetBoolValue(); } },
                {"managedAppPolicies", (o,n) => { (o as DeviceAppManagement).ManagedAppPolicies = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedAppPolicy>(ApiSdk.Models.Microsoft.Graph.ManagedAppPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"managedAppRegistrations", (o,n) => { (o as DeviceAppManagement).ManagedAppRegistrations = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedAppRegistration>(ApiSdk.Models.Microsoft.Graph.ManagedAppRegistration.CreateFromDiscriminatorValue).ToList(); } },
                {"managedAppStatuses", (o,n) => { (o as DeviceAppManagement).ManagedAppStatuses = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedAppStatus>(ApiSdk.Models.Microsoft.Graph.ManagedAppStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"managedEBooks", (o,n) => { (o as DeviceAppManagement).ManagedEBooks = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedEBook>(ApiSdk.Models.Microsoft.Graph.ManagedEBook.CreateFromDiscriminatorValue).ToList(); } },
                {"mdmWindowsInformationProtectionPolicies", (o,n) => { (o as DeviceAppManagement).MdmWindowsInformationProtectionPolicies = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MdmWindowsInformationProtectionPolicy>(ApiSdk.Models.Microsoft.Graph.MdmWindowsInformationProtectionPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"microsoftStoreForBusinessLanguage", (o,n) => { (o as DeviceAppManagement).MicrosoftStoreForBusinessLanguage = n.GetStringValue(); } },
                {"microsoftStoreForBusinessLastCompletedApplicationSyncTime", (o,n) => { (o as DeviceAppManagement).MicrosoftStoreForBusinessLastCompletedApplicationSyncTime = n.GetDateTimeOffsetValue(); } },
                {"microsoftStoreForBusinessLastSuccessfulSyncDateTime", (o,n) => { (o as DeviceAppManagement).MicrosoftStoreForBusinessLastSuccessfulSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"mobileAppCategories", (o,n) => { (o as DeviceAppManagement).MobileAppCategories = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MobileAppCategory>(ApiSdk.Models.Microsoft.Graph.MobileAppCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"mobileAppConfigurations", (o,n) => { (o as DeviceAppManagement).MobileAppConfigurations = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfiguration>(ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"mobileApps", (o,n) => { (o as DeviceAppManagement).MobileApps = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MobileApp>(ApiSdk.Models.Microsoft.Graph.MobileApp.CreateFromDiscriminatorValue).ToList(); } },
                {"targetedManagedAppConfigurations", (o,n) => { (o as DeviceAppManagement).TargetedManagedAppConfigurations = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TargetedManagedAppConfiguration>(ApiSdk.Models.Microsoft.Graph.TargetedManagedAppConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"vppTokens", (o,n) => { (o as DeviceAppManagement).VppTokens = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.VppToken>(ApiSdk.Models.Microsoft.Graph.VppToken.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsInformationProtectionPolicies", (o,n) => { (o as DeviceAppManagement).WindowsInformationProtectionPolicies = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WindowsInformationProtectionPolicy>(ApiSdk.Models.Microsoft.Graph.WindowsInformationProtectionPolicy.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AndroidManagedAppProtection>("androidManagedAppProtections", AndroidManagedAppProtections);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DefaultManagedAppProtection>("defaultManagedAppProtections", DefaultManagedAppProtections);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.IosManagedAppProtection>("iosManagedAppProtections", IosManagedAppProtections);
            writer.WriteBoolValue("isEnabledForMicrosoftStoreForBusiness", IsEnabledForMicrosoftStoreForBusiness);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedAppPolicy>("managedAppPolicies", ManagedAppPolicies);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedAppRegistration>("managedAppRegistrations", ManagedAppRegistrations);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedAppStatus>("managedAppStatuses", ManagedAppStatuses);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedEBook>("managedEBooks", ManagedEBooks);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MdmWindowsInformationProtectionPolicy>("mdmWindowsInformationProtectionPolicies", MdmWindowsInformationProtectionPolicies);
            writer.WriteStringValue("microsoftStoreForBusinessLanguage", MicrosoftStoreForBusinessLanguage);
            writer.WriteDateTimeOffsetValue("microsoftStoreForBusinessLastCompletedApplicationSyncTime", MicrosoftStoreForBusinessLastCompletedApplicationSyncTime);
            writer.WriteDateTimeOffsetValue("microsoftStoreForBusinessLastSuccessfulSyncDateTime", MicrosoftStoreForBusinessLastSuccessfulSyncDateTime);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MobileAppCategory>("mobileAppCategories", MobileAppCategories);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedDeviceMobileAppConfiguration>("mobileAppConfigurations", MobileAppConfigurations);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MobileApp>("mobileApps", MobileApps);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TargetedManagedAppConfiguration>("targetedManagedAppConfigurations", TargetedManagedAppConfigurations);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.VppToken>("vppTokens", VppTokens);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.WindowsInformationProtectionPolicy>("windowsInformationProtectionPolicies", WindowsInformationProtectionPolicies);
        }
    }
}
