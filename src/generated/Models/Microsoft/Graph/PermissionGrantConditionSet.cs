using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PermissionGrantConditionSet : Entity, IParsable {
        /// <summary>A list of appId values for the client applications to match with, or a list with the single value all to match any client application. Default is the single value all.</summary>
        public List<string> ClientApplicationIds { get; set; }
        /// <summary>A list of Microsoft Partner Network (MPN) IDs for verified publishers of the client application, or a list with the single value all to match with client apps from any publisher. Default is the single value all.</summary>
        public List<string> ClientApplicationPublisherIds { get; set; }
        /// <summary>Set to true to only match on client applications with a verified publisher. Set to false to match on any client app, even if it does not have a verified publisher. Default is false.</summary>
        public bool? ClientApplicationsFromVerifiedPublisherOnly { get; set; }
        /// <summary>A list of Azure Active Directory tenant IDs in which the client application is registered, or a list with the single value all to match with client apps registered in any tenant. Default is the single value all.</summary>
        public List<string> ClientApplicationTenantIds { get; set; }
        /// <summary>The permission classification for the permission being granted, or all to match with any permission classification (including permissions which are not classified). Default is all.</summary>
        public string PermissionClassification { get; set; }
        /// <summary>The list of id values for the specific permissions to match with, or a list with the single value all to match with any permission. The id of delegated permissions can be found in the publishedPermissionScopes property of the API's **servicePrincipal** object. The id of application permissions can be found in the appRoles property of the API's **servicePrincipal** object. The id of resource-specific application permissions can be found in the resourceSpecificApplicationPermissions property of the API's **servicePrincipal** object. Default is the single value all.</summary>
        public List<string> Permissions { get; set; }
        /// <summary>The permission type of the permission being granted. Possible values: application for application permissions (e.g. app roles), or delegated for delegated permissions. The value delegatedUserConsentable indicates delegated permissions which have not been configured by the API publisher to require admin consent—this value may be used in built-in permission grant policies, but cannot be used in custom permission grant policies. Required.</summary>
        public PermissionType? PermissionType { get; set; }
        /// <summary>The appId of the resource application (e.g. the API) for which a permission is being granted, or any to match with any resource application or API. Default is any.</summary>
        public string ResourceApplication { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"clientApplicationIds", (o,n) => { (o as PermissionGrantConditionSet).ClientApplicationIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"clientApplicationPublisherIds", (o,n) => { (o as PermissionGrantConditionSet).ClientApplicationPublisherIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"clientApplicationsFromVerifiedPublisherOnly", (o,n) => { (o as PermissionGrantConditionSet).ClientApplicationsFromVerifiedPublisherOnly = n.GetBoolValue(); } },
                {"clientApplicationTenantIds", (o,n) => { (o as PermissionGrantConditionSet).ClientApplicationTenantIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"permissionClassification", (o,n) => { (o as PermissionGrantConditionSet).PermissionClassification = n.GetStringValue(); } },
                {"permissions", (o,n) => { (o as PermissionGrantConditionSet).Permissions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"permissionType", (o,n) => { (o as PermissionGrantConditionSet).PermissionType = n.GetEnumValue<PermissionType>(); } },
                {"resourceApplication", (o,n) => { (o as PermissionGrantConditionSet).ResourceApplication = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("clientApplicationIds", ClientApplicationIds);
            writer.WriteCollectionOfPrimitiveValues<string>("clientApplicationPublisherIds", ClientApplicationPublisherIds);
            writer.WriteBoolValue("clientApplicationsFromVerifiedPublisherOnly", ClientApplicationsFromVerifiedPublisherOnly);
            writer.WriteCollectionOfPrimitiveValues<string>("clientApplicationTenantIds", ClientApplicationTenantIds);
            writer.WriteStringValue("permissionClassification", PermissionClassification);
            writer.WriteCollectionOfPrimitiveValues<string>("permissions", Permissions);
            writer.WriteEnumValue<PermissionType>("permissionType", PermissionType);
            writer.WriteStringValue("resourceApplication", ResourceApplication);
        }
    }
}
