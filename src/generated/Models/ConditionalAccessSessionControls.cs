using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class ConditionalAccessSessionControls : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Session control to enforce application restrictions. Only Exchange Online and Sharepoint Online support this session control.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApplicationEnforcedRestrictionsSessionControl? ApplicationEnforcedRestrictions { get; set; }
#nullable restore
#else
        public ApplicationEnforcedRestrictionsSessionControl ApplicationEnforcedRestrictions { get; set; }
#endif
        /// <summary>Session control to apply cloud app security.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudAppSecuritySessionControl? CloudAppSecurity { get; set; }
#nullable restore
#else
        public CloudAppSecuritySessionControl CloudAppSecurity { get; set; }
#endif
        /// <summary>Session control that determines whether it is acceptable for Azure AD to extend existing sessions based on information collected prior to an outage or not.</summary>
        public bool? DisableResilienceDefaults { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Session control to define whether to persist cookies or not. All apps should be selected for this session control to work correctly.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PersistentBrowserSessionControl? PersistentBrowser { get; set; }
#nullable restore
#else
        public PersistentBrowserSessionControl PersistentBrowser { get; set; }
#endif
        /// <summary>Session control to enforce signin frequency.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SignInFrequencySessionControl? SignInFrequency { get; set; }
#nullable restore
#else
        public SignInFrequencySessionControl SignInFrequency { get; set; }
#endif
        /// <summary>
        /// Instantiates a new conditionalAccessSessionControls and sets the default values.
        /// </summary>
        public ConditionalAccessSessionControls() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConditionalAccessSessionControls CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessSessionControls();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applicationEnforcedRestrictions", n => { ApplicationEnforcedRestrictions = n.GetObjectValue<ApplicationEnforcedRestrictionsSessionControl>(ApplicationEnforcedRestrictionsSessionControl.CreateFromDiscriminatorValue); } },
                {"cloudAppSecurity", n => { CloudAppSecurity = n.GetObjectValue<CloudAppSecuritySessionControl>(CloudAppSecuritySessionControl.CreateFromDiscriminatorValue); } },
                {"disableResilienceDefaults", n => { DisableResilienceDefaults = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"persistentBrowser", n => { PersistentBrowser = n.GetObjectValue<PersistentBrowserSessionControl>(PersistentBrowserSessionControl.CreateFromDiscriminatorValue); } },
                {"signInFrequency", n => { SignInFrequency = n.GetObjectValue<SignInFrequencySessionControl>(SignInFrequencySessionControl.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApplicationEnforcedRestrictionsSessionControl>("applicationEnforcedRestrictions", ApplicationEnforcedRestrictions);
            writer.WriteObjectValue<CloudAppSecuritySessionControl>("cloudAppSecurity", CloudAppSecurity);
            writer.WriteBoolValue("disableResilienceDefaults", DisableResilienceDefaults);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<PersistentBrowserSessionControl>("persistentBrowser", PersistentBrowser);
            writer.WriteObjectValue<SignInFrequencySessionControl>("signInFrequency", SignInFrequency);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
