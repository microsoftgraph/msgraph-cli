using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TelecomExpenseManagementPartner : Entity, IParsable {
        /// <summary>Whether the partner's AAD app has been authorized to access Intune.</summary>
        public bool? AppAuthorized { get; set; }
        /// <summary>Display name of the TEM partner.</summary>
        public string DisplayName { get; set; }
        /// <summary>Whether Intune's connection to the TEM service is currently enabled or disabled.</summary>
        public bool? Enabled { get; set; }
        /// <summary>Timestamp of the last request sent to Intune by the TEM partner.</summary>
        public DateTimeOffset? LastConnectionDateTime { get; set; }
        /// <summary>URL of the TEM partner's administrative control panel, where an administrator can configure their TEM service.</summary>
        public string Url { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appAuthorized", (o,n) => { (o as TelecomExpenseManagementPartner).AppAuthorized = n.GetBoolValue(); } },
                {"displayName", (o,n) => { (o as TelecomExpenseManagementPartner).DisplayName = n.GetStringValue(); } },
                {"enabled", (o,n) => { (o as TelecomExpenseManagementPartner).Enabled = n.GetBoolValue(); } },
                {"lastConnectionDateTime", (o,n) => { (o as TelecomExpenseManagementPartner).LastConnectionDateTime = n.GetDateTimeOffsetValue(); } },
                {"url", (o,n) => { (o as TelecomExpenseManagementPartner).Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("appAuthorized", AppAuthorized);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteDateTimeOffsetValue("lastConnectionDateTime", LastConnectionDateTime);
            writer.WriteStringValue("url", Url);
        }
    }
}
