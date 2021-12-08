using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ManagedEBook : Entity, IParsable {
        /// <summary>The list of assignments for this eBook.</summary>
        public List<ManagedEBookAssignment> Assignments { get; set; }
        /// <summary>The date and time when the eBook file was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description.</summary>
        public string Description { get; set; }
        /// <summary>The list of installation states for this eBook.</summary>
        public List<DeviceInstallState> DeviceStates { get; set; }
        /// <summary>Name of the eBook.</summary>
        public string DisplayName { get; set; }
        /// <summary>The more information Url.</summary>
        public string InformationUrl { get; set; }
        /// <summary>Mobile App Install Summary.</summary>
        public EBookInstallSummary InstallSummary { get; set; }
        /// <summary>Book cover.</summary>
        public MimeContent LargeCover { get; set; }
        /// <summary>The date and time when the eBook was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The privacy statement Url.</summary>
        public string PrivacyInformationUrl { get; set; }
        /// <summary>The date and time when the eBook was published.</summary>
        public DateTimeOffset? PublishedDateTime { get; set; }
        /// <summary>Publisher.</summary>
        public string Publisher { get; set; }
        /// <summary>The list of installation states for this eBook.</summary>
        public List<UserInstallStateSummary> UserStateSummary { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as ManagedEBook).Assignments = n.GetCollectionOfObjectValues<ManagedEBookAssignment>().ToList(); } },
                {"createdDateTime", (o,n) => { (o as ManagedEBook).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as ManagedEBook).Description = n.GetStringValue(); } },
                {"deviceStates", (o,n) => { (o as ManagedEBook).DeviceStates = n.GetCollectionOfObjectValues<DeviceInstallState>().ToList(); } },
                {"displayName", (o,n) => { (o as ManagedEBook).DisplayName = n.GetStringValue(); } },
                {"informationUrl", (o,n) => { (o as ManagedEBook).InformationUrl = n.GetStringValue(); } },
                {"installSummary", (o,n) => { (o as ManagedEBook).InstallSummary = n.GetObjectValue<EBookInstallSummary>(); } },
                {"largeCover", (o,n) => { (o as ManagedEBook).LargeCover = n.GetObjectValue<MimeContent>(); } },
                {"lastModifiedDateTime", (o,n) => { (o as ManagedEBook).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"privacyInformationUrl", (o,n) => { (o as ManagedEBook).PrivacyInformationUrl = n.GetStringValue(); } },
                {"publishedDateTime", (o,n) => { (o as ManagedEBook).PublishedDateTime = n.GetDateTimeOffsetValue(); } },
                {"publisher", (o,n) => { (o as ManagedEBook).Publisher = n.GetStringValue(); } },
                {"userStateSummary", (o,n) => { (o as ManagedEBook).UserStateSummary = n.GetCollectionOfObjectValues<UserInstallStateSummary>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ManagedEBookAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<DeviceInstallState>("deviceStates", DeviceStates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("informationUrl", InformationUrl);
            writer.WriteObjectValue<EBookInstallSummary>("installSummary", InstallSummary);
            writer.WriteObjectValue<MimeContent>("largeCover", LargeCover);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("privacyInformationUrl", PrivacyInformationUrl);
            writer.WriteDateTimeOffsetValue("publishedDateTime", PublishedDateTime);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteCollectionOfObjectValues<UserInstallStateSummary>("userStateSummary", UserStateSummary);
        }
    }
}
