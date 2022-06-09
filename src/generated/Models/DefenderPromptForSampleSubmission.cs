namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum DefenderPromptForSampleSubmission {
        /// <summary>User Defined, default value, no intent.</summary>
        UserDefined,
        /// <summary>Always prompt.</summary>
        AlwaysPrompt,
        /// <summary>Send safe samples automatically.</summary>
        PromptBeforeSendingPersonalData,
        /// <summary>Never send data.</summary>
        NeverSendData,
        /// <summary>Send all data without prompting.</summary>
        SendAllDataWithoutPrompting,
    }
}
