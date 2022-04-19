using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class DateTimeColumn : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>How the value should be presented in the UX. Must be one of default, friendly, or standard. See below for more details. If unspecified, treated as default.</summary>
        public string DisplayAs { get; set; }
        /// <summary>Indicates whether the value should be presented as a date only or a date and time. Must be one of dateOnly or dateTime</summary>
        public string Format { get; set; }
        /// <summary>
        /// Instantiates a new dateTimeColumn and sets the default values.
        /// </summary>
        public DateTimeColumn() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DateTimeColumn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DateTimeColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayAs", n => { DisplayAs = n.GetStringValue(); } },
                {"format", n => { Format = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayAs", DisplayAs);
            writer.WriteStringValue("format", Format);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
