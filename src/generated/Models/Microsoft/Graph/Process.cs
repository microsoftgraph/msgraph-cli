using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Process : IParsable {
        /// <summary>User account identifier (user account context the process ran under) for example, AccountName, SID, and so on.</summary>
        public string AccountName { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The full process invocation commandline including all parameters.</summary>
        public string CommandLine { get; set; }
        /// <summary>Time at which the process was started. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Complex type containing file hashes (cryptographic and location-sensitive).</summary>
        public FileHash FileHash { get; set; }
        /// <summary>The integrity level of the process. Possible values are: unknown, untrusted, low, medium, high, system.</summary>
        public ProcessIntegrityLevel? IntegrityLevel { get; set; }
        /// <summary>True if the process is elevated.</summary>
        public bool? IsElevated { get; set; }
        /// <summary>The name of the process' Image file.</summary>
        public string Name { get; set; }
        /// <summary>DateTime at which the parent process was started. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ParentProcessCreatedDateTime { get; set; }
        /// <summary>The Process ID (PID) of the parent process.</summary>
        public int? ParentProcessId { get; set; }
        /// <summary>The name of the image file of the parent process.</summary>
        public string ParentProcessName { get; set; }
        /// <summary>Full path, including filename.</summary>
        public string Path { get; set; }
        /// <summary>The Process ID (PID) of the process.</summary>
        public int? ProcessId { get; set; }
        /// <summary>
        /// Instantiates a new process and sets the default values.
        /// </summary>
        public Process() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"accountName", (o,n) => { (o as Process).AccountName = n.GetStringValue(); } },
                {"commandLine", (o,n) => { (o as Process).CommandLine = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as Process).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"fileHash", (o,n) => { (o as Process).FileHash = n.GetObjectValue<FileHash>(); } },
                {"integrityLevel", (o,n) => { (o as Process).IntegrityLevel = n.GetEnumValue<ProcessIntegrityLevel>(); } },
                {"isElevated", (o,n) => { (o as Process).IsElevated = n.GetBoolValue(); } },
                {"name", (o,n) => { (o as Process).Name = n.GetStringValue(); } },
                {"parentProcessCreatedDateTime", (o,n) => { (o as Process).ParentProcessCreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"parentProcessId", (o,n) => { (o as Process).ParentProcessId = n.GetIntValue(); } },
                {"parentProcessName", (o,n) => { (o as Process).ParentProcessName = n.GetStringValue(); } },
                {"path", (o,n) => { (o as Process).Path = n.GetStringValue(); } },
                {"processId", (o,n) => { (o as Process).ProcessId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("accountName", AccountName);
            writer.WriteStringValue("commandLine", CommandLine);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<FileHash>("fileHash", FileHash);
            writer.WriteEnumValue<ProcessIntegrityLevel>("integrityLevel", IntegrityLevel);
            writer.WriteBoolValue("isElevated", IsElevated);
            writer.WriteStringValue("name", Name);
            writer.WriteDateTimeOffsetValue("parentProcessCreatedDateTime", ParentProcessCreatedDateTime);
            writer.WriteIntValue("parentProcessId", ParentProcessId);
            writer.WriteStringValue("parentProcessName", ParentProcessName);
            writer.WriteStringValue("path", Path);
            writer.WriteIntValue("processId", ProcessId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
