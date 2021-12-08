using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.TargetedManagedAppProtection.TargetApps {
    public class TargetAppsRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public TargetedManagedAppGroupType? AppGroupType { get; set; }
        public List<ManagedMobileApp> Apps { get; set; }
        /// <summary>
        /// Instantiates a new targetAppsRequestBody and sets the default values.
        /// </summary>
        public TargetAppsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"appGroupType", (o,n) => { (o as TargetAppsRequestBody).AppGroupType = n.GetEnumValue<TargetedManagedAppGroupType>(); } },
                {"apps", (o,n) => { (o as TargetAppsRequestBody).Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<TargetedManagedAppGroupType>("appGroupType", AppGroupType);
            writer.WriteCollectionOfObjectValues<ManagedMobileApp>("apps", Apps);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
