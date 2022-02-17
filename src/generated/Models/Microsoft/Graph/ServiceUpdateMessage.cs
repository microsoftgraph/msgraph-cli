using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ServiceUpdateMessage : ServiceAnnouncementBase, IParsable {
        /// <summary>The expected deadline of the action for the message.</summary>
        public DateTimeOffset? ActionRequiredByDateTime { get; set; }
        /// <summary>A collection of serviceAnnouncementAttachments.</summary>
        public List<ServiceAnnouncementAttachment> Attachments { get; set; }
        /// <summary>The zip file of all attachments for a message.</summary>
        public byte[] AttachmentsArchive { get; set; }
        public ItemBody Body { get; set; }
        /// <summary>The service message category. Possible values are: preventOrFixIssue, planForChange, stayInformed, unknownFutureValue.</summary>
        public ServiceUpdateCategory? Category { get; set; }
        /// <summary>Indicates whether the message has any attachment.</summary>
        public bool? HasAttachments { get; set; }
        /// <summary>Indicates whether the message describes a major update for the service.</summary>
        public bool? IsMajorChange { get; set; }
        /// <summary>The affected services by the service message.</summary>
        public List<string> Services { get; set; }
        /// <summary>The severity of the service message. Possible values are: normal, high, critical, unknownFutureValue.</summary>
        public ServiceUpdateSeverity? Severity { get; set; }
        /// <summary>A collection of tags for the service message. Tags are provided by the service team/support team who post the message to tell whether this message contains privacy data, or whether this message is for a service new feature update, and so on.</summary>
        public List<string> Tags { get; set; }
        /// <summary>Represents user viewpoints data of the service message. This data includes message status such as whether the user has archived, read, or marked the message as favorite. This property is null when accessed with application permissions.</summary>
        public ServiceUpdateMessageViewpoint ViewPoint { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"actionRequiredByDateTime", (o,n) => { (o as ServiceUpdateMessage).ActionRequiredByDateTime = n.GetDateTimeOffsetValue(); } },
                {"attachments", (o,n) => { (o as ServiceUpdateMessage).Attachments = n.GetCollectionOfObjectValues<ServiceAnnouncementAttachment>().ToList(); } },
                {"attachmentsArchive", (o,n) => { (o as ServiceUpdateMessage).AttachmentsArchive = n.GetByteArrayValue(); } },
                {"body", (o,n) => { (o as ServiceUpdateMessage).Body = n.GetObjectValue<ItemBody>(); } },
                {"category", (o,n) => { (o as ServiceUpdateMessage).Category = n.GetEnumValue<ServiceUpdateCategory>(); } },
                {"hasAttachments", (o,n) => { (o as ServiceUpdateMessage).HasAttachments = n.GetBoolValue(); } },
                {"isMajorChange", (o,n) => { (o as ServiceUpdateMessage).IsMajorChange = n.GetBoolValue(); } },
                {"services", (o,n) => { (o as ServiceUpdateMessage).Services = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"severity", (o,n) => { (o as ServiceUpdateMessage).Severity = n.GetEnumValue<ServiceUpdateSeverity>(); } },
                {"tags", (o,n) => { (o as ServiceUpdateMessage).Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"viewPoint", (o,n) => { (o as ServiceUpdateMessage).ViewPoint = n.GetObjectValue<ServiceUpdateMessageViewpoint>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("actionRequiredByDateTime", ActionRequiredByDateTime);
            writer.WriteCollectionOfObjectValues<ServiceAnnouncementAttachment>("attachments", Attachments);
            writer.WriteByteArrayValue("attachmentsArchive", AttachmentsArchive);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteEnumValue<ServiceUpdateCategory>("category", Category);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteBoolValue("isMajorChange", IsMajorChange);
            writer.WriteCollectionOfPrimitiveValues<string>("services", Services);
            writer.WriteEnumValue<ServiceUpdateSeverity>("severity", Severity);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteObjectValue<ServiceUpdateMessageViewpoint>("viewPoint", ViewPoint);
        }
    }
}
