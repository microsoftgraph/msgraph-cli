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
    public partial class FileStorageContainer : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Container type ID of the fileStorageContainer. For details about container types, see Container Types. Each container must have only one container type. Read-only.</summary>
        public Guid? ContainerTypeId { get; set; }
        /// <summary>Date and time of the fileStorageContainer creation. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Custom property collection for the fileStorageContainer. Read-write.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.FileStorageContainerCustomPropertyDictionary? CustomProperties { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.FileStorageContainerCustomPropertyDictionary CustomProperties { get; set; }
#endif
        /// <summary>Provides a user-visible description of the fileStorageContainer. Read-write.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The display name of the fileStorageContainer. Read-write.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The drive of the resource fileStorageContainer. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Drive? Drive { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Drive Drive { get; set; }
#endif
        /// <summary>Indicates the lock state of the fileStorageContainer. The possible values are unlocked and lockedReadOnly. Read-only.</summary>
        public global::ApiSdk.Models.SiteLockState? LockState { get; set; }
        /// <summary>The set of permissions for users in the fileStorageContainer. Permission for each user is set by the roles property. The possible values are: reader, writer, manager, and owner. Read-write.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Permission>? Permissions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Permission> Permissions { get; set; }
#endif
        /// <summary>Recycle bin of the fileStorageContainer. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.RecycleBin? RecycleBin { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.RecycleBin RecycleBin { get; set; }
#endif
        /// <summary>The settings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.FileStorageContainerSettings? Settings { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.FileStorageContainerSettings Settings { get; set; }
#endif
        /// <summary>Status of the fileStorageContainer. Containers are created as inactive and require activation. Inactive containers are subjected to automatic deletion in 24 hours. The possible values are: inactive, active. Read-only.</summary>
        public global::ApiSdk.Models.FileStorageContainerStatus? Status { get; set; }
        /// <summary>Data specific to the current user. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.FileStorageContainerViewpoint? Viewpoint { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.FileStorageContainerViewpoint Viewpoint { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.FileStorageContainer"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.FileStorageContainer CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.FileStorageContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "containerTypeId", n => { ContainerTypeId = n.GetGuidValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "customProperties", n => { CustomProperties = n.GetObjectValue<global::ApiSdk.Models.FileStorageContainerCustomPropertyDictionary>(global::ApiSdk.Models.FileStorageContainerCustomPropertyDictionary.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "drive", n => { Drive = n.GetObjectValue<global::ApiSdk.Models.Drive>(global::ApiSdk.Models.Drive.CreateFromDiscriminatorValue); } },
                { "lockState", n => { LockState = n.GetEnumValue<global::ApiSdk.Models.SiteLockState>(); } },
                { "permissions", n => { Permissions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Permission>(global::ApiSdk.Models.Permission.CreateFromDiscriminatorValue)?.AsList(); } },
                { "recycleBin", n => { RecycleBin = n.GetObjectValue<global::ApiSdk.Models.RecycleBin>(global::ApiSdk.Models.RecycleBin.CreateFromDiscriminatorValue); } },
                { "settings", n => { Settings = n.GetObjectValue<global::ApiSdk.Models.FileStorageContainerSettings>(global::ApiSdk.Models.FileStorageContainerSettings.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetEnumValue<global::ApiSdk.Models.FileStorageContainerStatus>(); } },
                { "viewpoint", n => { Viewpoint = n.GetObjectValue<global::ApiSdk.Models.FileStorageContainerViewpoint>(global::ApiSdk.Models.FileStorageContainerViewpoint.CreateFromDiscriminatorValue); } },
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
            writer.WriteGuidValue("containerTypeId", ContainerTypeId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.FileStorageContainerCustomPropertyDictionary>("customProperties", CustomProperties);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::ApiSdk.Models.Drive>("drive", Drive);
            writer.WriteEnumValue<global::ApiSdk.Models.SiteLockState>("lockState", LockState);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Permission>("permissions", Permissions);
            writer.WriteObjectValue<global::ApiSdk.Models.RecycleBin>("recycleBin", RecycleBin);
            writer.WriteObjectValue<global::ApiSdk.Models.FileStorageContainerSettings>("settings", Settings);
            writer.WriteEnumValue<global::ApiSdk.Models.FileStorageContainerStatus>("status", Status);
            writer.WriteObjectValue<global::ApiSdk.Models.FileStorageContainerViewpoint>("viewpoint", Viewpoint);
        }
    }
}
#pragma warning restore CS0618
