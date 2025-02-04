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
    public partial class VirtualEventWebinar : global::ApiSdk.Models.VirtualEvent, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>To whom the webinar is visible. Possible values are: everyone, organization, and unknownFutureValue.</summary>
        public global::ApiSdk.Models.MeetingAudience? Audience { get; set; }
        /// <summary>Identity information of coorganizers of the webinar.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CommunicationsUserIdentity>? CoOrganizers { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CommunicationsUserIdentity> CoOrganizers { get; set; }
#endif
        /// <summary>Registration configuration of the webinar.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.VirtualEventWebinarRegistrationConfiguration? RegistrationConfiguration { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.VirtualEventWebinarRegistrationConfiguration RegistrationConfiguration { get; set; }
#endif
        /// <summary>Registration records of the webinar.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.VirtualEventRegistration>? Registrations { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.VirtualEventRegistration> Registrations { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.VirtualEventWebinar"/> and sets the default values.
        /// </summary>
        public VirtualEventWebinar() : base()
        {
            OdataType = "#microsoft.graph.virtualEventWebinar";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.VirtualEventWebinar"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.VirtualEventWebinar CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.VirtualEventWebinar();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "audience", n => { Audience = n.GetEnumValue<global::ApiSdk.Models.MeetingAudience>(); } },
                { "coOrganizers", n => { CoOrganizers = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CommunicationsUserIdentity>(global::ApiSdk.Models.CommunicationsUserIdentity.CreateFromDiscriminatorValue)?.AsList(); } },
                { "registrationConfiguration", n => { RegistrationConfiguration = n.GetObjectValue<global::ApiSdk.Models.VirtualEventWebinarRegistrationConfiguration>(global::ApiSdk.Models.VirtualEventWebinarRegistrationConfiguration.CreateFromDiscriminatorValue); } },
                { "registrations", n => { Registrations = n.GetCollectionOfObjectValues<global::ApiSdk.Models.VirtualEventRegistration>(global::ApiSdk.Models.VirtualEventRegistration.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.MeetingAudience>("audience", Audience);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CommunicationsUserIdentity>("coOrganizers", CoOrganizers);
            writer.WriteObjectValue<global::ApiSdk.Models.VirtualEventWebinarRegistrationConfiguration>("registrationConfiguration", RegistrationConfiguration);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.VirtualEventRegistration>("registrations", Registrations);
        }
    }
}
#pragma warning restore CS0618
