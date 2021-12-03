using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ManagedAppRegistration : Entity, IParsable {
        /// <summary>The app package Identifier</summary>
        public MobileAppIdentifier AppIdentifier { get; set; }
        /// <summary>App version</summary>
        public string ApplicationVersion { get; set; }
        /// <summary>Zero or more policys already applied on the registered app when it last synchronized with managment service.</summary>
        public List<ManagedAppPolicy> AppliedPolicies { get; set; }
        /// <summary>Date and time of creation</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Host device name</summary>
        public string DeviceName { get; set; }
        /// <summary>App management SDK generated tag, which helps relate apps hosted on the same device. Not guaranteed to relate apps in all conditions.</summary>
        public string DeviceTag { get; set; }
        /// <summary>Host device type</summary>
        public string DeviceType { get; set; }
        /// <summary>Zero or more reasons an app registration is flagged. E.g. app running on rooted device</summary>
        public List<ManagedAppFlaggedReason?> FlaggedReasons { get; set; }
        /// <summary>Zero or more policies admin intended for the app as of now.</summary>
        public List<ManagedAppPolicy> IntendedPolicies { get; set; }
        /// <summary>Date and time of last the app synced with management service.</summary>
        public DateTimeOffset? LastSyncDateTime { get; set; }
        /// <summary>App management SDK version</summary>
        public string ManagementSdkVersion { get; set; }
        /// <summary>Zero or more long running operations triggered on the app registration.</summary>
        public List<ManagedAppOperation> Operations { get; set; }
        /// <summary>Operating System version</summary>
        public string PlatformVersion { get; set; }
        /// <summary>The user Id to who this app registration belongs.</summary>
        public string UserId { get; set; }
        /// <summary>Version of the entity.</summary>
        public string Version { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appIdentifier", (o,n) => { (o as ManagedAppRegistration).AppIdentifier = n.GetObjectValue<MobileAppIdentifier>(); } },
                {"applicationVersion", (o,n) => { (o as ManagedAppRegistration).ApplicationVersion = n.GetStringValue(); } },
                {"appliedPolicies", (o,n) => { (o as ManagedAppRegistration).AppliedPolicies = n.GetCollectionOfObjectValues<ManagedAppPolicy>().ToList(); } },
                {"createdDateTime", (o,n) => { (o as ManagedAppRegistration).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceName", (o,n) => { (o as ManagedAppRegistration).DeviceName = n.GetStringValue(); } },
                {"deviceTag", (o,n) => { (o as ManagedAppRegistration).DeviceTag = n.GetStringValue(); } },
                {"deviceType", (o,n) => { (o as ManagedAppRegistration).DeviceType = n.GetStringValue(); } },
                {"flaggedReasons", (o,n) => { (o as ManagedAppRegistration).FlaggedReasons = n.GetCollectionOfEnumValues<ManagedAppFlaggedReason>().ToList(); } },
                {"intendedPolicies", (o,n) => { (o as ManagedAppRegistration).IntendedPolicies = n.GetCollectionOfObjectValues<ManagedAppPolicy>().ToList(); } },
                {"lastSyncDateTime", (o,n) => { (o as ManagedAppRegistration).LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"managementSdkVersion", (o,n) => { (o as ManagedAppRegistration).ManagementSdkVersion = n.GetStringValue(); } },
                {"operations", (o,n) => { (o as ManagedAppRegistration).Operations = n.GetCollectionOfObjectValues<ManagedAppOperation>().ToList(); } },
                {"platformVersion", (o,n) => { (o as ManagedAppRegistration).PlatformVersion = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as ManagedAppRegistration).UserId = n.GetStringValue(); } },
                {"version", (o,n) => { (o as ManagedAppRegistration).Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MobileAppIdentifier>("appIdentifier", AppIdentifier);
            writer.WriteStringValue("applicationVersion", ApplicationVersion);
            writer.WriteCollectionOfObjectValues<ManagedAppPolicy>("appliedPolicies", AppliedPolicies);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("deviceTag", DeviceTag);
            writer.WriteStringValue("deviceType", DeviceType);
            writer.WriteCollectionOfEnumValues<ManagedAppFlaggedReason>("flaggedReasons", FlaggedReasons);
            writer.WriteCollectionOfObjectValues<ManagedAppPolicy>("intendedPolicies", IntendedPolicies);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteStringValue("managementSdkVersion", ManagementSdkVersion);
            writer.WriteCollectionOfObjectValues<ManagedAppOperation>("operations", Operations);
            writer.WriteStringValue("platformVersion", PlatformVersion);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("version", Version);
        }
    }
}
