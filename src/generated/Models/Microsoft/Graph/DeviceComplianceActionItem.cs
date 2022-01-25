using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class DeviceComplianceActionItem : Entity, IParsable {
        /// <summary>What action to take. Possible values are: noAction, notification, block, retire, wipe, removeResourceAccessProfiles, pushNotification, remoteLock.</summary>
        public DeviceComplianceActionType? ActionType { get; set; }
        /// <summary>Number of hours to wait till the action will be enforced. Valid values 0 to 8760</summary>
        public int? GracePeriodHours { get; set; }
        /// <summary>A list of group IDs to speicify who to CC this notification message to.</summary>
        public List<string> NotificationMessageCCList { get; set; }
        /// <summary>What notification Message template to use</summary>
        public string NotificationTemplateId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"actionType", (o,n) => { (o as DeviceComplianceActionItem).ActionType = n.GetEnumValue<DeviceComplianceActionType>(); } },
                {"gracePeriodHours", (o,n) => { (o as DeviceComplianceActionItem).GracePeriodHours = n.GetIntValue(); } },
                {"notificationMessageCCList", (o,n) => { (o as DeviceComplianceActionItem).NotificationMessageCCList = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"notificationTemplateId", (o,n) => { (o as DeviceComplianceActionItem).NotificationTemplateId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceComplianceActionType>("actionType", ActionType);
            writer.WriteIntValue("gracePeriodHours", GracePeriodHours);
            writer.WriteCollectionOfPrimitiveValues<string>("notificationMessageCCList", NotificationMessageCCList);
            writer.WriteStringValue("notificationTemplateId", NotificationTemplateId);
        }
    }
}
