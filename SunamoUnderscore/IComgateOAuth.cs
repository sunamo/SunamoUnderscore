namespace SunamoUnderscore;

// Comgate-specific OAuth configuration.
// Must be in SunamoUnderscore so both SunamoComgate and GoPay can reference it through a shared path.
/// <summary>
/// Represents the i comgate o auth type.
/// </summary>
public interface IComgateOAuth : IOAuth
{
    /// <summary>
    /// Gets the email.
    /// </summary>
    string Email { get; }
}
