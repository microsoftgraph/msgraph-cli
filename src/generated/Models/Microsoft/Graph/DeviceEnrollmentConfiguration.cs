using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceEnrollmentConfiguration : Entity, IParsable {
        /// <summary>The list of group assignments for the device configuration profile</summary>
        public List<EnrollmentConfigurationAssignment> Assignments { get; set; }
        /// <summary>Created date time in UTC of the device enrollment configuration</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description of the device enrollment configuration</summary>
        public string Description { get; set; }
        /// <summary>The display name of the device enrollment configuration</summary>
        public string DisplayName { get; set; }
        /// <summary>Last modified date time in UTC of the device enrollment configuration</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Priority is used when a user exists in multiple groups that are assigned enrollment configuration. Users are subject only to the configuration with the lowest priority value.</summary>
        public int? Priority { get; set; }
        /// <summary>The version of the device enrollment configuration</summary>
        public int? Version { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as DeviceEnrollmentConfiguration).Assignments = n.GetCollectionOfObjectValues<EnrollmentConfigurationAssignment>().ToList(); } },
                {"createdDateTime", (o,n) => { (o as DeviceEnrollmentConfiguration).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as DeviceEnrollmentConfiguration).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as DeviceEnrollmentConfiguration).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DeviceEnrollmentConfiguration).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"priority", (o,n) => { (o as DeviceEnrollmentConfiguration).Priority = n.GetIntValue(); } },
                {"version", (o,n) => { (o as DeviceEnrollmentConfiguration).Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<EnrollmentConfigurationAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteIntValue("priority", Priority);
            writer.WriteIntValue("version", Version);
        }
    }
}
