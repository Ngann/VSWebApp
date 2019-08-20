Setting up SQLite DB:

https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-2.2&tabs=visual-studio-mac

cd into project:

install packages
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

Register the database context in Startup.cs:

using MvcMovie.Models;
using Microsoft.EntityFrameworkCore;

services.AddDbContext<MvcMovieContext>(options =>
   options.UseSqlite(Configuration.GetConnectionString("MovieContext")));


Install the scaffolding tool:
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet aspnet-codegenerator controller -name MoviesController -m Movie -dc MvcMovieContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

Run Inital Migration:
dotnet ef migrations add InitialCreate
dotnet ef database update