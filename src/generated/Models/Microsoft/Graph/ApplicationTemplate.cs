using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ApplicationTemplate : Entity, IParsable {
        /// <summary>The list of categories for the application. Supported values can be: Collaboration, Business Management, Consumer, Content management, CRM, Data services, Developer services, E-commerce, Education, ERP, Finance, Health, Human resources, IT infrastructure, Mail, Management, Marketing, Media, Productivity, Project management, Telecommunications, Tools, Travel, and Web design & hosting.</summary>
        public List<string> Categories { get; set; }
        /// <summary>A description of the application.</summary>
        public string Description { get; set; }
        /// <summary>The name of the application.</summary>
        public string DisplayName { get; set; }
        /// <summary>The home page URL of the application.</summary>
        public string HomePageUrl { get; set; }
        /// <summary>The URL to get the logo for this application.</summary>
        public string LogoUrl { get; set; }
        /// <summary>The name of the publisher for this application.</summary>
        public string Publisher { get; set; }
        /// <summary>The list of provisioning modes supported by this application. The only valid value is sync.</summary>
        public List<string> SupportedProvisioningTypes { get; set; }
        /// <summary>The list of single sign-on modes supported by this application. The supported values are oidc, password, saml, and notSupported.</summary>
        public List<string> SupportedSingleSignOnModes { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"categories", (o,n) => { (o as ApplicationTemplate).Categories = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"description", (o,n) => { (o as ApplicationTemplate).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ApplicationTemplate).DisplayName = n.GetStringValue(); } },
                {"homePageUrl", (o,n) => { (o as ApplicationTemplate).HomePageUrl = n.GetStringValue(); } },
                {"logoUrl", (o,n) => { (o as ApplicationTemplate).LogoUrl = n.GetStringValue(); } },
                {"publisher", (o,n) => { (o as ApplicationTemplate).Publisher = n.GetStringValue(); } },
                {"supportedProvisioningTypes", (o,n) => { (o as ApplicationTemplate).SupportedProvisioningTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportedSingleSignOnModes", (o,n) => { (o as ApplicationTemplate).SupportedSingleSignOnModes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("categories", Categories);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("homePageUrl", HomePageUrl);
            writer.WriteStringValue("logoUrl", LogoUrl);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedProvisioningTypes", SupportedProvisioningTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedSingleSignOnModes", SupportedSingleSignOnModes);
        }
    }
}
