// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// A base complex type to store the detection or requirement rule data for a Win32 LOB app.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Win32LobAppRule : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Contains rule types for Win32 LOB apps.</summary>
        public global::ApiSdk.Models.Win32LobAppRuleType? RuleType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.Win32LobAppRule"/> and sets the default values.
        /// </summary>
        public Win32LobAppRule()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Win32LobAppRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.Win32LobAppRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.win32LobAppFileSystemRule" => new global::ApiSdk.Models.Win32LobAppFileSystemRule(),
                "#microsoft.graph.win32LobAppPowerShellScriptRule" => new global::ApiSdk.Models.Win32LobAppPowerShellScriptRule(),
                "#microsoft.graph.win32LobAppProductCodeRule" => new global::ApiSdk.Models.Win32LobAppProductCodeRule(),
                "#microsoft.graph.win32LobAppRegistryRule" => new global::ApiSdk.Models.Win32LobAppRegistryRule(),
                _ => new global::ApiSdk.Models.Win32LobAppRule(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "ruleType", n => { RuleType = n.GetEnumValue<global::ApiSdk.Models.Win32LobAppRuleType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::ApiSdk.Models.Win32LobAppRuleType>("ruleType", RuleType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
