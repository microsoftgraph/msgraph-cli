using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AppliedConditionalAccessPolicy : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Refers to the Name of the conditional access policy (example: 'Require MFA for Salesforce').</summary>
        public string DisplayName { get; set; }
        /// <summary>Refers to the grant controls enforced by the conditional access policy (example: 'Require multi-factor authentication').</summary>
        public List<string> EnforcedGrantControls { get; set; }
        /// <summary>Refers to the session controls enforced by the conditional access policy (example: 'Require app enforced controls').</summary>
        public List<string> EnforcedSessionControls { get; set; }
        /// <summary>An identifier of the conditional access policy.</summary>
        public string Id { get; set; }
        /// <summary>Indicates the result of the CA policy that was triggered. Possible values are: success, failure, notApplied (Policy isn't applied because policy conditions were not met),notEnabled (This is due to the policy in disabled state), unknown, unknownFutureValue.</summary>
        public AppliedConditionalAccessPolicyResult? Result { get; set; }
        /// <summary>
        /// Instantiates a new appliedConditionalAccessPolicy and sets the default values.
        /// </summary>
        public AppliedConditionalAccessPolicy() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.AppliedConditionalAccessPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppliedConditionalAccessPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as AppliedConditionalAccessPolicy).DisplayName = n.GetStringValue(); } },
                {"enforcedGrantControls", (o,n) => { (o as AppliedConditionalAccessPolicy).EnforcedGrantControls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"enforcedSessionControls", (o,n) => { (o as AppliedConditionalAccessPolicy).EnforcedSessionControls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"id", (o,n) => { (o as AppliedConditionalAccessPolicy).Id = n.GetStringValue(); } },
                {"result", (o,n) => { (o as AppliedConditionalAccessPolicy).Result = n.GetEnumValue<AppliedConditionalAccessPolicyResult>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("enforcedGrantControls", EnforcedGrantControls);
            writer.WriteCollectionOfPrimitiveValues<string>("enforcedSessionControls", EnforcedSessionControls);
            writer.WriteStringValue("id", Id);
            writer.WriteEnumValue<AppliedConditionalAccessPolicyResult>("result", Result);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
