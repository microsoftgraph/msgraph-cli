using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class GroupLifecyclePolicy : Entity, IParsable {
        /// <summary>List of email address to send notifications for groups without owners. Multiple email address can be defined by separating email address with a semicolon.</summary>
        public string AlternateNotificationEmails { get; set; }
        /// <summary>Number of days before a group expires and needs to be renewed. Once renewed, the group expiration is extended by the number of days defined.</summary>
        public int? GroupLifetimeInDays { get; set; }
        /// <summary>The group type for which the expiration policy applies. Possible values are All, Selected or None.</summary>
        public string ManagedGroupTypes { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"alternateNotificationEmails", (o,n) => { (o as GroupLifecyclePolicy).AlternateNotificationEmails = n.GetStringValue(); } },
                {"groupLifetimeInDays", (o,n) => { (o as GroupLifecyclePolicy).GroupLifetimeInDays = n.GetIntValue(); } },
                {"managedGroupTypes", (o,n) => { (o as GroupLifecyclePolicy).ManagedGroupTypes = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("alternateNotificationEmails", AlternateNotificationEmails);
            writer.WriteIntValue("groupLifetimeInDays", GroupLifetimeInDays);
            writer.WriteStringValue("managedGroupTypes", ManagedGroupTypes);
        }
    }
}
