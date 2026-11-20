namespace SunamoUnderscore;

/// <summary>
/// Represents the _ type.
/// </summary>
public class _
{
    /// <summary>
    /// The databases connections.
    /// </summary>
    public static IDatabasesConnections? DatabasesConnections = null;
    /// <summary>
    /// The comgate consts.
    /// </summary>
    public static IComgateOAuth? ComgateConsts = null;
    /// <summary>
    /// The open in code editor.
    /// </summary>
    public static Action<string>? OpenInCodeEditor = null;
    /// <summary>
    /// The all columns.
    /// </summary>
    public static Dictionary<string, List<string>> AllColumns = new();
    /// <summary>
    /// The rijndael bytes decrypt.
    /// </summary>
    public static Func<List<byte>, List<byte>>? RijndaelBytesDecrypt;
    /// <summary>
    /// The rijndael bytes encrypt.
    /// </summary>
    public static Func<List<byte>, List<byte>>? RijndaelBytesEncrypt;
}
