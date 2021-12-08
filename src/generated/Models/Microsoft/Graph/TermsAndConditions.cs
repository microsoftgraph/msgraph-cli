using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TermsAndConditions : Entity, IParsable {
        /// <summary>Administrator-supplied explanation of the terms and conditions, typically describing what it means to accept the terms and conditions set out in the T&C policy. This is shown to the user on prompts to accept the T&C policy.</summary>
        public string AcceptanceStatement { get; set; }
        /// <summary>The list of acceptance statuses for this T&C policy.</summary>
        public List<TermsAndConditionsAcceptanceStatus> AcceptanceStatuses { get; set; }
        /// <summary>The list of assignments for this T&C policy.</summary>
        public List<TermsAndConditionsAssignment> Assignments { get; set; }
        /// <summary>Administrator-supplied body text of the terms and conditions, typically the terms themselves. This is shown to the user on prompts to accept the T&C policy.</summary>
        public string BodyText { get; set; }
        /// <summary>DateTime the object was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Administrator-supplied description of the T&C policy.</summary>
        public string Description { get; set; }
        /// <summary>Administrator-supplied name for the T&C policy.</summary>
        public string DisplayName { get; set; }
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Administrator-supplied title of the terms and conditions. This is shown to the user on prompts to accept the T&C policy.</summary>
        public string Title { get; set; }
        /// <summary>Integer indicating the current version of the terms. Incremented when an administrator makes a change to the terms and wishes to require users to re-accept the modified T&C policy.</summary>
        public int? Version { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"acceptanceStatement", (o,n) => { (o as TermsAndConditions).AcceptanceStatement = n.GetStringValue(); } },
                {"acceptanceStatuses", (o,n) => { (o as TermsAndConditions).AcceptanceStatuses = n.GetCollectionOfObjectValues<TermsAndConditionsAcceptanceStatus>().ToList(); } },
                {"assignments", (o,n) => { (o as TermsAndConditions).Assignments = n.GetCollectionOfObjectValues<TermsAndConditionsAssignment>().ToList(); } },
                {"bodyText", (o,n) => { (o as TermsAndConditions).BodyText = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as TermsAndConditions).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as TermsAndConditions).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as TermsAndConditions).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as TermsAndConditions).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"title", (o,n) => { (o as TermsAndConditions).Title = n.GetStringValue(); } },
                {"version", (o,n) => { (o as TermsAndConditions).Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("acceptanceStatement", AcceptanceStatement);
            writer.WriteCollectionOfObjectValues<TermsAndConditionsAcceptanceStatus>("acceptanceStatuses", AcceptanceStatuses);
            writer.WriteCollectionOfObjectValues<TermsAndConditionsAssignment>("assignments", Assignments);
            writer.WriteStringValue("bodyText", BodyText);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("title", Title);
            writer.WriteIntValue("version", Version);
        }
    }
}
