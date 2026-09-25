namespace SunamoUnderscore;

/// <summary>
/// Global static sharing data objects for cross-module communication.
/// </summary>
public class _
{
    /// <summary>
    /// Database connections provider instance.
    /// </summary>
    public static IDatabasesConnections? DatabasesConnections = null;

    /// <summary>
    /// Comgate OAuth configuration constants.
    /// </summary>
    public static IComgateOAuth? ComgateConsts = null;

    /// <summary>
    /// Action delegate to open a file in code editor.
    /// </summary>
    public static Action<string>? OpenInCodeEditor = null;

    /// <summary>
    /// Dictionary mapping table names to their column lists.
    /// </summary>
    public static Dictionary<string, List<string>> AllColumns = new();

    /// <summary>
    /// Rijndael decryption function accepting and returning byte lists.
    /// </summary>
    public static Func<List<byte>, List<byte>>? RijndaelBytesDecrypt;

    /// <summary>
    /// Rijndael encryption function accepting and returning byte lists.
    /// </summary>
    public static Func<List<byte>, List<byte>>? RijndaelBytesEncrypt;
}
