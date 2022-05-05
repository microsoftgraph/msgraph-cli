using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AppliedConditionalAccessPolicy : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the conditional access policy.</summary>
        public string DisplayName { get; set; }
        /// <summary>Refers to the grant controls enforced by the conditional access policy (example: &apos;Require multi-factor authentication&apos;).</summary>
        public List<string> EnforcedGrantControls { get; set; }
        /// <summary>Refers to the session controls enforced by the conditional access policy (example: &apos;Require app enforced controls&apos;).</summary>
        public List<string> EnforcedSessionControls { get; set; }
        /// <summary>Identifier of the conditional access policy.</summary>
        public string Id { get; set; }
        /// <summary>Indicates the result of the CA policy that was triggered. Possible values are: success, failure, notApplied (Policy isn&apos;t applied because policy conditions were not met),notEnabled (This is due to the policy in disabled state), unknown, unknownFutureValue, reportOnlySuccess, reportOnlyFailure, reportOnlyNotApplied, reportOnlyInterrupted. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: reportOnlySuccess, reportOnlyFailure, reportOnlyNotApplied, reportOnlyInterrupted.</summary>
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
        public static AppliedConditionalAccessPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppliedConditionalAccessPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enforcedGrantControls", n => { EnforcedGrantControls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"enforcedSessionControls", n => { EnforcedSessionControls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"result", n => { Result = n.GetEnumValue<AppliedConditionalAccessPolicyResult>(); } },
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
