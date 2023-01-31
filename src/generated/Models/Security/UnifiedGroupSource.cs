using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Security {
    public class UnifiedGroupSource : DataSource, IParsable {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Group? Group { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Group Group { get; set; }
#endif
        /// <summary>Specifies which sources are included in this group. Possible values are: mailbox, site.</summary>
        public SourceType? IncludedSources { get; set; }
        /// <summary>
        /// Instantiates a new UnifiedGroupSource and sets the default values.
        /// </summary>
        public UnifiedGroupSource() : base() {
            OdataType = "#microsoft.graph.security.unifiedGroupSource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new UnifiedGroupSource CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new UnifiedGroupSource CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedGroupSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"group", n => { Group = n.GetObjectValue<ApiSdk.Models.Group>(ApiSdk.Models.Group.CreateFromDiscriminatorValue); } },
                {"includedSources", n => { IncludedSources = n.GetEnumValue<SourceType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Group>("group", Group);
            writer.WriteEnumValue<SourceType>("includedSources", IncludedSources);
        }
    }
}
