namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the security singleton.</summary>
    public enum FileHashType {
        Unknown,
        Sha1,
        Sha256,
        Md5,
        AuthenticodeHash256,
        LsHash,
        Ctph,
        UnknownFutureValue,
    }
}
