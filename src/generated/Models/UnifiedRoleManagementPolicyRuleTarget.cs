using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class UnifiedRoleManagementPolicyRuleTarget : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The caller for the policy rule target. Allowed values are: None, Admin, EndUser.</summary>
        public string Caller { get; set; }
        /// <summary>The list of settings which are enforced and cannot be overridden by child scopes. Use All for all settings.</summary>
        public List<string> EnforcedSettings { get; set; }
        /// <summary>The list of settings which can be inherited by child scopes. Use All for all settings.</summary>
        public List<string> InheritableSettings { get; set; }
        /// <summary>The level for the policy rule target. Allowed values are: Eligibility, Assignment.</summary>
        public string Level { get; set; }
        /// <summary>The operations for policy rule target. Allowed values are: All, Activate, Deactivate, Assign, Update, Remove, Extend, Renew.</summary>
        public List<UnifiedRoleManagementPolicyRuleTargetOperations?> Operations { get; set; }
        /// <summary>The targetObjects property</summary>
        public List<DirectoryObject> TargetObjects { get; set; }
        /// <summary>
        /// Instantiates a new unifiedRoleManagementPolicyRuleTarget and sets the default values.
        /// </summary>
        public UnifiedRoleManagementPolicyRuleTarget() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UnifiedRoleManagementPolicyRuleTarget CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleManagementPolicyRuleTarget();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"caller", n => { Caller = n.GetStringValue(); } },
                {"enforcedSettings", n => { EnforcedSettings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"inheritableSettings", n => { InheritableSettings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"level", n => { Level = n.GetStringValue(); } },
                {"operations", n => { Operations = n.GetCollectionOfEnumValues<UnifiedRoleManagementPolicyRuleTargetOperations>().ToList(); } },
                {"targetObjects", n => { TargetObjects = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("caller", Caller);
            writer.WriteCollectionOfPrimitiveValues<string>("enforcedSettings", EnforcedSettings);
            writer.WriteCollectionOfPrimitiveValues<string>("inheritableSettings", InheritableSettings);
            writer.WriteStringValue("level", Level);
            writer.WriteCollectionOfEnumValues<UnifiedRoleManagementPolicyRuleTargetOperations>("operations", Operations);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("targetObjects", TargetObjects);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
