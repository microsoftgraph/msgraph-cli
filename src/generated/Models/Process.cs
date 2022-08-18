using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Process : IAdditionalDataHolder, IParsable {
        /// <summary>User account identifier (user account context the process ran under) for example, AccountName, SID, and so on.</summary>
        public string AccountName { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The full process invocation commandline including all parameters.</summary>
        public string CommandLine { get; set; }
        /// <summary>Time at which the process was started. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Complex type containing file hashes (cryptographic and location-sensitive).</summary>
        public ApiSdk.Models.FileHash FileHash { get; set; }
        /// <summary>The integrity level of the process. Possible values are: unknown, untrusted, low, medium, high, system.</summary>
        public ProcessIntegrityLevel? IntegrityLevel { get; set; }
        /// <summary>True if the process is elevated.</summary>
        public bool? IsElevated { get; set; }
        /// <summary>The name of the process&apos; Image file.</summary>
        public string Name { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>DateTime at which the parent process was started. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ParentProcessCreatedDateTime { get; set; }
        /// <summary>The Process ID (PID) of the parent process.</summary>
        public int? ParentProcessId { get; set; }
        /// <summary>The name of the image file of the parent process.</summary>
        public string ParentProcessName { get; set; }
        /// <summary>Full path, including filename.</summary>
        public string PathObject { get; set; }
        /// <summary>The Process ID (PID) of the process.</summary>
        public int? ProcessId { get; set; }
        /// <summary>
        /// Instantiates a new process and sets the default values.
        /// </summary>
        public Process() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.process";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Process CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Process();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accountName", n => { AccountName = n.GetStringValue(); } },
                {"commandLine", n => { CommandLine = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"fileHash", n => { FileHash = n.GetObjectValue<ApiSdk.Models.FileHash>(ApiSdk.Models.FileHash.CreateFromDiscriminatorValue); } },
                {"integrityLevel", n => { IntegrityLevel = n.GetEnumValue<ProcessIntegrityLevel>(); } },
                {"isElevated", n => { IsElevated = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"parentProcessCreatedDateTime", n => { ParentProcessCreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"parentProcessId", n => { ParentProcessId = n.GetIntValue(); } },
                {"parentProcessName", n => { ParentProcessName = n.GetStringValue(); } },
                {"path", n => { PathObject = n.GetStringValue(); } },
                {"processId", n => { ProcessId = n.GetIntValue(); } },
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
            writer.WriteObjectValue<ApiSdk.Models.FileHash>("fileHash", FileHash);
            writer.WriteEnumValue<ProcessIntegrityLevel>("integrityLevel", IntegrityLevel);
            writer.WriteBoolValue("isElevated", IsElevated);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("parentProcessCreatedDateTime", ParentProcessCreatedDateTime);
            writer.WriteIntValue("parentProcessId", ParentProcessId);
            writer.WriteStringValue("parentProcessName", ParentProcessName);
            writer.WriteStringValue("path", PathObject);
            writer.WriteIntValue("processId", ProcessId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
