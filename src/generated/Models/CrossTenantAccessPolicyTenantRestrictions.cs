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
    public partial class CrossTenantAccessPolicyTenantRestrictions : global::ApiSdk.Models.CrossTenantAccessPolicyB2BSetting, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Defines the rule for filtering devices and whether devices that satisfy the rule should be allowed or blocked. This property isn&apos;t supported on the server side yet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DevicesFilter? Devices { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DevicesFilter Devices { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.CrossTenantAccessPolicyTenantRestrictions"/> and sets the default values.
        /// </summary>
        public CrossTenantAccessPolicyTenantRestrictions() : base()
        {
            OdataType = "#microsoft.graph.crossTenantAccessPolicyTenantRestrictions";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.CrossTenantAccessPolicyTenantRestrictions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.CrossTenantAccessPolicyTenantRestrictions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.CrossTenantAccessPolicyTenantRestrictions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "devices", n => { Devices = n.GetObjectValue<global::ApiSdk.Models.DevicesFilter>(global::ApiSdk.Models.DevicesFilter.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.DevicesFilter>("devices", Devices);
        }
    }
}
#pragma warning restore CS0618
