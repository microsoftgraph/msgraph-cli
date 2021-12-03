using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class LookupColumn : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether multiple values can be selected from the source.</summary>
        public bool? AllowMultipleValues { get; set; }
        /// <summary>Indicates whether values in the column should be able to exceed the standard limit of 255 characters.</summary>
        public bool? AllowUnlimitedLength { get; set; }
        /// <summary>The name of the lookup source column.</summary>
        public string ColumnName { get; set; }
        /// <summary>The unique identifier of the lookup source list.</summary>
        public string ListId { get; set; }
        /// <summary>If specified, this column is a secondary lookup, pulling an additional field from the list item looked up by the primary lookup. Use the list item looked up by the primary as the source for the column named here.</summary>
        public string PrimaryLookupColumnId { get; set; }
        /// <summary>
        /// Instantiates a new lookupColumn and sets the default values.
        /// </summary>
        public LookupColumn() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowMultipleValues", (o,n) => { (o as LookupColumn).AllowMultipleValues = n.GetBoolValue(); } },
                {"allowUnlimitedLength", (o,n) => { (o as LookupColumn).AllowUnlimitedLength = n.GetBoolValue(); } },
                {"columnName", (o,n) => { (o as LookupColumn).ColumnName = n.GetStringValue(); } },
                {"listId", (o,n) => { (o as LookupColumn).ListId = n.GetStringValue(); } },
                {"primaryLookupColumnId", (o,n) => { (o as LookupColumn).PrimaryLookupColumnId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowMultipleValues", AllowMultipleValues);
            writer.WriteBoolValue("allowUnlimitedLength", AllowUnlimitedLength);
            writer.WriteStringValue("columnName", ColumnName);
            writer.WriteStringValue("listId", ListId);
            writer.WriteStringValue("primaryLookupColumnId", PrimaryLookupColumnId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
