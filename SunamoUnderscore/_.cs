namespace SunamoUnderscore;

public class _
{
    public static IDatabasesConnections? DatabasesConnections = null;
    public static IComgateOAuth? ComgateConsts = null;
    public static Action<string>? OpenInCodeEditor = null;
    public static Dictionary<string, List<string>> AllColumns = new();
    public static Func<List<byte>, List<byte>>? RijndaelBytesDecrypt;
    public static Func<List<byte>, List<byte>>? RijndaelBytesEncrypt;
}
