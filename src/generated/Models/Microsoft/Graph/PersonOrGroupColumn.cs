using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PersonOrGroupColumn : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether multiple values can be selected from the source.</summary>
        public bool? AllowMultipleSelection { get; set; }
        /// <summary>Whether to allow selection of people only, or people and groups. Must be one of peopleAndGroups or peopleOnly.</summary>
        public string ChooseFromType { get; set; }
        /// <summary>How to display the information about the person or group chosen. See below.</summary>
        public string DisplayAs { get; set; }
        /// <summary>
        /// Instantiates a new personOrGroupColumn and sets the default values.
        /// </summary>
        public PersonOrGroupColumn() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowMultipleSelection", (o,n) => { (o as PersonOrGroupColumn).AllowMultipleSelection = n.GetBoolValue(); } },
                {"chooseFromType", (o,n) => { (o as PersonOrGroupColumn).ChooseFromType = n.GetStringValue(); } },
                {"displayAs", (o,n) => { (o as PersonOrGroupColumn).DisplayAs = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowMultipleSelection", AllowMultipleSelection);
            writer.WriteStringValue("chooseFromType", ChooseFromType);
            writer.WriteStringValue("displayAs", DisplayAs);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
