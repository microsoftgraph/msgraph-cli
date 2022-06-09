namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum DefenderMonitorFileActivity {
        /// <summary>User Defined, default value, no intent.</summary>
        UserDefined,
        /// <summary>Disable monitoring file activity.</summary>
        Disable,
        /// <summary>Monitor all files.</summary>
        MonitorAllFiles,
        /// <summary> Monitor incoming files only.</summary>
        MonitorIncomingFilesOnly,
        /// <summary>Monitor outgoing files only.</summary>
        MonitorOutgoingFilesOnly,
    }
}
