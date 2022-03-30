using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AgreementFileProperties : Entity, IParsable {
        /// <summary>The date time representing when the file was created.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Localized display name of the policy file of an agreement. The localized display name is shown to end users who view the agreement.</summary>
        public string DisplayName { get; set; }
        /// <summary>Data that represents the terms of use PDF document. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.AgreementFileData FileData { get; set; }
        /// <summary>Name of the agreement file (for example, TOU.pdf). Read-only.</summary>
        public string FileName { get; set; }
        /// <summary>If none of the languages matches the client preference, indicates whether this is the default agreement file . If none of the files are marked as default, the first one is treated as the default. Read-only.</summary>
        public bool? IsDefault { get; set; }
        /// <summary>Indicates whether the agreement file is a major version update. Major version updates invalidate the agreement's acceptances on the corresponding language.</summary>
        public bool? IsMajorVersion { get; set; }
        /// <summary>The language of the agreement file in the format 'languagecode2-country/regioncode2'. 'languagecode2' is a lowercase two-letter code derived from ISO 639-1, while 'country/regioncode2' is derived from ISO 3166 and usually consists of two uppercase letters, or a BCP-47 language tag. For example, U.S. English is en-US. Read-only.</summary>
        public string Language { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.AgreementFileProperties CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AgreementFileProperties();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as AgreementFileProperties).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as AgreementFileProperties).DisplayName = n.GetStringValue(); } },
                {"fileData", (o,n) => { (o as AgreementFileProperties).FileData = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AgreementFileData>(ApiSdk.Models.Microsoft.Graph.AgreementFileData.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AgreementFileData>("fileData", FileData);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isMajorVersion", IsMajorVersion);
            writer.WriteStringValue("language", Language);
        }
    }
}
