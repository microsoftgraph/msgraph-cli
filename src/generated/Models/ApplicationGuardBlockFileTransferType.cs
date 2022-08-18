namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the collection of agreementAcceptance entities.</summary>
    public enum ApplicationGuardBlockFileTransferType {
        /// <summary>Not Configured</summary>
        NotConfigured,
        /// <summary>Block clipboard to transfer Image and Text file</summary>
        BlockImageAndTextFile,
        /// <summary>Block clipboard to transfer Image file</summary>
        BlockImageFile,
        /// <summary>Neither of text file or image file is blocked from transferring</summary>
        BlockNone,
        /// <summary>Block clipboard to transfer Text file</summary>
        BlockTextFile,
    }
}
