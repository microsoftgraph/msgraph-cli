using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SignInStatus : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Provides additional details on the sign-in activity</summary>
        public string AdditionalDetails { get; set; }
        /// <summary>Provides the 5-6 digit error code that's generated during a sign-in failure. Check out the list of error codes and messages.</summary>
        public int? ErrorCode { get; set; }
        /// <summary>Provides the error message or the reason for failure for the corresponding sign-in activity. Check out the list of error codes and messages.</summary>
        public string FailureReason { get; set; }
        /// <summary>
        /// Instantiates a new signInStatus and sets the default values.
        /// </summary>
        public SignInStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"additionalDetails", (o,n) => { (o as SignInStatus).AdditionalDetails = n.GetStringValue(); } },
                {"errorCode", (o,n) => { (o as SignInStatus).ErrorCode = n.GetIntValue(); } },
                {"failureReason", (o,n) => { (o as SignInStatus).FailureReason = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("additionalDetails", AdditionalDetails);
            writer.WriteIntValue("errorCode", ErrorCode);
            writer.WriteStringValue("failureReason", FailureReason);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
