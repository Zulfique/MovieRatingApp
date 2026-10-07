# MovieRatingApp

ASP.NET Core MVC movie-rating application using Entity Framework Core and SQL Server LocalDB.

## Requirements

- Visual Studio 2026
- .NET 10 SDK
- SQL Server LocalDB

## Features

- MVC architecture
- Entity Framework Core
- SQL Server LocalDB
- Movie CRUD operations
- Movie title, release year and rating
- Navigation link to Movie List

## Setup

1. Open `MovieRatingApp.sln` or the project in Visual Studio.
2. Restore NuGet packages.
3. Open **Tools > NuGet Package Manager > Package Manager Console**.
4. Run:

```powershell
Add-Migration InitialCreate
Update-Database
```

5. Run the application with HTTPS.

The application uses:

`(localdb)\\MSSQLLocalDB`

Database:

`MovieDB`

## Scaffolded controller

The `MoviesController` provides:

- Index
- Details
- Create
- Edit
- Delete

The controller uses `Movie` as its model and `AppDbContext` as its EF Core data context.
