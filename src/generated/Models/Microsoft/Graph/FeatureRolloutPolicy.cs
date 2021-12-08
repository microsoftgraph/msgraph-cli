using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class FeatureRolloutPolicy : Entity, IParsable {
        /// <summary>Nullable. Specifies a list of directoryObjects that feature is enabled for.</summary>
        public List<DirectoryObject> AppliesTo { get; set; }
        /// <summary>A description for this feature rollout policy.</summary>
        public string Description { get; set; }
        /// <summary>The display name for this  feature rollout policy.</summary>
        public string DisplayName { get; set; }
        /// <summary>Possible values are: passthroughAuthentication, seamlessSso, passwordHashSync, emailAsAlternateId, unknownFutureValue.</summary>
        public StagedFeatureName? Feature { get; set; }
        /// <summary>Indicates whether this feature rollout policy should be applied to the entire organization.</summary>
        public bool? IsAppliedToOrganization { get; set; }
        /// <summary>Indicates whether the feature rollout is enabled.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appliesTo", (o,n) => { (o as FeatureRolloutPolicy).AppliesTo = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
                {"description", (o,n) => { (o as FeatureRolloutPolicy).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as FeatureRolloutPolicy).DisplayName = n.GetStringValue(); } },
                {"feature", (o,n) => { (o as FeatureRolloutPolicy).Feature = n.GetEnumValue<StagedFeatureName>(); } },
                {"isAppliedToOrganization", (o,n) => { (o as FeatureRolloutPolicy).IsAppliedToOrganization = n.GetBoolValue(); } },
                {"isEnabled", (o,n) => { (o as FeatureRolloutPolicy).IsEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("appliesTo", AppliesTo);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<StagedFeatureName>("feature", Feature);
            writer.WriteBoolValue("isAppliedToOrganization", IsAppliedToOrganization);
            writer.WriteBoolValue("isEnabled", IsEnabled);
        }
    }
}
