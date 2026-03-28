namespace SunamoUnderscore;

/// <summary>
/// Interface for managing database connections and switching between them.
/// </summary>
public interface IDatabasesConnections
{
    /// <summary>
    /// Gets the currently active default database connection.
    /// </summary>
    Databases DefaultConnection { get; }

    /// <summary>
    /// Forces setting the connection string to the specified database.
    /// </summary>
    /// <param name="database">The database to set as connection target.</param>
    void ForceSetCs(Databases database);

    /// <summary>
    /// Loads the default connection from radio button selection state.
    /// </summary>
    /// <param name="radioButtonsSql">The radio buttons state representing selected database.</param>
    void LoadDefaultConnection(RadioButtonsSql radioButtonsSql);

    /// <summary>
    /// Returns a notification message when local SunamoCz database is used in debug mode.
    /// </summary>
    /// <param name="database">The database to check.</param>
    /// <returns>Notification message string.</returns>
    string NotifyAboutSunamoCzLocalInDebug(Databases database);

#if ASYNC
    /// <summary>
    /// Reloads the database connections asynchronously.
    /// </summary>
    /// <returns>A task representing the asynchronous reload operation.</returns>
    Task
#else
    /// <summary>
    /// Reloads the database connections.
    /// </summary>
    void
#endif
        Reload();

    /// <summary>
    /// Sets the connection to the MS database layer for the specified database.
    /// </summary>
    /// <param name="database">The target database.</param>
    /// <param name="radioButtonsSql">The radio buttons state representing selected database.</param>
    void SetConnToMSDatabaseLayer(Databases database, RadioButtonsSql radioButtonsSql);

    /// <summary>
    /// Sets the connection to the MS database layer for SQL5 variant.
    /// </summary>
    /// <param name="database">The target database.</param>
    void SetConnToMSDatabaseLayerSql5(Databases database);

    /// <summary>
    /// Temporarily switches the connection to the MS database layer for the specified database.
    /// </summary>
    /// <param name="database">The target database.</param>
    /// <param name="radioButtonsSql">The radio buttons state representing selected database.</param>
    void TemporarilySwitchConnToMSDatabaseLayer(Databases database, RadioButtonsSql radioButtonsSql);

    /// <summary>
    /// Temporarily switches the connection to the MS database layer using the current selection.
    /// </summary>
    /// <param name="radioButtonsSql">The radio buttons state representing selected database.</param>
    void TemporarilySwitchConnToMSDatabaseLayer(RadioButtonsSql radioButtonsSql);
}
