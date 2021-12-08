namespace ApiSdk.Models.Microsoft.Graph {
    public enum DeviceEnrollmentType {
        Unknown,
        UserEnrollment,
        DeviceEnrollmentManager,
        AppleBulkWithUser,
        AppleBulkWithoutUser,
        WindowsAzureADJoin,
        WindowsBulkUserless,
        WindowsAutoEnrollment,
        WindowsBulkAzureDomainJoin,
        WindowsCoManagement,
        WindowsAzureADJoinUsingDeviceAuth,
        AppleUserEnrollment,
        AppleUserEnrollmentWithServiceAccount,
    }
}
