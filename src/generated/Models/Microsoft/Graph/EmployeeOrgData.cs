using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EmployeeOrgData : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The cost center associated with the user. Returned only on $select. Supports $filter.</summary>
        public string CostCenter { get; set; }
        /// <summary>The name of the division in which the user works. Returned only on $select. Supports $filter.</summary>
        public string Division { get; set; }
        /// <summary>
        /// Instantiates a new employeeOrgData and sets the default values.
        /// </summary>
        public EmployeeOrgData() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"costCenter", (o,n) => { (o as EmployeeOrgData).CostCenter = n.GetStringValue(); } },
                {"division", (o,n) => { (o as EmployeeOrgData).Division = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("costCenter", CostCenter);
            writer.WriteStringValue("division", Division);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
