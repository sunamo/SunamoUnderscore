// variables names: ok
namespace SunamoUnderscore;

/// <summary>
/// Comgate-specific OAuth configuration.
/// Must be in SunamoUnderscore so both SunamoComgate and GoPay can reference it through a shared path.
/// </summary>
public interface IComgateOAuth : IOAuth
{
    /// <summary>
    /// Gets the Comgate merchant email address.
    /// </summary>
    string Email { get; }
}
