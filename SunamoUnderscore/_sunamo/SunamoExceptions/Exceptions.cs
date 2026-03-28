namespace SunamoUnderscore._sunamo.SunamoExceptions;

/// <summary>
/// Provides shared exception-related utilities and additional info string builders.
/// </summary>
internal sealed partial class Exceptions
{
    /// <summary>
    /// String builder for accumulating inner additional info messages.
    /// </summary>
    static readonly StringBuilder AdditionalInfoInnerStringBuilder = new();

    /// <summary>
    /// String builder for accumulating additional info messages.
    /// </summary>
    static readonly StringBuilder AdditionalInfoStringBuilder = new();
}
