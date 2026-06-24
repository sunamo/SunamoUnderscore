// variables names: ok
namespace SunamoUnderscore;

// Comgate-specific OAuth configuration.
// Must be in SunamoUnderscore so both SunamoComgate and GoPay can reference it through a shared path.
public interface IComgateOAuth : IOAuth
{
    string Email { get; }
}
