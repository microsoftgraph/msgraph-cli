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
    public partial class DocumentSet : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Content types allowed in document set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ContentTypeInfo>? AllowedContentTypes { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ContentTypeInfo> AllowedContentTypes { get; set; }
#endif
        /// <summary>Default contents of document set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DocumentSetContent>? DefaultContents { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DocumentSetContent> DefaultContents { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Specifies whether to push welcome page changes to inherited content types.</summary>
        public bool? PropagateWelcomePageChanges { get; set; }
        /// <summary>The sharedColumns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ColumnDefinition>? SharedColumns { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ColumnDefinition> SharedColumns { get; set; }
#endif
        /// <summary>Indicates whether to add the name of the document set to each file name.</summary>
        public bool? ShouldPrefixNameToFile { get; set; }
        /// <summary>The welcomePageColumns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ColumnDefinition>? WelcomePageColumns { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ColumnDefinition> WelcomePageColumns { get; set; }
#endif
        /// <summary>Welcome page absolute URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WelcomePageUrl { get; set; }
#nullable restore
#else
        public string WelcomePageUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.DocumentSet"/> and sets the default values.
        /// </summary>
        public DocumentSet()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.DocumentSet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.DocumentSet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.DocumentSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allowedContentTypes", n => { AllowedContentTypes = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ContentTypeInfo>(global::ApiSdk.Models.ContentTypeInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "defaultContents", n => { DefaultContents = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DocumentSetContent>(global::ApiSdk.Models.DocumentSetContent.CreateFromDiscriminatorValue)?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "propagateWelcomePageChanges", n => { PropagateWelcomePageChanges = n.GetBoolValue(); } },
                { "sharedColumns", n => { SharedColumns = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ColumnDefinition>(global::ApiSdk.Models.ColumnDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "shouldPrefixNameToFile", n => { ShouldPrefixNameToFile = n.GetBoolValue(); } },
                { "welcomePageColumns", n => { WelcomePageColumns = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ColumnDefinition>(global::ApiSdk.Models.ColumnDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "welcomePageUrl", n => { WelcomePageUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ContentTypeInfo>("allowedContentTypes", AllowedContentTypes);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DocumentSetContent>("defaultContents", DefaultContents);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("propagateWelcomePageChanges", PropagateWelcomePageChanges);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ColumnDefinition>("sharedColumns", SharedColumns);
            writer.WriteBoolValue("shouldPrefixNameToFile", ShouldPrefixNameToFile);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ColumnDefinition>("welcomePageColumns", WelcomePageColumns);
            writer.WriteStringValue("welcomePageUrl", WelcomePageUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
