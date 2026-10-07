# Migrations

The `Migrations/` folder contains the committed `InitialCreate` migration
(`Add-Migration InitialCreate`) and the model snapshot, so the database schema
is part of the repository.

## Apply the migrations

Visual Studio — **Tools > NuGet Package Manager > Package Manager Console**:

```powershell
Update-Database
```

Command line:

```bash
dotnet ef database update
```

## Create a new migration (after changing the models)

Visual Studio (Package Manager Console):

```powershell
Add-Migration <MigrationName>
Update-Database
```

Command line:

```bash
dotnet ef migrations add <MigrationName>
dotnet ef database update
```

The connection string in `appsettings.json` points at
`(localdb)\\MSSQLLocalDB` with database name `MovieDB`.
