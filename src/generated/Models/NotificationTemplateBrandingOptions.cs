namespace ApiSdk.Models {
    /// <summary>Branding Options for the Message Template. Branding is defined in the Intune Admin Console.</summary>
    public enum NotificationTemplateBrandingOptions {
        /// <summary>Indicates that no branding options are set in the message template.</summary>
        None,
        /// <summary>Indicates to include company logo in the message template.</summary>
        IncludeCompanyLogo,
        /// <summary>Indicates to include company name in the message template.</summary>
        IncludeCompanyName,
        /// <summary>Indicates to include contact information in the message template.</summary>
        IncludeContactInformation,
        /// <summary>Indicates to include company portal website link in the message template.</summary>
        IncludeCompanyPortalLink,
        /// <summary>Indicates to include device details in the message template.</summary>
        IncludeDeviceDetails,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        UnknownFutureValue,
    }
}
