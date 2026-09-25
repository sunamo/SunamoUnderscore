// variables names: ok
namespace SunamoUnderscore;

/// <summary>
/// GoPay-specific OAuth configuration.
/// </summary>
public interface IGoPayOAuth : IOAuth
{
    /// <summary>
    /// Gets the GoPay account identifier.
    /// </summary>
    long GoID { get; }
}
