### SunamoUnderscore

Global static sharing data objects for cross-module communication in .NET applications.

Part of PlatformIndependentNuGetPackages:

- [nuget.org](https://www.nuget.org/profiles/sunamo)
- [github.org](https://github.com/sunamo/PlatformIndependentNuGetPackages)

Another links:

- [Developer site](https://sunamo.cz)

Request for new features / bug report / etc: [Mail](mailto:radek.jancik@sunamo.cz) or on GitHub

## Key Components

- **`_`** - Global static class holding shared references (database connections, OAuth configs, encryption functions)
- **`IDatabasesConnections`** - Interface for managing and switching database connections
- **`IOAuth` / `IComgateOAuth` / `IGoPayOAuth`** - OAuth configuration interfaces for payment gateways
- **`RadioButtonsSql`** - SQL database radio button selection state
- **`Databases`** - Enum of available database connection targets

## Target Frameworks

**TargetFrameworks:** `net10.0;net9.0;net8.0`
