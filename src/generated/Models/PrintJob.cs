using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class PrintJob : Entity, IParsable {
        /// <summary>The configuration property</summary>
        public PrintJobConfiguration Configuration { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public UserIdentity CreatedBy { get; set; }
        /// <summary>The DateTimeOffset when the job was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Read-only.</summary>
        public List<PrintDocument> Documents { get; set; }
        /// <summary>If true, document can be fetched by printer.</summary>
        public bool? IsFetchable { get; set; }
        /// <summary>Contains the source job URL, if the job has been redirected from another printer.</summary>
        public string RedirectedFrom { get; set; }
        /// <summary>Contains the destination job URL, if the job has been redirected to another printer.</summary>
        public string RedirectedTo { get; set; }
        /// <summary>The status property</summary>
        public PrintJobStatus Status { get; set; }
        /// <summary>A list of printTasks that were triggered by this print job.</summary>
        public List<PrintTask> Tasks { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrintJob CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrintJob();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configuration", n => { Configuration = n.GetObjectValue<PrintJobConfiguration>(PrintJobConfiguration.CreateFromDiscriminatorValue); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"documents", n => { Documents = n.GetCollectionOfObjectValues<PrintDocument>(PrintDocument.CreateFromDiscriminatorValue).ToList(); } },
                {"isFetchable", n => { IsFetchable = n.GetBoolValue(); } },
                {"redirectedFrom", n => { RedirectedFrom = n.GetStringValue(); } },
                {"redirectedTo", n => { RedirectedTo = n.GetStringValue(); } },
                {"status", n => { Status = n.GetObjectValue<PrintJobStatus>(PrintJobStatus.CreateFromDiscriminatorValue); } },
                {"tasks", n => { Tasks = n.GetCollectionOfObjectValues<PrintTask>(PrintTask.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PrintJobConfiguration>("configuration", Configuration);
            writer.WriteObjectValue<UserIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<PrintDocument>("documents", Documents);
            writer.WriteBoolValue("isFetchable", IsFetchable);
            writer.WriteStringValue("redirectedFrom", RedirectedFrom);
            writer.WriteStringValue("redirectedTo", RedirectedTo);
            writer.WriteObjectValue<PrintJobStatus>("status", Status);
            writer.WriteCollectionOfObjectValues<PrintTask>("tasks", Tasks);
        }
    }
}
