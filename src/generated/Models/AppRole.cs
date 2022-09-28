using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AppRole : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies whether this app role can be assigned to users and groups (by setting to [&apos;User&apos;]), to other application&apos;s (by setting to [&apos;Application&apos;], or both (by setting to [&apos;User&apos;, &apos;Application&apos;]). App roles supporting assignment to other applications&apos; service principals are also known as application permissions. The &apos;Application&apos; value is only supported for app roles defined on application entities.</summary>
        public List<string> AllowedMemberTypes { get; set; }
        /// <summary>The description for the app role. This is displayed when the app role is being assigned and, if the app role functions as an application permission, during  consent experiences.</summary>
        public string Description { get; set; }
        /// <summary>Display name for the permission that appears in the app role assignment and consent experiences.</summary>
        public string DisplayName { get; set; }
        /// <summary>Unique role identifier inside the appRoles collection. When creating a new app role, a new GUID identifier must be provided.</summary>
        public string Id { get; set; }
        /// <summary>When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Specifies if the app role is defined on the application object or on the servicePrincipal entity. Must not be included in any POST or PATCH requests. Read-only.</summary>
        public string Origin { get; set; }
        /// <summary>Specifies the value to include in the roles claim in ID tokens and access tokens authenticating an assigned user or service principal. Must not exceed 120 characters in length. Allowed characters are : ! # $ % &amp; &apos; ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..</summary>
        public string Value { get; set; }
        /// <summary>
        /// Instantiates a new appRole and sets the default values.
        /// </summary>
        public AppRole() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.appRole";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AppRole CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppRole();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowedMemberTypes", n => { AllowedMemberTypes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"origin", n => { Origin = n.GetStringValue(); } },
                {"value", n => { Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("allowedMemberTypes", AllowedMemberTypes);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("origin", Origin);
            writer.WriteStringValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
