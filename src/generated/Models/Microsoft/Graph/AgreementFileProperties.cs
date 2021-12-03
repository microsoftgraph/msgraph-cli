using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AgreementFileProperties : Entity, IParsable {
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string DisplayName { get; set; }
        public AgreementFileData FileData { get; set; }
        public string FileName { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsMajorVersion { get; set; }
        public string Language { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as AgreementFileProperties).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as AgreementFileProperties).DisplayName = n.GetStringValue(); } },
                {"fileData", (o,n) => { (o as AgreementFileProperties).FileData = n.GetObjectValue<AgreementFileData>(); } },
                {"fileName", (o,n) => { (o as AgreementFileProperties).FileName = n.GetStringValue(); } },
                {"isDefault", (o,n) => { (o as AgreementFileProperties).IsDefault = n.GetBoolValue(); } },
                {"isMajorVersion", (o,n) => { (o as AgreementFileProperties).IsMajorVersion = n.GetBoolValue(); } },
                {"language", (o,n) => { (o as AgreementFileProperties).Language = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<AgreementFileData>("fileData", FileData);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isMajorVersion", IsMajorVersion);
            writer.WriteStringValue("language", Language);
        }
    }
}
