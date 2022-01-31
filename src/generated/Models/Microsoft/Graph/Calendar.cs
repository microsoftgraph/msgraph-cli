using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Calendar : Entity, IParsable {
        /// <summary>Represent the online meeting service providers that can be used to create online meetings in this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.</summary>
        public List<OnlineMeetingProviderType?> AllowedOnlineMeetingProviders { get; set; }
        /// <summary>The permissions of the users with whom the calendar is shared.</summary>
        public List<CalendarPermission> CalendarPermissions { get; set; }
        /// <summary>The calendar view for the calendar. Navigation property. Read-only.</summary>
        public List<Event> CalendarView { get; set; }
        /// <summary>true if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access, through an Outlook client or the corresponding calendarPermission resource. Read-only.</summary>
        public bool? CanEdit { get; set; }
        /// <summary>true if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it. Read-only.</summary>
        public bool? CanShare { get; set; }
        /// <summary>true if the user can read calendar items that have been marked private, false otherwise. This property is set through an Outlook client or the corresponding calendarPermission resource. Read-only.</summary>
        public bool? CanViewPrivateItems { get; set; }
        /// <summary>Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.</summary>
        public string ChangeKey { get; set; }
        /// <summary>Specifies the color theme to distinguish the calendar from other calendars in a UI. The property values are: auto, lightBlue, lightGreen, lightOrange, lightGray, lightYellow, lightTeal, lightPink, lightBrown, lightRed, maxColor.</summary>
        public CalendarColor? Color { get; set; }
        /// <summary>The default online meeting provider for meetings sent from this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.</summary>
        public OnlineMeetingProviderType? DefaultOnlineMeetingProvider { get; set; }
        /// <summary>The events in the calendar. Navigation property. Read-only.</summary>
        public List<Event> Events { get; set; }
        /// <summary>The calendar color, expressed in a hex color code of three hexadecimal values, each ranging from 00 to FF and representing the red, green, or blue components of the color in the RGB color space. If the user has never explicitly set a color for the calendar, this property is  empty.</summary>
        public string HexColor { get; set; }
        /// <summary>true if this is the default calendar where new events are created by default, false otherwise.</summary>
        public bool? IsDefaultCalendar { get; set; }
        /// <summary>Indicates whether this user calendar can be deleted from the user mailbox.</summary>
        public bool? IsRemovable { get; set; }
        /// <summary>Indicates whether this user calendar supports tracking of meeting responses. Only meeting invites sent from users' primary calendars support tracking of meeting responses.</summary>
        public bool? IsTallyingResponses { get; set; }
        /// <summary>The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
        /// <summary>The calendar name.</summary>
        public string Name { get; set; }
        /// <summary>If set, this represents the user who created or added the calendar. For a calendar that the user created or added, the owner property is set to the user. For a calendar shared with the user, the owner property is set to the person who shared that calendar with the user. Read-only.</summary>
        public EmailAddress Owner { get; set; }
        /// <summary>The collection of single-value extended properties defined for the calendar. Read-only. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"allowedOnlineMeetingProviders", (o,n) => { (o as Calendar).AllowedOnlineMeetingProviders = n.GetCollectionOfEnumValues<OnlineMeetingProviderType>().ToList(); } },
                {"calendarPermissions", (o,n) => { (o as Calendar).CalendarPermissions = n.GetCollectionOfObjectValues<CalendarPermission>().ToList(); } },
                {"calendarView", (o,n) => { (o as Calendar).CalendarView = n.GetCollectionOfObjectValues<Event>().ToList(); } },
                {"canEdit", (o,n) => { (o as Calendar).CanEdit = n.GetBoolValue(); } },
                {"canShare", (o,n) => { (o as Calendar).CanShare = n.GetBoolValue(); } },
                {"canViewPrivateItems", (o,n) => { (o as Calendar).CanViewPrivateItems = n.GetBoolValue(); } },
                {"changeKey", (o,n) => { (o as Calendar).ChangeKey = n.GetStringValue(); } },
                {"color", (o,n) => { (o as Calendar).Color = n.GetEnumValue<CalendarColor>(); } },
                {"defaultOnlineMeetingProvider", (o,n) => { (o as Calendar).DefaultOnlineMeetingProvider = n.GetEnumValue<OnlineMeetingProviderType>(); } },
                {"events", (o,n) => { (o as Calendar).Events = n.GetCollectionOfObjectValues<Event>().ToList(); } },
                {"hexColor", (o,n) => { (o as Calendar).HexColor = n.GetStringValue(); } },
                {"isDefaultCalendar", (o,n) => { (o as Calendar).IsDefaultCalendar = n.GetBoolValue(); } },
                {"isRemovable", (o,n) => { (o as Calendar).IsRemovable = n.GetBoolValue(); } },
                {"isTallyingResponses", (o,n) => { (o as Calendar).IsTallyingResponses = n.GetBoolValue(); } },
                {"multiValueExtendedProperties", (o,n) => { (o as Calendar).MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>().ToList(); } },
                {"name", (o,n) => { (o as Calendar).Name = n.GetStringValue(); } },
                {"owner", (o,n) => { (o as Calendar).Owner = n.GetObjectValue<EmailAddress>(); } },
                {"singleValueExtendedProperties", (o,n) => { (o as Calendar).SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfEnumValues<OnlineMeetingProviderType>("allowedOnlineMeetingProviders", AllowedOnlineMeetingProviders);
            writer.WriteCollectionOfObjectValues<CalendarPermission>("calendarPermissions", CalendarPermissions);
            writer.WriteCollectionOfObjectValues<Event>("calendarView", CalendarView);
            writer.WriteBoolValue("canEdit", CanEdit);
            writer.WriteBoolValue("canShare", CanShare);
            writer.WriteBoolValue("canViewPrivateItems", CanViewPrivateItems);
            writer.WriteStringValue("changeKey", ChangeKey);
            writer.WriteEnumValue<CalendarColor>("color", Color);
            writer.WriteEnumValue<OnlineMeetingProviderType>("defaultOnlineMeetingProvider", DefaultOnlineMeetingProvider);
            writer.WriteCollectionOfObjectValues<Event>("events", Events);
            writer.WriteStringValue("hexColor", HexColor);
            writer.WriteBoolValue("isDefaultCalendar", IsDefaultCalendar);
            writer.WriteBoolValue("isRemovable", IsRemovable);
            writer.WriteBoolValue("isTallyingResponses", IsTallyingResponses);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<EmailAddress>("owner", Owner);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
        }
    }
}
