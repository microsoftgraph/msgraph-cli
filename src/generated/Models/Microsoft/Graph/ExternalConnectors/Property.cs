using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.ExternalConnectors {
    public class Property : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A set of aliases or a friendly names for the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, each string may not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &, ?, @, #, /, ~, ', ', <, >, `, ^. Optional.</summary>
        public List<string> Aliases { get; set; }
        /// <summary>Specifies if the property is queryable. Queryable properties can be used in Keyword Query Language (KQL) queries. Optional.</summary>
        public bool? IsQueryable { get; set; }
        /// <summary>Specifies if the property is refinable.  Refinable properties can be used to filter search results in the Search API and add a refiner control in the Microsoft Search user experience. Optional.</summary>
        public bool? IsRefinable { get; set; }
        /// <summary>Specifies if the property is retrievable. Retrievable properties are returned in the result set when items are returned by the search API. Retrievable properties are also available to add to the display template used to render search results. Optional.</summary>
        public bool? IsRetrievable { get; set; }
        /// <summary>Specifies if the property is searchable. Only properties of type string or stringCollection can be searchable. Non-searchable properties are not added to the search index. Optional.</summary>
        public bool? IsSearchable { get; set; }
        /// <summary>Specifies one or more well-known tags added against a property. Labels help Microsoft Search understand the semantics of the data in the connection. Adding appropriate labels would result in an enhanced search experience (e.g. better relevance). Optional.The possible values are: title, url, createdBy, lastModifiedBy, authors, createdDateTime, lastModifiedDateTime, fileName, fileExtension, unknownFutureValue, iconUrl, containerName, containerUrl. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: iconUrl, containerName, containerUrl.</summary>
        public List<Label?> Labels { get; set; }
        /// <summary>The name of the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, each string may not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &, ?, @, #, /, ~, ', ', <, >, `, ^.  Required.</summary>
        public string Name { get; set; }
        /// <summary>The data type of the property. Possible values are: string, int64, double, dateTime, boolean, stringCollection, int64Collection, doubleCollection, dateTimeCollection, unknownFutureValue. Required.</summary>
        public PropertyType? Type { get; set; }
        /// <summary>
        /// Instantiates a new property and sets the default values.
        /// </summary>
        public Property() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"aliases", (o,n) => { (o as Property).Aliases = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isQueryable", (o,n) => { (o as Property).IsQueryable = n.GetBoolValue(); } },
                {"isRefinable", (o,n) => { (o as Property).IsRefinable = n.GetBoolValue(); } },
                {"isRetrievable", (o,n) => { (o as Property).IsRetrievable = n.GetBoolValue(); } },
                {"isSearchable", (o,n) => { (o as Property).IsSearchable = n.GetBoolValue(); } },
                {"labels", (o,n) => { (o as Property).Labels = n.GetCollectionOfEnumValues<Label>().ToList(); } },
                {"name", (o,n) => { (o as Property).Name = n.GetStringValue(); } },
                {"type", (o,n) => { (o as Property).Type = n.GetEnumValue<PropertyType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("aliases", Aliases);
            writer.WriteBoolValue("isQueryable", IsQueryable);
            writer.WriteBoolValue("isRefinable", IsRefinable);
            writer.WriteBoolValue("isRetrievable", IsRetrievable);
            writer.WriteBoolValue("isSearchable", IsSearchable);
            writer.WriteCollectionOfEnumValues<Label>("labels", Labels);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<PropertyType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
