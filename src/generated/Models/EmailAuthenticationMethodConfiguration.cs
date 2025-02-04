// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class EmailAuthenticationMethodConfiguration : global::ApiSdk.Models.AuthenticationMethodConfiguration, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Determines whether email OTP is usable by external users for authentication. Possible values are: default, enabled, disabled, unknownFutureValue. Tenants in the default state who didn&apos;t use public preview have email OTP enabled beginning in October 2021.</summary>
        public global::ApiSdk.Models.ExternalEmailOtpState? AllowExternalIdToUseEmailOtp { get; set; }
        /// <summary>A collection of groups that are enabled to use the authentication method.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.AuthenticationMethodTarget>? IncludeTargets { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.AuthenticationMethodTarget> IncludeTargets { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.EmailAuthenticationMethodConfiguration"/> and sets the default values.
        /// </summary>
        public EmailAuthenticationMethodConfiguration() : base()
        {
            OdataType = "#microsoft.graph.emailAuthenticationMethodConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.EmailAuthenticationMethodConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.EmailAuthenticationMethodConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.EmailAuthenticationMethodConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowExternalIdToUseEmailOtp", n => { AllowExternalIdToUseEmailOtp = n.GetEnumValue<global::ApiSdk.Models.ExternalEmailOtpState>(); } },
                { "includeTargets", n => { IncludeTargets = n.GetCollectionOfObjectValues<global::ApiSdk.Models.AuthenticationMethodTarget>(global::ApiSdk.Models.AuthenticationMethodTarget.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<global::ApiSdk.Models.ExternalEmailOtpState>("allowExternalIdToUseEmailOtp", AllowExternalIdToUseEmailOtp);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.AuthenticationMethodTarget>("includeTargets", IncludeTargets);
        }
    }
}
#pragma warning restore CS0618
