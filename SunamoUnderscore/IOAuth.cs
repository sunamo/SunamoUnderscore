// variables names: ok
namespace SunamoUnderscore;

/// <summary>
/// Common OAuth configuration interface shared by Comgate and GoPay payment gateways.
/// </summary>
public interface IOAuth
{
    /// <summary>
    /// Gets the API base URI for the payment gateway.
    /// </summary>
    string ApiUri { get; }

    /// <summary>
    /// Gets the client secret for authentication.
    /// </summary>
    string ClientSecret { get; }

    /// <summary>
    /// Gets the merchant identifier (equivalent to clientID in GoPay).
    /// </summary>
    string MerchantId { get; }
}
