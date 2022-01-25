using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class BookingCustomQuestion : Entity, IParsable {
        /// <summary>The expected answer type. The possible values are: text, radioButton, unknownFutureValue.</summary>
        public AnswerInputType? AnswerInputType { get; set; }
        /// <summary>List of possible answer values.</summary>
        public List<string> AnswerOptions { get; set; }
        /// <summary>Display name of this entity.</summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"answerInputType", (o,n) => { (o as BookingCustomQuestion).AnswerInputType = n.GetEnumValue<AnswerInputType>(); } },
                {"answerOptions", (o,n) => { (o as BookingCustomQuestion).AnswerOptions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"displayName", (o,n) => { (o as BookingCustomQuestion).DisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<AnswerInputType>("answerInputType", AnswerInputType);
            writer.WriteCollectionOfPrimitiveValues<string>("answerOptions", AnswerOptions);
            writer.WriteStringValue("displayName", DisplayName);
        }
    }
}
