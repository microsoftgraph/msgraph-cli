using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AppRoleAssignment : DirectoryObject, IParsable {
        /// <summary>The identifier (id) for the app role which is assigned to the principal. This app role must be exposed in the appRoles property on the resource application's service principal (resourceId). If the resource application has not declared any app roles, a default app role ID of 00000000-0000-0000-0000-000000000000 can be specified to signal that the principal is assigned to the resource app without any specific app roles. Required on create.</summary>
        public string AppRoleId { get; set; }
        /// <summary>The time when the app role assignment was created.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The display name of the user, group, or service principal that was granted the app role assignment. Read-only. Supports $filter (eq and startswith).</summary>
        public string PrincipalDisplayName { get; set; }
        /// <summary>The unique identifier (id) for the user, group or service principal being granted the app role. Required on create.</summary>
        public string PrincipalId { get; set; }
        /// <summary>The type of the assigned principal. This can either be User, Group or ServicePrincipal. Read-only.</summary>
        public string PrincipalType { get; set; }
        /// <summary>The display name of the resource app's service principal to which the assignment is made.</summary>
        public string ResourceDisplayName { get; set; }
        /// <summary>The unique identifier (id) for the resource service principal for which the assignment is made. Required on create. Supports $filter (eq only).</summary>
        public string ResourceId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appRoleId", (o,n) => { (o as AppRoleAssignment).AppRoleId = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as AppRoleAssignment).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"principalDisplayName", (o,n) => { (o as AppRoleAssignment).PrincipalDisplayName = n.GetStringValue(); } },
                {"principalId", (o,n) => { (o as AppRoleAssignment).PrincipalId = n.GetStringValue(); } },
                {"principalType", (o,n) => { (o as AppRoleAssignment).PrincipalType = n.GetStringValue(); } },
                {"resourceDisplayName", (o,n) => { (o as AppRoleAssignment).ResourceDisplayName = n.GetStringValue(); } },
                {"resourceId", (o,n) => { (o as AppRoleAssignment).ResourceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appRoleId", AppRoleId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("principalDisplayName", PrincipalDisplayName);
            writer.WriteStringValue("principalId", PrincipalId);
            writer.WriteStringValue("principalType", PrincipalType);
            writer.WriteStringValue("resourceDisplayName", ResourceDisplayName);
            writer.WriteStringValue("resourceId", ResourceId);
        }
    }
}
