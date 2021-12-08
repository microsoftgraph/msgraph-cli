using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ConditionalAccessFilter : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Mode to use for the filter. Possible values are include or exclude.</summary>
        public FilterMode? Mode { get; set; }
        /// <summary>Rule syntax is similar to that used for membership rules for groups in Azure Active Directory (Azure AD). For details, see rules with multiple expressions</summary>
        public string Rule { get; set; }
        /// <summary>
        /// Instantiates a new conditionalAccessFilter and sets the default values.
        /// </summary>
        public ConditionalAccessFilter() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"mode", (o,n) => { (o as ConditionalAccessFilter).Mode = n.GetEnumValue<FilterMode>(); } },
                {"rule", (o,n) => { (o as ConditionalAccessFilter).Rule = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<FilterMode>("mode", Mode);
            writer.WriteStringValue("rule", Rule);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
