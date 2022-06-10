using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Devices that are managed or pre-enrolled through Intune</summary>
    public class ManagedDevice : Entity, IParsable {
        /// <summary>Code that allows the Activation Lock on a device to be bypassed. This property is read-only.</summary>
        public string ActivationLockBypassCode { get; set; }
        /// <summary>Android security patch level. This property is read-only.</summary>
        public string AndroidSecurityPatchLevel { get; set; }
        /// <summary>The unique identifier for the Azure Active Directory device. Read only. This property is read-only.</summary>
        public string AzureADDeviceId { get; set; }
        /// <summary>Whether the device is Azure Active Directory registered. This property is read-only.</summary>
        public bool? AzureADRegistered { get; set; }
        /// <summary>The DateTime when device compliance grace period expires. This property is read-only.</summary>
        public DateTimeOffset? ComplianceGracePeriodExpirationDateTime { get; set; }
        /// <summary>Compliance state of the device. This property is read-only. Possible values are: unknown, compliant, noncompliant, conflict, error, inGracePeriod, configManager.</summary>
        public ApiSdk.Models.ComplianceState? ComplianceState { get; set; }
        /// <summary>ConfigrMgr client enabled features. This property is read-only.</summary>
        public ApiSdk.Models.ConfigurationManagerClientEnabledFeatures ConfigurationManagerClientEnabledFeatures { get; set; }
        /// <summary>List of ComplexType deviceActionResult objects. This property is read-only.</summary>
        public List<DeviceActionResult> DeviceActionResults { get; set; }
        /// <summary>Device category</summary>
        public ApiSdk.Models.DeviceCategory DeviceCategory { get; set; }
        /// <summary>Device category display name. This property is read-only.</summary>
        public string DeviceCategoryDisplayName { get; set; }
        /// <summary>Device compliance policy states for this device.</summary>
        public List<DeviceCompliancePolicyState> DeviceCompliancePolicyStates { get; set; }
        /// <summary>Device configuration states for this device.</summary>
        public List<DeviceConfigurationState> DeviceConfigurationStates { get; set; }
        /// <summary>Enrollment type of the device. This property is read-only. Possible values are: unknown, userEnrollment, deviceEnrollmentManager, appleBulkWithUser, appleBulkWithoutUser, windowsAzureADJoin, windowsBulkUserless, windowsAutoEnrollment, windowsBulkAzureDomainJoin, windowsCoManagement, windowsAzureADJoinUsingDeviceAuth, appleUserEnrollment, appleUserEnrollmentWithServiceAccount, azureAdJoinUsingAzureVmExtension, androidEnterpriseDedicatedDevice, androidEnterpriseFullyManaged, androidEnterpriseCorporateWorkProfile.</summary>
        public ApiSdk.Models.DeviceEnrollmentType? DeviceEnrollmentType { get; set; }
        /// <summary>The device health attestation state. This property is read-only.</summary>
        public ApiSdk.Models.DeviceHealthAttestationState DeviceHealthAttestationState { get; set; }
        /// <summary>Name of the device. This property is read-only.</summary>
        public string DeviceName { get; set; }
        /// <summary>Device registration state. This property is read-only. Possible values are: notRegistered, registered, revoked, keyConflict, approvalPending, certificateReset, notRegisteredPendingEnrollment, unknown.</summary>
        public ApiSdk.Models.DeviceRegistrationState? DeviceRegistrationState { get; set; }
        /// <summary>Whether the device is Exchange ActiveSync activated. This property is read-only.</summary>
        public bool? EasActivated { get; set; }
        /// <summary>Exchange ActivationSync activation time of the device. This property is read-only.</summary>
        public DateTimeOffset? EasActivationDateTime { get; set; }
        /// <summary>Exchange ActiveSync Id of the device. This property is read-only.</summary>
        public string EasDeviceId { get; set; }
        /// <summary>Email(s) for the user associated with the device. This property is read-only.</summary>
        public string EmailAddress { get; set; }
        /// <summary>Enrollment time of the device. This property is read-only.</summary>
        public DateTimeOffset? EnrolledDateTime { get; set; }
        /// <summary>Ethernet MAC. This property is read-only.</summary>
        public string EthernetMacAddress { get; set; }
        /// <summary>The Access State of the device in Exchange. This property is read-only. Possible values are: none, unknown, allowed, blocked, quarantined.</summary>
        public DeviceManagementExchangeAccessState? ExchangeAccessState { get; set; }
        /// <summary>The reason for the device&apos;s access state in Exchange. This property is read-only. Possible values are: none, unknown, exchangeGlobalRule, exchangeIndividualRule, exchangeDeviceRule, exchangeUpgrade, exchangeMailboxPolicy, other, compliant, notCompliant, notEnrolled, unknownLocation, mfaRequired, azureADBlockDueToAccessPolicy, compromisedPassword, deviceNotKnownWithManagedApp.</summary>
        public DeviceManagementExchangeAccessStateReason? ExchangeAccessStateReason { get; set; }
        /// <summary>Last time the device contacted Exchange. This property is read-only.</summary>
        public DateTimeOffset? ExchangeLastSuccessfulSyncDateTime { get; set; }
        /// <summary>Free Storage in Bytes. This property is read-only.</summary>
        public long? FreeStorageSpaceInBytes { get; set; }
        /// <summary>Integrated Circuit Card Identifier, it is A SIM card&apos;s unique identification number. This property is read-only.</summary>
        public string Iccid { get; set; }
        /// <summary>IMEI. This property is read-only.</summary>
        public string Imei { get; set; }
        /// <summary>Device encryption status. This property is read-only.</summary>
        public bool? IsEncrypted { get; set; }
        /// <summary>Device supervised status. This property is read-only.</summary>
        public bool? IsSupervised { get; set; }
        /// <summary>whether the device is jail broken or rooted. This property is read-only.</summary>
        public string JailBroken { get; set; }
        /// <summary>The date and time that the device last completed a successful sync with Intune. This property is read-only.</summary>
        public DateTimeOffset? LastSyncDateTime { get; set; }
        /// <summary>Automatically generated name to identify a device. Can be overwritten to a user friendly name.</summary>
        public string ManagedDeviceName { get; set; }
        /// <summary>Ownership of the device. Can be &apos;company&apos; or &apos;personal&apos;. Possible values are: unknown, company, personal.</summary>
        public ApiSdk.Models.ManagedDeviceOwnerType? ManagedDeviceOwnerType { get; set; }
        /// <summary>Management channel of the device. Intune, EAS, etc. This property is read-only. Possible values are: eas, mdm, easMdm, intuneClient, easIntuneClient, configurationManagerClient, configurationManagerClientMdm, configurationManagerClientMdmEas, unknown, jamf, googleCloudDevicePolicyController, microsoft365ManagedMdm, msSense, intuneAosp.</summary>
        public ManagementAgentType? ManagementAgent { get; set; }
        /// <summary>Manufacturer of the device. This property is read-only.</summary>
        public string Manufacturer { get; set; }
        /// <summary>MEID. This property is read-only.</summary>
        public string Meid { get; set; }
        /// <summary>Model of the device. This property is read-only.</summary>
        public string Model { get; set; }
        /// <summary>Notes on the device created by IT Admin</summary>
        public string Notes { get; set; }
        /// <summary>Operating system of the device. Windows, iOS, etc. This property is read-only.</summary>
        public string OperatingSystem { get; set; }
        /// <summary>Operating system version of the device. This property is read-only.</summary>
        public string OsVersion { get; set; }
        /// <summary>Indicates the threat state of a device when a Mobile Threat Defense partner is in use by the account and device. Read Only. This property is read-only. Possible values are: unknown, activated, deactivated, secured, lowSeverity, mediumSeverity, highSeverity, unresponsive, compromised, misconfigured.</summary>
        public ManagedDevicePartnerReportedHealthState? PartnerReportedThreatState { get; set; }
        /// <summary>Phone number of the device. This property is read-only.</summary>
        public string PhoneNumber { get; set; }
        /// <summary>Total Memory in Bytes. This property is read-only.</summary>
        public long? PhysicalMemoryInBytes { get; set; }
        /// <summary>An error string that identifies issues when creating Remote Assistance session objects. This property is read-only.</summary>
        public string RemoteAssistanceSessionErrorDetails { get; set; }
        /// <summary>Url that allows a Remote Assistance session to be established with the device. This property is read-only.</summary>
        public string RemoteAssistanceSessionUrl { get; set; }
        /// <summary>SerialNumber. This property is read-only.</summary>
        public string SerialNumber { get; set; }
        /// <summary>Subscriber Carrier. This property is read-only.</summary>
        public string SubscriberCarrier { get; set; }
        /// <summary>Total Storage in Bytes. This property is read-only.</summary>
        public long? TotalStorageSpaceInBytes { get; set; }
        /// <summary>Unique Device Identifier for iOS and macOS devices. This property is read-only.</summary>
        public string Udid { get; set; }
        /// <summary>User display name. This property is read-only.</summary>
        public string UserDisplayName { get; set; }
        /// <summary>Unique Identifier for the user associated with the device. This property is read-only.</summary>
        public string UserId { get; set; }
        /// <summary>Device user principal name. This property is read-only.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>Wi-Fi MAC. This property is read-only.</summary>
        public string WiFiMacAddress { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activationLockBypassCode", n => { ActivationLockBypassCode = n.GetStringValue(); } },
                {"androidSecurityPatchLevel", n => { AndroidSecurityPatchLevel = n.GetStringValue(); } },
                {"azureADDeviceId", n => { AzureADDeviceId = n.GetStringValue(); } },
                {"azureADRegistered", n => { AzureADRegistered = n.GetBoolValue(); } },
                {"complianceGracePeriodExpirationDateTime", n => { ComplianceGracePeriodExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"complianceState", n => { ComplianceState = n.GetEnumValue<ComplianceState>(); } },
                {"configurationManagerClientEnabledFeatures", n => { ConfigurationManagerClientEnabledFeatures = n.GetObjectValue<ApiSdk.Models.ConfigurationManagerClientEnabledFeatures>(ApiSdk.Models.ConfigurationManagerClientEnabledFeatures.CreateFromDiscriminatorValue); } },
                {"deviceActionResults", n => { DeviceActionResults = n.GetCollectionOfObjectValues<DeviceActionResult>(DeviceActionResult.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceCategory", n => { DeviceCategory = n.GetObjectValue<ApiSdk.Models.DeviceCategory>(ApiSdk.Models.DeviceCategory.CreateFromDiscriminatorValue); } },
                {"deviceCategoryDisplayName", n => { DeviceCategoryDisplayName = n.GetStringValue(); } },
                {"deviceCompliancePolicyStates", n => { DeviceCompliancePolicyStates = n.GetCollectionOfObjectValues<DeviceCompliancePolicyState>(DeviceCompliancePolicyState.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceConfigurationStates", n => { DeviceConfigurationStates = n.GetCollectionOfObjectValues<DeviceConfigurationState>(DeviceConfigurationState.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceEnrollmentType", n => { DeviceEnrollmentType = n.GetEnumValue<DeviceEnrollmentType>(); } },
                {"deviceHealthAttestationState", n => { DeviceHealthAttestationState = n.GetObjectValue<ApiSdk.Models.DeviceHealthAttestationState>(ApiSdk.Models.DeviceHealthAttestationState.CreateFromDiscriminatorValue); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"deviceRegistrationState", n => { DeviceRegistrationState = n.GetEnumValue<DeviceRegistrationState>(); } },
                {"easActivated", n => { EasActivated = n.GetBoolValue(); } },
                {"easActivationDateTime", n => { EasActivationDateTime = n.GetDateTimeOffsetValue(); } },
                {"easDeviceId", n => { EasDeviceId = n.GetStringValue(); } },
                {"emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                {"enrolledDateTime", n => { EnrolledDateTime = n.GetDateTimeOffsetValue(); } },
                {"ethernetMacAddress", n => { EthernetMacAddress = n.GetStringValue(); } },
                {"exchangeAccessState", n => { ExchangeAccessState = n.GetEnumValue<DeviceManagementExchangeAccessState>(); } },
                {"exchangeAccessStateReason", n => { ExchangeAccessStateReason = n.GetEnumValue<DeviceManagementExchangeAccessStateReason>(); } },
                {"exchangeLastSuccessfulSyncDateTime", n => { ExchangeLastSuccessfulSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"freeStorageSpaceInBytes", n => { FreeStorageSpaceInBytes = n.GetLongValue(); } },
                {"iccid", n => { Iccid = n.GetStringValue(); } },
                {"imei", n => { Imei = n.GetStringValue(); } },
                {"isEncrypted", n => { IsEncrypted = n.GetBoolValue(); } },
                {"isSupervised", n => { IsSupervised = n.GetBoolValue(); } },
                {"jailBroken", n => { JailBroken = n.GetStringValue(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceName", n => { ManagedDeviceName = n.GetStringValue(); } },
                {"managedDeviceOwnerType", n => { ManagedDeviceOwnerType = n.GetEnumValue<ManagedDeviceOwnerType>(); } },
                {"managementAgent", n => { ManagementAgent = n.GetEnumValue<ManagementAgentType>(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"meid", n => { Meid = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"partnerReportedThreatState", n => { PartnerReportedThreatState = n.GetEnumValue<ManagedDevicePartnerReportedHealthState>(); } },
                {"phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"physicalMemoryInBytes", n => { PhysicalMemoryInBytes = n.GetLongValue(); } },
                {"remoteAssistanceSessionErrorDetails", n => { RemoteAssistanceSessionErrorDetails = n.GetStringValue(); } },
                {"remoteAssistanceSessionUrl", n => { RemoteAssistanceSessionUrl = n.GetStringValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"subscriberCarrier", n => { SubscriberCarrier = n.GetStringValue(); } },
                {"totalStorageSpaceInBytes", n => { TotalStorageSpaceInBytes = n.GetLongValue(); } },
                {"udid", n => { Udid = n.GetStringValue(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"wiFiMacAddress", n => { WiFiMacAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("activationLockBypassCode", ActivationLockBypassCode);
            writer.WriteStringValue("androidSecurityPatchLevel", AndroidSecurityPatchLevel);
            writer.WriteStringValue("azureADDeviceId", AzureADDeviceId);
            writer.WriteBoolValue("azureADRegistered", AzureADRegistered);
            writer.WriteDateTimeOffsetValue("complianceGracePeriodExpirationDateTime", ComplianceGracePeriodExpirationDateTime);
            writer.WriteEnumValue<ComplianceState>("complianceState", ComplianceState);
            writer.WriteObjectValue<ApiSdk.Models.ConfigurationManagerClientEnabledFeatures>("configurationManagerClientEnabledFeatures", ConfigurationManagerClientEnabledFeatures);
            writer.WriteCollectionOfObjectValues<DeviceActionResult>("deviceActionResults", DeviceActionResults);
            writer.WriteObjectValue<ApiSdk.Models.DeviceCategory>("deviceCategory", DeviceCategory);
            writer.WriteStringValue("deviceCategoryDisplayName", DeviceCategoryDisplayName);
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicyState>("deviceCompliancePolicyStates", DeviceCompliancePolicyStates);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationState>("deviceConfigurationStates", DeviceConfigurationStates);
            writer.WriteEnumValue<DeviceEnrollmentType>("deviceEnrollmentType", DeviceEnrollmentType);
            writer.WriteObjectValue<ApiSdk.Models.DeviceHealthAttestationState>("deviceHealthAttestationState", DeviceHealthAttestationState);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteEnumValue<DeviceRegistrationState>("deviceRegistrationState", DeviceRegistrationState);
            writer.WriteBoolValue("easActivated", EasActivated);
            writer.WriteDateTimeOffsetValue("easActivationDateTime", EasActivationDateTime);
            writer.WriteStringValue("easDeviceId", EasDeviceId);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteDateTimeOffsetValue("enrolledDateTime", EnrolledDateTime);
            writer.WriteStringValue("ethernetMacAddress", EthernetMacAddress);
            writer.WriteEnumValue<DeviceManagementExchangeAccessState>("exchangeAccessState", ExchangeAccessState);
            writer.WriteEnumValue<DeviceManagementExchangeAccessStateReason>("exchangeAccessStateReason", ExchangeAccessStateReason);
            writer.WriteDateTimeOffsetValue("exchangeLastSuccessfulSyncDateTime", ExchangeLastSuccessfulSyncDateTime);
            writer.WriteLongValue("freeStorageSpaceInBytes", FreeStorageSpaceInBytes);
            writer.WriteStringValue("iccid", Iccid);
            writer.WriteStringValue("imei", Imei);
            writer.WriteBoolValue("isEncrypted", IsEncrypted);
            writer.WriteBoolValue("isSupervised", IsSupervised);
            writer.WriteStringValue("jailBroken", JailBroken);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteStringValue("managedDeviceName", ManagedDeviceName);
            writer.WriteEnumValue<ManagedDeviceOwnerType>("managedDeviceOwnerType", ManagedDeviceOwnerType);
            writer.WriteEnumValue<ManagementAgentType>("managementAgent", ManagementAgent);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("meid", Meid);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("notes", Notes);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteEnumValue<ManagedDevicePartnerReportedHealthState>("partnerReportedThreatState", PartnerReportedThreatState);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteLongValue("physicalMemoryInBytes", PhysicalMemoryInBytes);
            writer.WriteStringValue("remoteAssistanceSessionErrorDetails", RemoteAssistanceSessionErrorDetails);
            writer.WriteStringValue("remoteAssistanceSessionUrl", RemoteAssistanceSessionUrl);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteStringValue("subscriberCarrier", SubscriberCarrier);
            writer.WriteLongValue("totalStorageSpaceInBytes", TotalStorageSpaceInBytes);
            writer.WriteStringValue("udid", Udid);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteStringValue("wiFiMacAddress", WiFiMacAddress);
        }
    }
}
