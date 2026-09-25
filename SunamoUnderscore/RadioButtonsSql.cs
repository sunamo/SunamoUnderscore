namespace SunamoUnderscore;

/// <summary>
/// Represents the state of SQL database radio button selections.
/// Used by IDatabasesConnections to determine which database to connect to.
/// Must be a class (not enum) because IDatabasesConnections is static in _ and cannot have type arguments.
/// </summary>
public class RadioButtonsSql
{
    /// <summary>
    /// Indicates whether the command-line database mode is selected.
    /// </summary>
    public bool IsCmd { get; set; } = false;

    /// <summary>
    /// Indicates whether the SunamoCz database is selected.
    /// </summary>
    public bool IsSunamoCz { get; set; }

    /// <summary>
    /// Indicates whether the SunamoNet database is selected.
    /// </summary>
    public bool IsSunamoNet { get; set; }

    /// <summary>
    /// Indicates whether the WeBelieve database is selected.
    /// </summary>
    public bool IsWeBelieve { get; set; }
}
