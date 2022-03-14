using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class UserConsentRequest : Request, IParsable {
        /// <summary>Approval decisions associated with a request.</summary>
        public ApiSdk.Models.Microsoft.Graph.Approval Approval { get; set; }
        /// <summary>The user's justification for requiring access to the app. Supports $filter (eq only) and $orderby.</summary>
        public string Reason { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserConsentRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserConsentRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"approval", (o,n) => { (o as UserConsentRequest).Approval = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Approval>(ApiSdk.Models.Microsoft.Graph.Approval.CreateFromDiscriminatorValue); } },
                {"reason", (o,n) => { (o as UserConsentRequest).Reason = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Approval>("approval", Approval);
            writer.WriteStringValue("reason", Reason);
        }
    }
}
