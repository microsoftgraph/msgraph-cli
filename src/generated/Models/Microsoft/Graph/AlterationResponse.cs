using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AlterationResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Defines the original user query string.</summary>
        public string OriginalQueryString { get; set; }
        /// <summary>Defines the details of the alteration information for the spelling correction.</summary>
        public ApiSdk.Models.Microsoft.Graph.SearchAlteration QueryAlteration { get; set; }
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
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.AlterationResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AlterationResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"originalQueryString", (o,n) => { (o as AlterationResponse).OriginalQueryString = n.GetStringValue(); } },
                {"queryAlteration", (o,n) => { (o as AlterationResponse).QueryAlteration = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SearchAlteration>(ApiSdk.Models.Microsoft.Graph.SearchAlteration.CreateFromDiscriminatorValue); } },
                {"queryAlterationType", (o,n) => { (o as AlterationResponse).QueryAlterationType = n.GetEnumValue<SearchAlterationType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("originalQueryString", OriginalQueryString);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SearchAlteration>("queryAlteration", QueryAlteration);
            writer.WriteEnumValue<SearchAlterationType>("queryAlterationType", QueryAlterationType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
