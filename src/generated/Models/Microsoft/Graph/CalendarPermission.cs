using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class CalendarPermission : Entity, IParsable {
        /// <summary>List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.</summary>
        public List<CalendarRoleType?> AllowedRoles { get; set; }
        /// <summary>Represents a sharee or delegate who has access to the calendar. For the 'My Organization' sharee, the address property is null. Read-only.</summary>
        public EmailAddress EmailAddress { get; set; }
        /// <summary>True if the user in context (sharee or delegate) is inside the same organization as the calendar owner.</summary>
        public bool? IsInsideOrganization { get; set; }
        /// <summary>True if the user can be removed from the list of sharees or delegates for the specified calendar, false otherwise. The 'My organization' user determines the permissions other people within your organization have to the given calendar. You cannot remove 'My organization' as a sharee to a calendar.</summary>
        public bool? IsRemovable { get; set; }
        /// <summary>Current permission level of the calendar sharee or delegate.</summary>
        public CalendarRoleType? Role { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"allowedRoles", (o,n) => { (o as CalendarPermission).AllowedRoles = n.GetCollectionOfEnumValues<CalendarRoleType>().ToList(); } },
                {"emailAddress", (o,n) => { (o as CalendarPermission).EmailAddress = n.GetObjectValue<EmailAddress>(); } },
                {"isInsideOrganization", (o,n) => { (o as CalendarPermission).IsInsideOrganization = n.GetBoolValue(); } },
                {"isRemovable", (o,n) => { (o as CalendarPermission).IsRemovable = n.GetBoolValue(); } },
                {"role", (o,n) => { (o as CalendarPermission).Role = n.GetEnumValue<CalendarRoleType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfEnumValues<CalendarRoleType>("allowedRoles", AllowedRoles);
            writer.WriteObjectValue<EmailAddress>("emailAddress", EmailAddress);
            writer.WriteBoolValue("isInsideOrganization", IsInsideOrganization);
            writer.WriteBoolValue("isRemovable", IsRemovable);
            writer.WriteEnumValue<CalendarRoleType>("role", Role);
        }
    }
}
