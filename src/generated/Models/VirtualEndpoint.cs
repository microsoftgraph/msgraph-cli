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
    public partial class VirtualEndpoint : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A collection of Cloud PC audit events.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPcAuditEvent>? AuditEvents { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPcAuditEvent> AuditEvents { get; set; }
#endif
        /// <summary>A collection of cloud-managed virtual desktops.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPC>? CloudPCs { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPC> CloudPCs { get; set; }
#endif
        /// <summary>A collection of device image resources on Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPcDeviceImage>? DeviceImages { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPcDeviceImage> DeviceImages { get; set; }
#endif
        /// <summary>A collection of gallery image resources on Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPcGalleryImage>? GalleryImages { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPcGalleryImage> GalleryImages { get; set; }
#endif
        /// <summary>A defined collection of Azure resource information that can be used to establish Azure network connections for Cloud PCs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPcOnPremisesConnection>? OnPremisesConnections { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPcOnPremisesConnection> OnPremisesConnections { get; set; }
#endif
        /// <summary>A collection of Cloud PC provisioning policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPcProvisioningPolicy>? ProvisioningPolicies { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPcProvisioningPolicy> ProvisioningPolicies { get; set; }
#endif
        /// <summary>A collection of Cloud PC user settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.CloudPcUserSetting>? UserSettings { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.CloudPcUserSetting> UserSettings { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.VirtualEndpoint"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.VirtualEndpoint CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.VirtualEndpoint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "auditEvents", n => { AuditEvents = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPcAuditEvent>(global::ApiSdk.Models.CloudPcAuditEvent.CreateFromDiscriminatorValue)?.AsList(); } },
                { "cloudPCs", n => { CloudPCs = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPC>(global::ApiSdk.Models.CloudPC.CreateFromDiscriminatorValue)?.AsList(); } },
                { "deviceImages", n => { DeviceImages = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPcDeviceImage>(global::ApiSdk.Models.CloudPcDeviceImage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "galleryImages", n => { GalleryImages = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPcGalleryImage>(global::ApiSdk.Models.CloudPcGalleryImage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "onPremisesConnections", n => { OnPremisesConnections = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPcOnPremisesConnection>(global::ApiSdk.Models.CloudPcOnPremisesConnection.CreateFromDiscriminatorValue)?.AsList(); } },
                { "provisioningPolicies", n => { ProvisioningPolicies = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPcProvisioningPolicy>(global::ApiSdk.Models.CloudPcProvisioningPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "userSettings", n => { UserSettings = n.GetCollectionOfObjectValues<global::ApiSdk.Models.CloudPcUserSetting>(global::ApiSdk.Models.CloudPcUserSetting.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPcAuditEvent>("auditEvents", AuditEvents);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPC>("cloudPCs", CloudPCs);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPcDeviceImage>("deviceImages", DeviceImages);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPcGalleryImage>("galleryImages", GalleryImages);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPcOnPremisesConnection>("onPremisesConnections", OnPremisesConnections);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPcProvisioningPolicy>("provisioningPolicies", ProvisioningPolicies);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.CloudPcUserSetting>("userSettings", UserSettings);
        }
    }
}
#pragma warning restore CS0618
