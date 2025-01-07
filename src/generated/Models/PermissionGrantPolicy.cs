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
    public partial class PermissionGrantPolicy : global::ApiSdk.Models.PolicyBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Condition sets that are excluded in this permission grant policy. Automatically expanded on GET.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PermissionGrantConditionSet>? Excludes { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PermissionGrantConditionSet> Excludes { get; set; }
#endif
        /// <summary>Condition sets that are included in this permission grant policy. Automatically expanded on GET.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PermissionGrantConditionSet>? Includes { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PermissionGrantConditionSet> Includes { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.PermissionGrantPolicy"/> and sets the default values.
        /// </summary>
        public PermissionGrantPolicy() : base()
        {
            OdataType = "#microsoft.graph.permissionGrantPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PermissionGrantPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.PermissionGrantPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.PermissionGrantPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "excludes", n => { Excludes = n.GetCollectionOfObjectValues<global::ApiSdk.Models.PermissionGrantConditionSet>(global::ApiSdk.Models.PermissionGrantConditionSet.CreateFromDiscriminatorValue)?.AsList(); } },
                { "includes", n => { Includes = n.GetCollectionOfObjectValues<global::ApiSdk.Models.PermissionGrantConditionSet>(global::ApiSdk.Models.PermissionGrantConditionSet.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.PermissionGrantConditionSet>("excludes", Excludes);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.PermissionGrantConditionSet>("includes", Includes);
        }
    }
}
#pragma warning restore CS0618
