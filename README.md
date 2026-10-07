# MovieRatingApp

ASP.NET Core MVC movie-rating application using Entity Framework Core and SQL Server LocalDB.

The `MoviesController` and its five views were generated with the Visual Studio
**"MVC Controller with views, using Entity Framework"** scaffolder
(Model class = `Movie`, Data context class = `AppDbContext`,
Controller name = `MoviesController`, async actions, script libraries referenced).

## Requirements

- Visual Studio 2026 (or the .NET SDK)
- .NET 10 SDK
- SQL Server LocalDB

## Project structure

```
MovieRatingApp/
│
├── Controllers/
│   ├── HomeController.cs
│   └── MoviesController.cs
│
├── Data/
│   └── AppDbContext.cs
│
├── Migrations/
│   ├── 20261007120815_InitialCreate.cs
│   ├── 20261007120815_InitialCreate.Designer.cs
│   └── AppDbContextModelSnapshot.cs
│
├── Models/
│   ├── ErrorViewModel.cs
│   └── Movie.cs
│
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   │
│   ├── Movies/
│   │   ├── Create.cshtml
│   │   ├── Delete.cshtml
│   │   ├── Details.cshtml
│   │   ├── Edit.cshtml
│   │   └── Index.cshtml
│   │
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   ├── _ValidationScriptsPartial.cshtml
│   │   └── Error.cshtml
│   │
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
│
├── wwwroot/
│   ├── css/site.css
│   ├── js/site.js
│   └── lib/                 (Bootstrap, jQuery, jQuery Validation - LibMan)
│
├── Properties/
│   └── launchSettings.json
│
├── appsettings.json
├── appsettings.Development.json
├── libman.json
├── Program.cs
├── MovieRatingApp.csproj
├── MovieRatingApp.sln
├── .gitignore
├── MIGRATIONS.md
└── README.md
```

## Features

- MVC architecture with scaffolded CRUD (Index, Details, Create, Edit, Delete)
- Entity Framework Core with a committed `InitialCreate` migration
- SQL Server LocalDB database `MovieDB`
- Movie title, release year and rating (0-10)
- Client-side and server-side validation
- Navigation links: Home, Privacy, Movie List

## Setup

1. Open `MovieRatingApp.sln` in Visual Studio.
2. Restore NuGet packages.
3. Apply the committed migration:
   - **Tools > NuGet Package Manager > Package Manager Console**: `Update-Database`
   - or CLI: `dotnet ef database update`
4. Run the application (F5 / HTTPS profile).

Command line:

```bash
dotnet restore
dotnet build
dotnet ef database update
dotnet run
```

The application uses:

`(localdb)\\MSSQLLocalDB`

Database:

`MovieDB`

## Client-side libraries

Bootstrap, jQuery, jQuery Validation and jQuery Validation Unobtrusive are
managed with [LibMan](https://learn.microsoft.com/aspnet/core/client-side/libman)
via `libman.json` and are committed under `wwwroot/lib/`.
To restore them again:

```bash
libman restore
```

## Scaffolded controller

The `MoviesController` provides:

- Index
- Details
- Create
- Edit
- Delete

The controller uses `Movie` as its model and `AppDbContext` as its EF Core data
context, with async actions and `[ValidateAntiForgeryToken]` on every POST.
