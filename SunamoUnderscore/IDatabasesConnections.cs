namespace SunamoUnderscore;

public interface IDatabasesConnections
{
    Databases DefaultConnection { get; }

    void ForceSetCs(Databases database);

    void LoadDefaultConnection(RadioButtonsSql radioButtonsSql);

    string NotifyAboutSunamoCzLocalInDebug(Databases database);

    Task
        Reload();

    void SetConnToMSDatabaseLayer(Databases database, RadioButtonsSql radioButtonsSql);

    void SetConnToMSDatabaseLayerSql5(Databases database);

    void TemporarilySwitchConnToMSDatabaseLayer(Databases database, RadioButtonsSql radioButtonsSql);

    void TemporarilySwitchConnToMSDatabaseLayer(RadioButtonsSql radioButtonsSql);
}
