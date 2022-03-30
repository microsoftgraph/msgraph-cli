using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ConditionalAccessSessionControls : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Session control to enforce application restrictions. Only Exchange Online and Sharepoint Online support this session control.</summary>
        public ApiSdk.Models.Microsoft.Graph.ApplicationEnforcedRestrictionsSessionControl ApplicationEnforcedRestrictions { get; set; }
        /// <summary>Session control to apply cloud app security.</summary>
        public ApiSdk.Models.Microsoft.Graph.CloudAppSecuritySessionControl CloudAppSecurity { get; set; }
        /// <summary>Session control that determines whether it is acceptable for Azure AD to extend existing sessions based on information collected prior to an outage or not.</summary>
        public bool? DisableResilienceDefaults { get; set; }
        /// <summary>Session control to define whether to persist cookies or not. All apps should be selected for this session control to work correctly.</summary>
        public ApiSdk.Models.Microsoft.Graph.PersistentBrowserSessionControl PersistentBrowser { get; set; }
        /// <summary>Session control to enforce signin frequency.</summary>
        public ApiSdk.Models.Microsoft.Graph.SignInFrequencySessionControl SignInFrequency { get; set; }
        /// <summary>
        /// Instantiates a new conditionalAccessSessionControls and sets the default values.
        /// </summary>
        public ConditionalAccessSessionControls() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.ConditionalAccessSessionControls CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessSessionControls();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"applicationEnforcedRestrictions", (o,n) => { (o as ConditionalAccessSessionControls).ApplicationEnforcedRestrictions = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ApplicationEnforcedRestrictionsSessionControl>(ApiSdk.Models.Microsoft.Graph.ApplicationEnforcedRestrictionsSessionControl.CreateFromDiscriminatorValue); } },
                {"cloudAppSecurity", (o,n) => { (o as ConditionalAccessSessionControls).CloudAppSecurity = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.CloudAppSecuritySessionControl>(ApiSdk.Models.Microsoft.Graph.CloudAppSecuritySessionControl.CreateFromDiscriminatorValue); } },
                {"disableResilienceDefaults", (o,n) => { (o as ConditionalAccessSessionControls).DisableResilienceDefaults = n.GetBoolValue(); } },
                {"persistentBrowser", (o,n) => { (o as ConditionalAccessSessionControls).PersistentBrowser = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PersistentBrowserSessionControl>(ApiSdk.Models.Microsoft.Graph.PersistentBrowserSessionControl.CreateFromDiscriminatorValue); } },
                {"signInFrequency", (o,n) => { (o as ConditionalAccessSessionControls).SignInFrequency = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.SignInFrequencySessionControl>(ApiSdk.Models.Microsoft.Graph.SignInFrequencySessionControl.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ApplicationEnforcedRestrictionsSessionControl>("applicationEnforcedRestrictions", ApplicationEnforcedRestrictions);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.CloudAppSecuritySessionControl>("cloudAppSecurity", CloudAppSecurity);
            writer.WriteBoolValue("disableResilienceDefaults", DisableResilienceDefaults);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PersistentBrowserSessionControl>("persistentBrowser", PersistentBrowser);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.SignInFrequencySessionControl>("signInFrequency", SignInFrequency);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
