using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.ExternalConnectors {
    public class Property : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A set of aliases or a friendly names for the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, each string may not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &amp;, ?, @, #, /, ~, &apos;, &apos;, &lt;, &gt;, `, ^. Optional.</summary>
        public List<string> Aliases { get; set; }
        /// <summary>Specifies if the property is queryable. Queryable properties can be used in Keyword Query Language (KQL) queries. Optional.</summary>
        public bool? IsQueryable { get; set; }
        /// <summary>Specifies if the property is refinable.  Refinable properties can be used to filter search results in the Search API and add a refiner control in the Microsoft Search user experience. Optional.</summary>
        public bool? IsRefinable { get; set; }
        /// <summary>Specifies if the property is retrievable. Retrievable properties are returned in the result set when items are returned by the search API. Retrievable properties are also available to add to the display template used to render search results. Optional.</summary>
        public bool? IsRetrievable { get; set; }
        /// <summary>Specifies if the property is searchable. Only properties of type String or StringCollection can be searchable. Non-searchable properties are not added to the search index. Optional.</summary>
        public bool? IsSearchable { get; set; }
        /// <summary>Specifies one or more well-known tags added against a property. Labels help Microsoft Search understand the semantics of the data in the connection. Adding appropriate labels would result in an enhanced search experience (e.g. better relevance). The possible values are: title, url, createdBy, lastModifiedBy, authors, createdDateTime, lastModifiedDateTime, fileName, fileExtension, unknownFutureValue. Optional.</summary>
        public List<string> Labels { get; set; }
        /// <summary>The name of the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, each string may not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &amp;, ?, @, #, /, ~, &apos;, &apos;, &lt;, &gt;, `, ^.  Required.</summary>
        public string Name { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The type property</summary>
        public PropertyType? Type { get; set; }
        /// <summary>
        /// Instantiates a new property and sets the default values.
        /// </summary>
        public Property() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.externalConnectors.property";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Property CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Property();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"aliases", n => { Aliases = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isQueryable", n => { IsQueryable = n.GetBoolValue(); } },
                {"isRefinable", n => { IsRefinable = n.GetBoolValue(); } },
                {"isRetrievable", n => { IsRetrievable = n.GetBoolValue(); } },
                {"isSearchable", n => { IsSearchable = n.GetBoolValue(); } },
                {"labels", n => { Labels = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<PropertyType>(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("labels", Labels);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<PropertyType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
