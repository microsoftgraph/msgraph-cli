namespace ApiSdk.Models {
    /// <summary>Possible values for WIP Protection enforcement levels</summary>
    public enum WindowsInformationProtectionEnforcementLevel {
        /// <summary>No protection enforcement</summary>
        NoProtection,
        /// <summary>Encrypt and Audit only</summary>
        EncryptAndAuditOnly,
        /// <summary>Encrypt, Audit and Prompt</summary>
        EncryptAuditAndPrompt,
        /// <summary>Encrypt, Audit and Block</summary>
        EncryptAuditAndBlock,
    }
}
