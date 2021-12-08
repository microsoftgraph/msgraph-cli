using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ListInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If true, indicates that content types are enabled for this list.</summary>
        public bool? ContentTypesEnabled { get; set; }
        /// <summary>If true, indicates that the list is not normally visible in the SharePoint user experience.</summary>
        public bool? Hidden { get; set; }
        /// <summary>An enumerated value that represents the base list template used in creating the list. Possible values include documentLibrary, genericList, task, survey, announcements, contacts, and more.</summary>
        public string Template { get; set; }
        /// <summary>
        /// Instantiates a new listInfo and sets the default values.
        /// </summary>
        public ListInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"contentTypesEnabled", (o,n) => { (o as ListInfo).ContentTypesEnabled = n.GetBoolValue(); } },
                {"hidden", (o,n) => { (o as ListInfo).Hidden = n.GetBoolValue(); } },
                {"template", (o,n) => { (o as ListInfo).Template = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("contentTypesEnabled", ContentTypesEnabled);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteStringValue("template", Template);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
