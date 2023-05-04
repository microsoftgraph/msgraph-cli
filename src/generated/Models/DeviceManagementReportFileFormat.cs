using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Possible values for the file format of a report</summary>
    public enum DeviceManagementReportFileFormat {
        /// <summary>CSV Format</summary>
        [EnumMember(Value = "csv")]
        Csv,
        /// <summary>PDF Format</summary>
        [EnumMember(Value = "pdf")]
        Pdf,
        /// <summary>JSON Format</summary>
        [EnumMember(Value = "json")]
        Json,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
