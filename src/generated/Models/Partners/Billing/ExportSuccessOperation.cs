// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.Partners.Billing
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ExportSuccessOperation : global::ApiSdk.Models.Partners.Billing.Operation, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The resourceLocation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Partners.Billing.Manifest? ResourceLocation { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Partners.Billing.Manifest ResourceLocation { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Partners.Billing.ExportSuccessOperation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Partners.Billing.ExportSuccessOperation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Partners.Billing.ExportSuccessOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "resourceLocation", n => { ResourceLocation = n.GetObjectValue<global::ApiSdk.Models.Partners.Billing.Manifest>(global::ApiSdk.Models.Partners.Billing.Manifest.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::ApiSdk.Models.Partners.Billing.Manifest>("resourceLocation", ResourceLocation);
        }
    }
}
#pragma warning restore CS0618
