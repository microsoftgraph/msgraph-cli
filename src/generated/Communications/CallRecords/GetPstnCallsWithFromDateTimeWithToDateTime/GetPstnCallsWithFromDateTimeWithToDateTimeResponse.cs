using ApiSdk.Models.CallRecords;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Communications.CallRecords.GetPstnCallsWithFromDateTimeWithToDateTime {
    /// <summary>Provides operations to call the getPstnCalls method.</summary>
    public class GetPstnCallsWithFromDateTimeWithToDateTimeResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The value property</summary>
        public List<PstnCallLogRow> Value { get; set; }
        /// <summary>
        /// Instantiates a new getPstnCallsWithFromDateTimeWithToDateTimeResponse and sets the default values.
        /// </summary>
        public GetPstnCallsWithFromDateTimeWithToDateTimeResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GetPstnCallsWithFromDateTimeWithToDateTimeResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetPstnCallsWithFromDateTimeWithToDateTimeResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"value", n => { Value = n.GetCollectionOfObjectValues<PstnCallLogRow>(PstnCallLogRow.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<PstnCallLogRow>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
