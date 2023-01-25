namespace ApiSdk.Models {
    /// <summary>Possible values for welcome screen meeting information.</summary>
    public enum WelcomeScreenMeetingInformation {
        /// <summary>User Defined, default value, no intent.</summary>
        UserDefined,
        /// <summary>Show organizer and time only.</summary>
        ShowOrganizerAndTimeOnly,
        /// <summary>Show organizer, time and subject (subject is hidden for private meetings).</summary>
        ShowOrganizerAndTimeAndSubject,
    }
}
