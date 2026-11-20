namespace SunamoUnderscore;

/// <summary>
/// Represents the IO auth type.
/// </summary>
public interface IOAuth
{
    /// <summary>
    /// Gets the api uri.
    /// </summary>
    string ApiUri { get; }

    /// <summary>
    /// Gets the client secret.
    /// </summary>
    string ClientSecret { get; }

    /// <summary>
    /// Gets the merchant id.
    /// </summary>
    string MerchantId { get; }
}
