using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class UploadSession : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The date and time in UTC that the upload session will expire. The complete file must be uploaded before this expiration time is reached.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>A collection of byte ranges that the server is missing for the file. These ranges are zero indexed and of the format &apos;start-end&apos; (e.g. &apos;0-26&apos; to indicate the first 27 bytes of the file). When uploading files as Outlook attachments, instead of a collection of ranges, this property always indicates a single value &apos;{start}&apos;, the location in the file where the next upload should begin.</summary>
        public List<string> NextExpectedRanges { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The URL endpoint that accepts PUT requests for byte ranges of the file.</summary>
        public string UploadUrl { get; set; }
        /// <summary>
        /// Instantiates a new uploadSession and sets the default values.
        /// </summary>
        public UploadSession() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.uploadSession";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UploadSession CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UploadSession();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"nextExpectedRanges", n => { NextExpectedRanges = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"uploadUrl", n => { UploadUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("nextExpectedRanges", NextExpectedRanges);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("uploadUrl", UploadUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
