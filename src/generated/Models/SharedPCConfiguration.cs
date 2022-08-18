using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class SharedPCConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Specifies how accounts are managed on a shared PC. Only applies when disableAccountManager is false.</summary>
        public SharedPCAccountManagerPolicy AccountManagerPolicy { get; set; }
        /// <summary>Type of accounts that are allowed to share the PC.</summary>
        public SharedPCAllowedAccountType? AllowedAccounts { get; set; }
        /// <summary>Specifies whether local storage is allowed on a shared PC.</summary>
        public bool? AllowLocalStorage { get; set; }
        /// <summary>Disables the account manager for shared PC mode.</summary>
        public bool? DisableAccountManager { get; set; }
        /// <summary>Specifies whether the default shared PC education environment policies should be disabled. For Windows 10 RS2 and later, this policy will be applied without setting Enabled to true.</summary>
        public bool? DisableEduPolicies { get; set; }
        /// <summary>Specifies whether the default shared PC power policies should be disabled.</summary>
        public bool? DisablePowerPolicies { get; set; }
        /// <summary>Disables the requirement to sign in whenever the device wakes up from sleep mode.</summary>
        public bool? DisableSignInOnResume { get; set; }
        /// <summary>Enables shared PC mode and applies the shared pc policies.</summary>
        public bool? Enabled { get; set; }
        /// <summary>Specifies the time in seconds that a device must sit idle before the PC goes to sleep. Setting this value to 0 prevents the sleep timeout from occurring.</summary>
        public int? IdleTimeBeforeSleepInSeconds { get; set; }
        /// <summary>Specifies the display text for the account shown on the sign-in screen which launches the app specified by SetKioskAppUserModelId. Only applies when KioskAppUserModelId is set.</summary>
        public string KioskAppDisplayName { get; set; }
        /// <summary>Specifies the application user model ID of the app to use with assigned access.</summary>
        public string KioskAppUserModelId { get; set; }
        /// <summary>Specifies the daily start time of maintenance hour.</summary>
        public Time? MaintenanceStartTime { get; set; }
        /// <summary>
        /// Instantiates a new SharedPCConfiguration and sets the default values.
        /// </summary>
        public SharedPCConfiguration() : base() {
            OdataType = "#microsoft.graph.sharedPCConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SharedPCConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedPCConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountManagerPolicy", n => { AccountManagerPolicy = n.GetObjectValue<SharedPCAccountManagerPolicy>(SharedPCAccountManagerPolicy.CreateFromDiscriminatorValue); } },
                {"allowedAccounts", n => { AllowedAccounts = n.GetEnumValue<SharedPCAllowedAccountType>(); } },
                {"allowLocalStorage", n => { AllowLocalStorage = n.GetBoolValue(); } },
                {"disableAccountManager", n => { DisableAccountManager = n.GetBoolValue(); } },
                {"disableEduPolicies", n => { DisableEduPolicies = n.GetBoolValue(); } },
                {"disablePowerPolicies", n => { DisablePowerPolicies = n.GetBoolValue(); } },
                {"disableSignInOnResume", n => { DisableSignInOnResume = n.GetBoolValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"idleTimeBeforeSleepInSeconds", n => { IdleTimeBeforeSleepInSeconds = n.GetIntValue(); } },
                {"kioskAppDisplayName", n => { KioskAppDisplayName = n.GetStringValue(); } },
                {"kioskAppUserModelId", n => { KioskAppUserModelId = n.GetStringValue(); } },
                {"maintenanceStartTime", n => { MaintenanceStartTime = n.GetTimeValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<SharedPCAccountManagerPolicy>("accountManagerPolicy", AccountManagerPolicy);
            writer.WriteEnumValue<SharedPCAllowedAccountType>("allowedAccounts", AllowedAccounts);
            writer.WriteBoolValue("allowLocalStorage", AllowLocalStorage);
            writer.WriteBoolValue("disableAccountManager", DisableAccountManager);
            writer.WriteBoolValue("disableEduPolicies", DisableEduPolicies);
            writer.WriteBoolValue("disablePowerPolicies", DisablePowerPolicies);
            writer.WriteBoolValue("disableSignInOnResume", DisableSignInOnResume);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteIntValue("idleTimeBeforeSleepInSeconds", IdleTimeBeforeSleepInSeconds);
            writer.WriteStringValue("kioskAppDisplayName", KioskAppDisplayName);
            writer.WriteStringValue("kioskAppUserModelId", KioskAppUserModelId);
            writer.WriteTimeValue("maintenanceStartTime", MaintenanceStartTime);
        }
    }
}
