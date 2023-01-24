using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Security {
    public class IpEvidence : AlertEvidence, IParsable {
        /// <summary>The two-letter country code according to ISO 3166 format, for example: US, UK, CA, etc..).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryLetterCode { get; set; }
#nullable restore
#else
        public string CountryLetterCode { get; set; }
#endif
        /// <summary>The value of the IP Address, can be either in V4 address or V6 address format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddress { get; set; }
#nullable restore
#else
        public string IpAddress { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IpEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IpEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"countryLetterCode", n => { CountryLetterCode = n.GetStringValue(); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("countryLetterCode", CountryLetterCode);
            writer.WriteStringValue("ipAddress", IpAddress);
        }
    }
}
