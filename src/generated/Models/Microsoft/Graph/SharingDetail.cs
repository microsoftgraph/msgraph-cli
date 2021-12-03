using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SharingDetail : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The user who shared the document.</summary>
        public InsightIdentity SharedBy { get; set; }
        /// <summary>The date and time the file was last shared. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? SharedDateTime { get; set; }
        public ResourceReference SharingReference { get; set; }
        /// <summary>The subject with which the document was shared.</summary>
        public string SharingSubject { get; set; }
        /// <summary>Determines the way the document was shared, can be by a 'Link', 'Attachment', 'Group', 'Site'.</summary>
        public string SharingType { get; set; }
        /// <summary>
        /// Instantiates a new sharingDetail and sets the default values.
        /// </summary>
        public SharingDetail() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"sharedBy", (o,n) => { (o as SharingDetail).SharedBy = n.GetObjectValue<InsightIdentity>(); } },
                {"sharedDateTime", (o,n) => { (o as SharingDetail).SharedDateTime = n.GetDateTimeOffsetValue(); } },
                {"sharingReference", (o,n) => { (o as SharingDetail).SharingReference = n.GetObjectValue<ResourceReference>(); } },
                {"sharingSubject", (o,n) => { (o as SharingDetail).SharingSubject = n.GetStringValue(); } },
                {"sharingType", (o,n) => { (o as SharingDetail).SharingType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<InsightIdentity>("sharedBy", SharedBy);
            writer.WriteDateTimeOffsetValue("sharedDateTime", SharedDateTime);
            writer.WriteObjectValue<ResourceReference>("sharingReference", SharingReference);
            writer.WriteStringValue("sharingSubject", SharingSubject);
            writer.WriteStringValue("sharingType", SharingType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
