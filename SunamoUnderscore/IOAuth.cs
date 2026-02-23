// variables names: ok
namespace SunamoUnderscore;

/// <summary>
///     Common for Cm + Gp
/// </summary>
public interface IOAuth
{
    string ApiUri { get; }
    string ClientSecret { get; }

    /// <summary>
    ///     In gp clientID
    /// </summary>
    string MerchantId { get; }
}