using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class SharingDetail : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The user who shared the document.</summary>
        public InsightIdentity SharedBy { get; set; }
        /// <summary>The date and time the file was last shared. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? SharedDateTime { get; set; }
        /// <summary>The sharingReference property</summary>
        public ResourceReference SharingReference { get; private set; }
        /// <summary>The subject with which the document was shared.</summary>
        public string SharingSubject { get; set; }
        /// <summary>Determines the way the document was shared, can be by a &apos;Link&apos;, &apos;Attachment&apos;, &apos;Group&apos;, &apos;Site&apos;.</summary>
        public string SharingType { get; set; }
        /// <summary>
        /// Instantiates a new sharingDetail and sets the default values.
        /// </summary>
        public SharingDetail() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.sharingDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SharingDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharingDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"sharedBy", n => { SharedBy = n.GetObjectValue<InsightIdentity>(InsightIdentity.CreateFromDiscriminatorValue); } },
                {"sharedDateTime", n => { SharedDateTime = n.GetDateTimeOffsetValue(); } },
                {"sharingReference", n => { SharingReference = n.GetObjectValue<ResourceReference>(ResourceReference.CreateFromDiscriminatorValue); } },
                {"sharingSubject", n => { SharingSubject = n.GetStringValue(); } },
                {"sharingType", n => { SharingType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<InsightIdentity>("sharedBy", SharedBy);
            writer.WriteDateTimeOffsetValue("sharedDateTime", SharedDateTime);
            writer.WriteStringValue("sharingSubject", SharingSubject);
            writer.WriteStringValue("sharingType", SharingType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
