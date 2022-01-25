using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AppConsentRequest : Entity, IParsable {
        /// <summary>The display name of the app for which consent is requested. Required. Supports $filter (eq only) and $orderby.</summary>
        public string AppDisplayName { get; set; }
        /// <summary>The identifier of the application. Required. Supports $filter (eq only) and $orderby.</summary>
        public string AppId { get; set; }
        /// <summary>A list of pending scopes waiting for approval. This is empty if the consentType is Static. Required.</summary>
        public List<AppConsentRequestScope> PendingScopes { get; set; }
        /// <summary>A list of pending user consent requests.</summary>
        public List<UserConsentRequest> UserConsentRequests { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appDisplayName", (o,n) => { (o as AppConsentRequest).AppDisplayName = n.GetStringValue(); } },
                {"appId", (o,n) => { (o as AppConsentRequest).AppId = n.GetStringValue(); } },
                {"pendingScopes", (o,n) => { (o as AppConsentRequest).PendingScopes = n.GetCollectionOfObjectValues<AppConsentRequestScope>().ToList(); } },
                {"userConsentRequests", (o,n) => { (o as AppConsentRequest).UserConsentRequests = n.GetCollectionOfObjectValues<UserConsentRequest>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appId", AppId);
            writer.WriteCollectionOfObjectValues<AppConsentRequestScope>("pendingScopes", PendingScopes);
            writer.WriteCollectionOfObjectValues<UserConsentRequest>("userConsentRequests", UserConsentRequests);
        }
    }
}
