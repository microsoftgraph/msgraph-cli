using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Security {
    public class ProcessEvidence : AlertEvidence, IParsable {
        /// <summary>The status of the detection.The possible values are: detected, blocked, prevented, unknownFutureValue.</summary>
        public ApiSdk.Models.Security.DetectionStatus? DetectionStatus { get; set; }
        /// <summary>Image file details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FileDetails? ImageFile { get; set; }
#nullable restore
#else
        public FileDetails ImageFile { get; set; }
#endif
        /// <summary>A unique identifier assigned to a device by Microsoft Defender for Endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MdeDeviceId { get; set; }
#nullable restore
#else
        public string MdeDeviceId { get; set; }
#endif
        /// <summary>Date and time when the parent of the process was created.</summary>
        public DateTimeOffset? ParentProcessCreationDateTime { get; set; }
        /// <summary>Process ID (PID) of the parent process that spawned the process.</summary>
        public long? ParentProcessId { get; set; }
        /// <summary>Parent process image file details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FileDetails? ParentProcessImageFile { get; set; }
#nullable restore
#else
        public FileDetails ParentProcessImageFile { get; set; }
#endif
        /// <summary>Command line used to create the new process.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProcessCommandLine { get; set; }
#nullable restore
#else
        public string ProcessCommandLine { get; set; }
#endif
        /// <summary>Date and time the process was created.</summary>
        public DateTimeOffset? ProcessCreationDateTime { get; set; }
        /// <summary>Process ID (PID) of the newly created process.</summary>
        public long? ProcessId { get; set; }
        /// <summary>User details of the user that ran the process.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Security.UserAccount? UserAccount { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Security.UserAccount UserAccount { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ProcessEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProcessEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"detectionStatus", n => { DetectionStatus = n.GetEnumValue<DetectionStatus>(); } },
                {"imageFile", n => { ImageFile = n.GetObjectValue<FileDetails>(FileDetails.CreateFromDiscriminatorValue); } },
                {"mdeDeviceId", n => { MdeDeviceId = n.GetStringValue(); } },
                {"parentProcessCreationDateTime", n => { ParentProcessCreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"parentProcessId", n => { ParentProcessId = n.GetLongValue(); } },
                {"parentProcessImageFile", n => { ParentProcessImageFile = n.GetObjectValue<FileDetails>(FileDetails.CreateFromDiscriminatorValue); } },
                {"processCommandLine", n => { ProcessCommandLine = n.GetStringValue(); } },
                {"processCreationDateTime", n => { ProcessCreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"processId", n => { ProcessId = n.GetLongValue(); } },
                {"userAccount", n => { UserAccount = n.GetObjectValue<ApiSdk.Models.Security.UserAccount>(ApiSdk.Models.Security.UserAccount.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DetectionStatus>("detectionStatus", DetectionStatus);
            writer.WriteObjectValue<FileDetails>("imageFile", ImageFile);
            writer.WriteStringValue("mdeDeviceId", MdeDeviceId);
            writer.WriteDateTimeOffsetValue("parentProcessCreationDateTime", ParentProcessCreationDateTime);
            writer.WriteLongValue("parentProcessId", ParentProcessId);
            writer.WriteObjectValue<FileDetails>("parentProcessImageFile", ParentProcessImageFile);
            writer.WriteStringValue("processCommandLine", ProcessCommandLine);
            writer.WriteDateTimeOffsetValue("processCreationDateTime", ProcessCreationDateTime);
            writer.WriteLongValue("processId", ProcessId);
            writer.WriteObjectValue<ApiSdk.Models.Security.UserAccount>("userAccount", UserAccount);
        }
    }
}
