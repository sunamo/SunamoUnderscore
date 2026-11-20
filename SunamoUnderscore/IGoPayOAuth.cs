namespace SunamoUnderscore;

// GoPay-specific OAuth configuration.
/// <summary>
/// Represents the i go pay o auth type.
/// </summary>
public interface IGoPayOAuth : IOAuth
{
    /// <summary>
    /// Gets the go ID.
    /// </summary>
    long GoID { get; }
}
