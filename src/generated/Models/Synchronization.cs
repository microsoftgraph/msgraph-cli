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
    public partial class Synchronization : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Performs synchronization by periodically running in the background, polling for changes in one directory, and pushing them to another directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.SynchronizationJob>? Jobs { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.SynchronizationJob> Jobs { get; set; }
#endif
        /// <summary>Represents a collection of credentials to access provisioned cloud applications.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.SynchronizationSecretKeyStringValuePair>? Secrets { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.SynchronizationSecretKeyStringValuePair> Secrets { get; set; }
#endif
        /// <summary>Preconfigured synchronization settings for a particular application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.SynchronizationTemplate>? Templates { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.SynchronizationTemplate> Templates { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Synchronization"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Synchronization CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Synchronization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "jobs", n => { Jobs = n.GetCollectionOfObjectValues<global::ApiSdk.Models.SynchronizationJob>(global::ApiSdk.Models.SynchronizationJob.CreateFromDiscriminatorValue)?.AsList(); } },
                { "secrets", n => { Secrets = n.GetCollectionOfObjectValues<global::ApiSdk.Models.SynchronizationSecretKeyStringValuePair>(global::ApiSdk.Models.SynchronizationSecretKeyStringValuePair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "templates", n => { Templates = n.GetCollectionOfObjectValues<global::ApiSdk.Models.SynchronizationTemplate>(global::ApiSdk.Models.SynchronizationTemplate.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.SynchronizationJob>("jobs", Jobs);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.SynchronizationSecretKeyStringValuePair>("secrets", Secrets);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.SynchronizationTemplate>("templates", Templates);
        }
    }
}
#pragma warning restore CS0618
