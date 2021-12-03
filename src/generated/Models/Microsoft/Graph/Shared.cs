using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Shared : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The identity of the owner of the shared item. Read-only.</summary>
        public IdentitySet Owner { get; set; }
        /// <summary>Indicates the scope of how the item is shared: anonymous, organization, or users. Read-only.</summary>
        public string Scope { get; set; }
        /// <summary>The identity of the user who shared the item. Read-only.</summary>
        public IdentitySet SharedBy { get; set; }
        /// <summary>The UTC date and time when the item was shared. Read-only.</summary>
        public DateTimeOffset? SharedDateTime { get; set; }
        /// <summary>
        /// Instantiates a new shared and sets the default values.
        /// </summary>
        public Shared() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"owner", (o,n) => { (o as Shared).Owner = n.GetObjectValue<IdentitySet>(); } },
                {"scope", (o,n) => { (o as Shared).Scope = n.GetStringValue(); } },
                {"sharedBy", (o,n) => { (o as Shared).SharedBy = n.GetObjectValue<IdentitySet>(); } },
                {"sharedDateTime", (o,n) => { (o as Shared).SharedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<IdentitySet>("owner", Owner);
            writer.WriteStringValue("scope", Scope);
            writer.WriteObjectValue<IdentitySet>("sharedBy", SharedBy);
            writer.WriteDateTimeOffsetValue("sharedDateTime", SharedDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
