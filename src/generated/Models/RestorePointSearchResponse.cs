// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class RestorePointSearchResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Contains  alist of protection units with no restore points.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? NoResultProtectionUnitIds { get; set; }
#nullable restore
#else
        public List<string> NoResultProtectionUnitIds { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The unique identifier of the search response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SearchResponseId { get; set; }
#nullable restore
#else
        public string SearchResponseId { get; set; }
#endif
        /// <summary>Contains a collection of restore points.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.RestorePointSearchResult>? SearchResults { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.RestorePointSearchResult> SearchResults { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.RestorePointSearchResponse"/> and sets the default values.
        /// </summary>
        public RestorePointSearchResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.RestorePointSearchResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.RestorePointSearchResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.RestorePointSearchResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "noResultProtectionUnitIds", n => { NoResultProtectionUnitIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "searchResponseId", n => { SearchResponseId = n.GetStringValue(); } },
                { "searchResults", n => { SearchResults = n.GetCollectionOfObjectValues<global::ApiSdk.Models.RestorePointSearchResult>(global::ApiSdk.Models.RestorePointSearchResult.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("noResultProtectionUnitIds", NoResultProtectionUnitIds);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("searchResponseId", SearchResponseId);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.RestorePointSearchResult>("searchResults", SearchResults);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618