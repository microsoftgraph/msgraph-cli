using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.DirectoryObjects.GetAvailableExtensionProperties {
    public class GetAvailableExtensionProperties : DirectoryObject, IParsable {
        /// <summary>Display name of the application object on which this extension property is defined. Read-only.</summary>
        public string AppDisplayName { get; set; }
        /// <summary>Specifies the data type of the value the extension property can hold. Following values are supported. Not nullable. Binary - 256 bytes maximumBooleanDateTime - Must be specified in ISO 8601 format. Will be stored in UTC.Integer - 32-bit value.LargeInteger - 64-bit value.String - 256 characters maximum</summary>
        public string DataType { get; set; }
        /// <summary>Indicates if this extension property was sycned from onpremises directory using Azure AD Connect. Read-only.</summary>
        public bool? IsSyncedFromOnPremises { get; set; }
        /// <summary>Name of the extension property. Not nullable.</summary>
        public string Name { get; set; }
        /// <summary>Following values are supported. Not nullable. UserGroupOrganizationDeviceApplication</summary>
        public List<string> TargetObjects { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appDisplayName", (o,n) => { (o as GetAvailableExtensionProperties).AppDisplayName = n.GetStringValue(); } },
                {"dataType", (o,n) => { (o as GetAvailableExtensionProperties).DataType = n.GetStringValue(); } },
                {"isSyncedFromOnPremises", (o,n) => { (o as GetAvailableExtensionProperties).IsSyncedFromOnPremises = n.GetBoolValue(); } },
                {"name", (o,n) => { (o as GetAvailableExtensionProperties).Name = n.GetStringValue(); } },
                {"targetObjects", (o,n) => { (o as GetAvailableExtensionProperties).TargetObjects = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("dataType", DataType);
            writer.WriteBoolValue("isSyncedFromOnPremises", IsSyncedFromOnPremises);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfPrimitiveValues<string>("targetObjects", TargetObjects);
        }
    }
}
