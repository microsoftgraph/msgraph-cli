using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ConditionalAccessSessionControls : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Session control to enforce application restrictions. Only Exchange Online and Sharepoint Online support this session control.</summary>
        public ApplicationEnforcedRestrictionsSessionControl ApplicationEnforcedRestrictions { get; set; }
        /// <summary>Session control to apply cloud app security.</summary>
        public CloudAppSecuritySessionControl CloudAppSecurity { get; set; }
        /// <summary>Session control to define whether to persist cookies or not. All apps should be selected for this session control to work correctly.</summary>
        public PersistentBrowserSessionControl PersistentBrowser { get; set; }
        /// <summary>Session control to enforce signin frequency.</summary>
        public SignInFrequencySessionControl SignInFrequency { get; set; }
        /// <summary>
        /// Instantiates a new conditionalAccessSessionControls and sets the default values.
        /// </summary>
        public ConditionalAccessSessionControls() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"applicationEnforcedRestrictions", (o,n) => { (o as ConditionalAccessSessionControls).ApplicationEnforcedRestrictions = n.GetObjectValue<ApplicationEnforcedRestrictionsSessionControl>(); } },
                {"cloudAppSecurity", (o,n) => { (o as ConditionalAccessSessionControls).CloudAppSecurity = n.GetObjectValue<CloudAppSecuritySessionControl>(); } },
                {"persistentBrowser", (o,n) => { (o as ConditionalAccessSessionControls).PersistentBrowser = n.GetObjectValue<PersistentBrowserSessionControl>(); } },
                {"signInFrequency", (o,n) => { (o as ConditionalAccessSessionControls).SignInFrequency = n.GetObjectValue<SignInFrequencySessionControl>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApplicationEnforcedRestrictionsSessionControl>("applicationEnforcedRestrictions", ApplicationEnforcedRestrictions);
            writer.WriteObjectValue<CloudAppSecuritySessionControl>("cloudAppSecurity", CloudAppSecurity);
            writer.WriteObjectValue<PersistentBrowserSessionControl>("persistentBrowser", PersistentBrowser);
            writer.WriteObjectValue<SignInFrequencySessionControl>("signInFrequency", SignInFrequency);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
