using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AuthenticationMethodsRegistrationCampaign : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Users and groups of users that are excluded from being prompted to set up the authentication method.</summary>
        public List<ExcludeTarget> ExcludeTargets { get; set; }
        /// <summary>Users and groups of users that are prompted to set up the authentication method.</summary>
        public List<AuthenticationMethodsRegistrationCampaignIncludeTarget> IncludeTargets { get; set; }
        /// <summary>Specifies the number of days that the user sees a prompt again if they select 'Not now' and snoozes the prompt. Minimum 0 days. Maximum: 14 days. If the value is '0' – The user is prompted during every MFA attempt.</summary>
        public int? SnoozeDurationInDays { get; set; }
        /// <summary>Enable or disable the feature. Possible values are: default, enabled, disabled, unknownFutureValue. The default value is used when the configuration hasn't been explicitly set and uses the default behavior of Azure AD for the setting. The default value is disabled.</summary>
        public AdvancedConfigState? State { get; set; }
        /// <summary>
        /// Instantiates a new authenticationMethodsRegistrationCampaign and sets the default values.
        /// </summary>
        public AuthenticationMethodsRegistrationCampaign() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"excludeTargets", (o,n) => { (o as AuthenticationMethodsRegistrationCampaign).ExcludeTargets = n.GetCollectionOfObjectValues<ExcludeTarget>().ToList(); } },
                {"includeTargets", (o,n) => { (o as AuthenticationMethodsRegistrationCampaign).IncludeTargets = n.GetCollectionOfObjectValues<AuthenticationMethodsRegistrationCampaignIncludeTarget>().ToList(); } },
                {"snoozeDurationInDays", (o,n) => { (o as AuthenticationMethodsRegistrationCampaign).SnoozeDurationInDays = n.GetIntValue(); } },
                {"state", (o,n) => { (o as AuthenticationMethodsRegistrationCampaign).State = n.GetEnumValue<AdvancedConfigState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ExcludeTarget>("excludeTargets", ExcludeTargets);
            writer.WriteCollectionOfObjectValues<AuthenticationMethodsRegistrationCampaignIncludeTarget>("includeTargets", IncludeTargets);
            writer.WriteIntValue("snoozeDurationInDays", SnoozeDurationInDays);
            writer.WriteEnumValue<AdvancedConfigState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
