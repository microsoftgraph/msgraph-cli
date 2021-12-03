using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WindowsInformationProtection : ManagedAppPolicy, IParsable {
        /// <summary>Navigation property to list of security groups targeted for policy.</summary>
        public List<TargetedManagedAppPolicyAssignment> Assignments { get; set; }
        /// <summary>Specifies whether to allow Azure RMS encryption for WIP</summary>
        public bool? AzureRightsManagementServicesAllowed { get; set; }
        /// <summary>Specifies a recovery certificate that can be used for data recovery of encrypted files. This is the same as the data recovery agent(DRA) certificate for encrypting file system(EFS)</summary>
        public WindowsInformationProtectionDataRecoveryCertificate DataRecoveryCertificate { get; set; }
        /// <summary>WIP enforcement level.See the Enum definition for supported values. Possible values are: noProtection, encryptAndAuditOnly, encryptAuditAndPrompt, encryptAuditAndBlock.</summary>
        public WindowsInformationProtectionEnforcementLevel? EnforcementLevel { get; set; }
        /// <summary>Primary enterprise domain</summary>
        public string EnterpriseDomain { get; set; }
        /// <summary>This is the comma-separated list of internal proxy servers. For example, '157.54.14.28, 157.54.11.118, 10.202.14.167, 157.53.14.163, 157.69.210.59'. These proxies have been configured by the admin to connect to specific resources on the Internet. They are considered to be enterprise network locations. The proxies are only leveraged in configuring the EnterpriseProxiedDomains policy to force traffic to the matched domains through these proxies</summary>
        public List<WindowsInformationProtectionResourceCollection> EnterpriseInternalProxyServers { get; set; }
        /// <summary>Sets the enterprise IP ranges that define the computers in the enterprise network. Data that comes from those computers will be considered part of the enterprise and protected. These locations will be considered a safe destination for enterprise data to be shared to</summary>
        public List<WindowsInformationProtectionIPRangeCollection> EnterpriseIPRanges { get; set; }
        /// <summary>Boolean value that tells the client to accept the configured list and not to use heuristics to attempt to find other subnets. Default is false</summary>
        public bool? EnterpriseIPRangesAreAuthoritative { get; set; }
        /// <summary>This is the list of domains that comprise the boundaries of the enterprise. Data from one of these domains that is sent to a device will be considered enterprise data and protected These locations will be considered a safe destination for enterprise data to be shared to</summary>
        public List<WindowsInformationProtectionResourceCollection> EnterpriseNetworkDomainNames { get; set; }
        /// <summary>List of enterprise domains to be protected</summary>
        public List<WindowsInformationProtectionResourceCollection> EnterpriseProtectedDomainNames { get; set; }
        /// <summary>Contains a list of Enterprise resource domains hosted in the cloud that need to be protected. Connections to these resources are considered enterprise data. If a proxy is paired with a cloud resource, traffic to the cloud resource will be routed through the enterprise network via the denoted proxy server (on Port 80). A proxy server used for this purpose must also be configured using the EnterpriseInternalProxyServers policy</summary>
        public List<WindowsInformationProtectionProxiedDomainCollection> EnterpriseProxiedDomains { get; set; }
        /// <summary>This is a list of proxy servers. Any server not on this list is considered non-enterprise</summary>
        public List<WindowsInformationProtectionResourceCollection> EnterpriseProxyServers { get; set; }
        /// <summary>Boolean value that tells the client to accept the configured list of proxies and not try to detect other work proxies. Default is false</summary>
        public bool? EnterpriseProxyServersAreAuthoritative { get; set; }
        /// <summary>Another way to input exempt apps through xml files</summary>
        public List<WindowsInformationProtectionAppLockerFile> ExemptAppLockerFiles { get; set; }
        /// <summary>Exempt applications can also access enterprise data, but the data handled by those applications are not protected. This is because some critical enterprise applications may have compatibility problems with encrypted data.</summary>
        public List<WindowsInformationProtectionApp> ExemptApps { get; set; }
        /// <summary>Determines whether overlays are added to icons for WIP protected files in Explorer and enterprise only app tiles in the Start menu. Starting in Windows 10, version 1703 this setting also configures the visibility of the WIP icon in the title bar of a WIP-protected app</summary>
        public bool? IconsVisible { get; set; }
        /// <summary>This switch is for the Windows Search Indexer, to allow or disallow indexing of items</summary>
        public bool? IndexingEncryptedStoresOrItemsBlocked { get; set; }
        /// <summary>Indicates if the policy is deployed to any inclusion groups or not.</summary>
        public bool? IsAssigned { get; set; }
        /// <summary>List of domain names that can used for work or personal resource</summary>
        public List<WindowsInformationProtectionResourceCollection> NeutralDomainResources { get; set; }
        /// <summary>Another way to input protected apps through xml files</summary>
        public List<WindowsInformationProtectionAppLockerFile> ProtectedAppLockerFiles { get; set; }
        /// <summary>Protected applications can access enterprise data and the data handled by those applications are protected with encryption</summary>
        public List<WindowsInformationProtectionApp> ProtectedApps { get; set; }
        /// <summary>Specifies whether the protection under lock feature (also known as encrypt under pin) should be configured</summary>
        public bool? ProtectionUnderLockConfigRequired { get; set; }
        /// <summary>This policy controls whether to revoke the WIP keys when a device unenrolls from the management service. If set to 1 (Don't revoke keys), the keys will not be revoked and the user will continue to have access to protected files after unenrollment. If the keys are not revoked, there will be no revoked file cleanup subsequently.</summary>
        public bool? RevokeOnUnenrollDisabled { get; set; }
        /// <summary>TemplateID GUID to use for RMS encryption. The RMS template allows the IT admin to configure the details about who has access to RMS-protected file and how long they have access</summary>
        public string RightsManagementServicesTemplateId { get; set; }
        /// <summary>Specifies a list of file extensions, so that files with these extensions are encrypted when copying from an SMB share within the corporate boundary</summary>
        public List<WindowsInformationProtectionResourceCollection> SmbAutoEncryptedFileExtensions { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as WindowsInformationProtection).Assignments = n.GetCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>().ToList(); } },
                {"azureRightsManagementServicesAllowed", (o,n) => { (o as WindowsInformationProtection).AzureRightsManagementServicesAllowed = n.GetBoolValue(); } },
                {"dataRecoveryCertificate", (o,n) => { (o as WindowsInformationProtection).DataRecoveryCertificate = n.GetObjectValue<WindowsInformationProtectionDataRecoveryCertificate>(); } },
                {"enforcementLevel", (o,n) => { (o as WindowsInformationProtection).EnforcementLevel = n.GetEnumValue<WindowsInformationProtectionEnforcementLevel>(); } },
                {"enterpriseDomain", (o,n) => { (o as WindowsInformationProtection).EnterpriseDomain = n.GetStringValue(); } },
                {"enterpriseInternalProxyServers", (o,n) => { (o as WindowsInformationProtection).EnterpriseInternalProxyServers = n.GetCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>().ToList(); } },
                {"enterpriseIPRanges", (o,n) => { (o as WindowsInformationProtection).EnterpriseIPRanges = n.GetCollectionOfObjectValues<WindowsInformationProtectionIPRangeCollection>().ToList(); } },
                {"enterpriseIPRangesAreAuthoritative", (o,n) => { (o as WindowsInformationProtection).EnterpriseIPRangesAreAuthoritative = n.GetBoolValue(); } },
                {"enterpriseNetworkDomainNames", (o,n) => { (o as WindowsInformationProtection).EnterpriseNetworkDomainNames = n.GetCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>().ToList(); } },
                {"enterpriseProtectedDomainNames", (o,n) => { (o as WindowsInformationProtection).EnterpriseProtectedDomainNames = n.GetCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>().ToList(); } },
                {"enterpriseProxiedDomains", (o,n) => { (o as WindowsInformationProtection).EnterpriseProxiedDomains = n.GetCollectionOfObjectValues<WindowsInformationProtectionProxiedDomainCollection>().ToList(); } },
                {"enterpriseProxyServers", (o,n) => { (o as WindowsInformationProtection).EnterpriseProxyServers = n.GetCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>().ToList(); } },
                {"enterpriseProxyServersAreAuthoritative", (o,n) => { (o as WindowsInformationProtection).EnterpriseProxyServersAreAuthoritative = n.GetBoolValue(); } },
                {"exemptAppLockerFiles", (o,n) => { (o as WindowsInformationProtection).ExemptAppLockerFiles = n.GetCollectionOfObjectValues<WindowsInformationProtectionAppLockerFile>().ToList(); } },
                {"exemptApps", (o,n) => { (o as WindowsInformationProtection).ExemptApps = n.GetCollectionOfObjectValues<WindowsInformationProtectionApp>().ToList(); } },
                {"iconsVisible", (o,n) => { (o as WindowsInformationProtection).IconsVisible = n.GetBoolValue(); } },
                {"indexingEncryptedStoresOrItemsBlocked", (o,n) => { (o as WindowsInformationProtection).IndexingEncryptedStoresOrItemsBlocked = n.GetBoolValue(); } },
                {"isAssigned", (o,n) => { (o as WindowsInformationProtection).IsAssigned = n.GetBoolValue(); } },
                {"neutralDomainResources", (o,n) => { (o as WindowsInformationProtection).NeutralDomainResources = n.GetCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>().ToList(); } },
                {"protectedAppLockerFiles", (o,n) => { (o as WindowsInformationProtection).ProtectedAppLockerFiles = n.GetCollectionOfObjectValues<WindowsInformationProtectionAppLockerFile>().ToList(); } },
                {"protectedApps", (o,n) => { (o as WindowsInformationProtection).ProtectedApps = n.GetCollectionOfObjectValues<WindowsInformationProtectionApp>().ToList(); } },
                {"protectionUnderLockConfigRequired", (o,n) => { (o as WindowsInformationProtection).ProtectionUnderLockConfigRequired = n.GetBoolValue(); } },
                {"revokeOnUnenrollDisabled", (o,n) => { (o as WindowsInformationProtection).RevokeOnUnenrollDisabled = n.GetBoolValue(); } },
                {"rightsManagementServicesTemplateId", (o,n) => { (o as WindowsInformationProtection).RightsManagementServicesTemplateId = n.GetStringValue(); } },
                {"smbAutoEncryptedFileExtensions", (o,n) => { (o as WindowsInformationProtection).SmbAutoEncryptedFileExtensions = n.GetCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>("assignments", Assignments);
            writer.WriteBoolValue("azureRightsManagementServicesAllowed", AzureRightsManagementServicesAllowed);
            writer.WriteObjectValue<WindowsInformationProtectionDataRecoveryCertificate>("dataRecoveryCertificate", DataRecoveryCertificate);
            writer.WriteEnumValue<WindowsInformationProtectionEnforcementLevel>("enforcementLevel", EnforcementLevel);
            writer.WriteStringValue("enterpriseDomain", EnterpriseDomain);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>("enterpriseInternalProxyServers", EnterpriseInternalProxyServers);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionIPRangeCollection>("enterpriseIPRanges", EnterpriseIPRanges);
            writer.WriteBoolValue("enterpriseIPRangesAreAuthoritative", EnterpriseIPRangesAreAuthoritative);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>("enterpriseNetworkDomainNames", EnterpriseNetworkDomainNames);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>("enterpriseProtectedDomainNames", EnterpriseProtectedDomainNames);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionProxiedDomainCollection>("enterpriseProxiedDomains", EnterpriseProxiedDomains);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>("enterpriseProxyServers", EnterpriseProxyServers);
            writer.WriteBoolValue("enterpriseProxyServersAreAuthoritative", EnterpriseProxyServersAreAuthoritative);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionAppLockerFile>("exemptAppLockerFiles", ExemptAppLockerFiles);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionApp>("exemptApps", ExemptApps);
            writer.WriteBoolValue("iconsVisible", IconsVisible);
            writer.WriteBoolValue("indexingEncryptedStoresOrItemsBlocked", IndexingEncryptedStoresOrItemsBlocked);
            writer.WriteBoolValue("isAssigned", IsAssigned);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>("neutralDomainResources", NeutralDomainResources);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionAppLockerFile>("protectedAppLockerFiles", ProtectedAppLockerFiles);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionApp>("protectedApps", ProtectedApps);
            writer.WriteBoolValue("protectionUnderLockConfigRequired", ProtectionUnderLockConfigRequired);
            writer.WriteBoolValue("revokeOnUnenrollDisabled", RevokeOnUnenrollDisabled);
            writer.WriteStringValue("rightsManagementServicesTemplateId", RightsManagementServicesTemplateId);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>("smbAutoEncryptedFileExtensions", SmbAutoEncryptedFileExtensions);
        }
    }
}
