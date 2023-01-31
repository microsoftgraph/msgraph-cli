using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AlterationResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Defines the original user query string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalQueryString { get; set; }
#nullable restore
#else
        public string OriginalQueryString { get; set; }
#endif
        /// <summary>Defines the details of the alteration information for the spelling correction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SearchAlteration? QueryAlteration { get; set; }
#nullable restore
#else
        public SearchAlteration QueryAlteration { get; set; }
#endif
        /// <summary>Defines the type of the spelling correction. Possible values are: suggestion, modification.</summary>
        public SearchAlterationType? QueryAlterationType { get; set; }
        /// <summary>
        /// Instantiates a new alterationResponse and sets the default values.
        /// </summary>
        public AlterationResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static AlterationResponse CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static AlterationResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AlterationResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"originalQueryString", n => { OriginalQueryString = n.GetStringValue(); } },
                {"queryAlteration", n => { QueryAlteration = n.GetObjectValue<SearchAlteration>(SearchAlteration.CreateFromDiscriminatorValue); } },
                {"queryAlterationType", n => { QueryAlterationType = n.GetEnumValue<SearchAlterationType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("originalQueryString", OriginalQueryString);
            writer.WriteObjectValue<SearchAlteration>("queryAlteration", QueryAlteration);
            writer.WriteEnumValue<SearchAlterationType>("queryAlterationType", QueryAlterationType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
