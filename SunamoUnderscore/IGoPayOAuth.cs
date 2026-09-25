// variables names: ok
namespace SunamoUnderscore;

// GoPay-specific OAuth configuration.
public interface IGoPayOAuth : IOAuth
{
    long GoID { get; }
}
