using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Groups.Item.Sites.Item.Onenote.Notebooks.GetRecentNotebooksWithIncludePersonalNotebooks {
    /// <summary>Provides operations to call the getRecentNotebooks method.</summary>
    public class GetRecentNotebooksWithIncludePersonalNotebooksResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The value property</summary>
        public List<RecentNotebook> Value { get; set; }
        /// <summary>
        /// Instantiates a new getRecentNotebooksWithIncludePersonalNotebooksResponse and sets the default values.
        /// </summary>
        public GetRecentNotebooksWithIncludePersonalNotebooksResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GetRecentNotebooksWithIncludePersonalNotebooksResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetRecentNotebooksWithIncludePersonalNotebooksResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"value", n => { Value = n.GetCollectionOfObjectValues<RecentNotebook>(RecentNotebook.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<RecentNotebook>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
