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
    public partial class PlannerBucket : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Name of the bucket.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Hint used to order items of this type in a list view. For details about the supported format, see Using order hints in Planner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrderHint { get; set; }
#nullable restore
#else
        public string OrderHint { get; set; }
#endif
        /// <summary>Plan ID to which the bucket belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PlanId { get; set; }
#nullable restore
#else
        public string PlanId { get; set; }
#endif
        /// <summary>Read-only. Nullable. The collection of tasks in the bucket.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PlannerTask>? Tasks { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PlannerTask> Tasks { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PlannerBucket"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.PlannerBucket CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.PlannerBucket();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "name", n => { Name = n.GetStringValue(); } },
                { "orderHint", n => { OrderHint = n.GetStringValue(); } },
                { "planId", n => { PlanId = n.GetStringValue(); } },
                { "tasks", n => { Tasks = n.GetCollectionOfObjectValues<global::ApiSdk.Models.PlannerTask>(global::ApiSdk.Models.PlannerTask.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("orderHint", OrderHint);
            writer.WriteStringValue("planId", PlanId);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.PlannerTask>("tasks", Tasks);
        }
    }
}
#pragma warning restore CS0618
