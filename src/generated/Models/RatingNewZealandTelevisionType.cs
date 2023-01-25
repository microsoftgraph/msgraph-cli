namespace ApiSdk.Models {
    /// <summary>TV content rating labels in New Zealand</summary>
    public enum RatingNewZealandTelevisionType {
        /// <summary>Default value, allow all TV shows content</summary>
        AllAllowed,
        /// <summary>Do not allow any TV shows content</summary>
        AllBlocked,
        /// <summary>The G classification excludes materials likely to harm children under 14</summary>
        General,
        /// <summary>The PGR classification encourages parents and guardians to supervise younger viewers</summary>
        ParentalGuidance,
        /// <summary>The AO classification is not suitable for children</summary>
        Adults,
    }
}
