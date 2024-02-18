git init
git remote add origin https://github.com/raphaelmdcoelho/MinimalAPIPlayground.git
git branch -M main

dotnet add package Swashbuckle.AspNetCore

dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet ef migrations add InitialCreate
dotnet ef database update

REPEAT MORE STRUCTURES WITH CHECK