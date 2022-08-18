using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class WindowsUpdateForBusinessConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Possible values for automatic update mode.</summary>
        public ApiSdk.Models.AutomaticUpdateMode? AutomaticUpdateMode { get; set; }
        /// <summary>Which branch devices will receive their updates from</summary>
        public WindowsUpdateType? BusinessReadyUpdatesOnly { get; set; }
        /// <summary>Delivery optimization mode for peer distribution</summary>
        public WindowsDeliveryOptimizationMode? DeliveryOptimizationMode { get; set; }
        /// <summary>Exclude Windows update Drivers</summary>
        public bool? DriversExcluded { get; set; }
        /// <summary>Defer Feature Updates by these many days</summary>
        public int? FeatureUpdatesDeferralPeriodInDays { get; set; }
        /// <summary>Pause Feature Updates</summary>
        public bool? FeatureUpdatesPaused { get; set; }
        /// <summary>Feature Updates Pause Expiry datetime</summary>
        public DateTimeOffset? FeatureUpdatesPauseExpiryDateTime { get; set; }
        /// <summary>Installation schedule</summary>
        public WindowsUpdateInstallScheduleType InstallationSchedule { get; set; }
        /// <summary>Allow Microsoft Update Service</summary>
        public bool? MicrosoftUpdateServiceAllowed { get; set; }
        /// <summary>Possible values for pre-release features.</summary>
        public ApiSdk.Models.PrereleaseFeatures? PrereleaseFeatures { get; set; }
        /// <summary>Defer Quality Updates by these many days</summary>
        public int? QualityUpdatesDeferralPeriodInDays { get; set; }
        /// <summary>Pause Quality Updates</summary>
        public bool? QualityUpdatesPaused { get; set; }
        /// <summary>Quality Updates Pause Expiry datetime</summary>
        public DateTimeOffset? QualityUpdatesPauseExpiryDateTime { get; set; }
        /// <summary>
        /// Instantiates a new WindowsUpdateForBusinessConfiguration and sets the default values.
        /// </summary>
        public WindowsUpdateForBusinessConfiguration() : base() {
            OdataType = "#microsoft.graph.windowsUpdateForBusinessConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsUpdateForBusinessConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsUpdateForBusinessConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"automaticUpdateMode", n => { AutomaticUpdateMode = n.GetEnumValue<AutomaticUpdateMode>(); } },
                {"businessReadyUpdatesOnly", n => { BusinessReadyUpdatesOnly = n.GetEnumValue<WindowsUpdateType>(); } },
                {"deliveryOptimizationMode", n => { DeliveryOptimizationMode = n.GetEnumValue<WindowsDeliveryOptimizationMode>(); } },
                {"driversExcluded", n => { DriversExcluded = n.GetBoolValue(); } },
                {"featureUpdatesDeferralPeriodInDays", n => { FeatureUpdatesDeferralPeriodInDays = n.GetIntValue(); } },
                {"featureUpdatesPaused", n => { FeatureUpdatesPaused = n.GetBoolValue(); } },
                {"featureUpdatesPauseExpiryDateTime", n => { FeatureUpdatesPauseExpiryDateTime = n.GetDateTimeOffsetValue(); } },
                {"installationSchedule", n => { InstallationSchedule = n.GetObjectValue<WindowsUpdateInstallScheduleType>(WindowsUpdateInstallScheduleType.CreateFromDiscriminatorValue); } },
                {"microsoftUpdateServiceAllowed", n => { MicrosoftUpdateServiceAllowed = n.GetBoolValue(); } },
                {"prereleaseFeatures", n => { PrereleaseFeatures = n.GetEnumValue<PrereleaseFeatures>(); } },
                {"qualityUpdatesDeferralPeriodInDays", n => { QualityUpdatesDeferralPeriodInDays = n.GetIntValue(); } },
                {"qualityUpdatesPaused", n => { QualityUpdatesPaused = n.GetBoolValue(); } },
                {"qualityUpdatesPauseExpiryDateTime", n => { QualityUpdatesPauseExpiryDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<AutomaticUpdateMode>("automaticUpdateMode", AutomaticUpdateMode);
            writer.WriteEnumValue<WindowsUpdateType>("businessReadyUpdatesOnly", BusinessReadyUpdatesOnly);
            writer.WriteEnumValue<WindowsDeliveryOptimizationMode>("deliveryOptimizationMode", DeliveryOptimizationMode);
            writer.WriteBoolValue("driversExcluded", DriversExcluded);
            writer.WriteIntValue("featureUpdatesDeferralPeriodInDays", FeatureUpdatesDeferralPeriodInDays);
            writer.WriteBoolValue("featureUpdatesPaused", FeatureUpdatesPaused);
            writer.WriteDateTimeOffsetValue("featureUpdatesPauseExpiryDateTime", FeatureUpdatesPauseExpiryDateTime);
            writer.WriteObjectValue<WindowsUpdateInstallScheduleType>("installationSchedule", InstallationSchedule);
            writer.WriteBoolValue("microsoftUpdateServiceAllowed", MicrosoftUpdateServiceAllowed);
            writer.WriteEnumValue<PrereleaseFeatures>("prereleaseFeatures", PrereleaseFeatures);
            writer.WriteIntValue("qualityUpdatesDeferralPeriodInDays", QualityUpdatesDeferralPeriodInDays);
            writer.WriteBoolValue("qualityUpdatesPaused", QualityUpdatesPaused);
            writer.WriteDateTimeOffsetValue("qualityUpdatesPauseExpiryDateTime", QualityUpdatesPauseExpiryDateTime);
        }
    }
}
