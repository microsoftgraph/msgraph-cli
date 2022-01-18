using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AdminConsentRequestPolicy : Entity, IParsable {
        /// <summary>Specifies whether the admin consent request feature is enabled or disabled. Required.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>Specifies whether reviewers will receive notifications. Required.</summary>
        public bool? NotifyReviewers { get; set; }
        /// <summary>Specifies whether reviewers will receive reminder emails. Required.</summary>
        public bool? RemindersEnabled { get; set; }
        /// <summary>Specifies the duration the request is active before it automatically expires if no decision is applied.</summary>
        public int? RequestDurationInDays { get; set; }
        /// <summary>Required.</summary>
        public List<AccessReviewReviewerScope> Reviewers { get; set; }
        /// <summary>Specifies the version of this policy. When the policy is updated, this version is updated. Read-only.</summary>
        public int? Version { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"isEnabled", (o,n) => { (o as AdminConsentRequestPolicy).IsEnabled = n.GetBoolValue(); } },
                {"notifyReviewers", (o,n) => { (o as AdminConsentRequestPolicy).NotifyReviewers = n.GetBoolValue(); } },
                {"remindersEnabled", (o,n) => { (o as AdminConsentRequestPolicy).RemindersEnabled = n.GetBoolValue(); } },
                {"requestDurationInDays", (o,n) => { (o as AdminConsentRequestPolicy).RequestDurationInDays = n.GetIntValue(); } },
                {"reviewers", (o,n) => { (o as AdminConsentRequestPolicy).Reviewers = n.GetCollectionOfObjectValues<AccessReviewReviewerScope>().ToList(); } },
                {"version", (o,n) => { (o as AdminConsentRequestPolicy).Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteBoolValue("notifyReviewers", NotifyReviewers);
            writer.WriteBoolValue("remindersEnabled", RemindersEnabled);
            writer.WriteIntValue("requestDurationInDays", RequestDurationInDays);
            writer.WriteCollectionOfObjectValues<AccessReviewReviewerScope>("reviewers", Reviewers);
            writer.WriteIntValue("version", Version);
        }
    }
}
