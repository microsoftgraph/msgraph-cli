using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum ExportOptions {
        [EnumMember(Value = "originalFiles")]
        OriginalFiles,
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "pdfReplacement")]
        PdfReplacement,
        [EnumMember(Value = "tags")]
        Tags,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
