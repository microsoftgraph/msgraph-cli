namespace ApiSdk.Models {
    /// <summary>Defender’s default action to take on detected Malware threats.</summary>
    public enum DefenderThreatAction {
        /// <summary>Apply action based on the update definition.</summary>
        DeviceDefault,
        /// <summary>Clean the detected threat.</summary>
        Clean,
        /// <summary>Quarantine the detected threat.</summary>
        Quarantine,
        /// <summary>Remove the detected threat.</summary>
        Remove,
        /// <summary>Allow the detected threat.</summary>
        Allow,
        /// <summary>Allow the user to determine the action to take with the detected threat.</summary>
        UserDefined,
        /// <summary>Block the detected threat.</summary>
        Block,
    }
}
