using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AppIdentity : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Refers to the Unique GUID representing Application Id in the Azure Active Directory.</summary>
        public string AppId { get; set; }
        /// <summary>Refers to the Application Name displayed in the Azure Portal.</summary>
        public string DisplayName { get; set; }
        /// <summary>Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.</summary>
        public string ServicePrincipalId { get; set; }
        /// <summary>Refers to the Service Principal Name is the Application name in the tenant.</summary>
        public string ServicePrincipalName { get; set; }
        /// <summary>
        /// Instantiates a new appIdentity and sets the default values.
        /// </summary>
        public AppIdentity() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"appId", (o,n) => { (o as AppIdentity).AppId = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AppIdentity).DisplayName = n.GetStringValue(); } },
                {"servicePrincipalId", (o,n) => { (o as AppIdentity).ServicePrincipalId = n.GetStringValue(); } },
                {"servicePrincipalName", (o,n) => { (o as AppIdentity).ServicePrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("servicePrincipalId", ServicePrincipalId);
            writer.WriteStringValue("servicePrincipalName", ServicePrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
