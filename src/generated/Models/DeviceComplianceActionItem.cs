using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceComplianceActionItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceComplianceActionItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionType", n => { ActionType = n.GetEnumValue<DeviceComplianceActionType>(); } },
                {"gracePeriodHours", n => { GracePeriodHours = n.GetIntValue(); } },
                {"notificationMessageCCList", n => { NotificationMessageCCList = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"notificationTemplateId", n => { NotificationTemplateId = n.GetStringValue(); } },
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
