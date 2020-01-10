# ThucDon Project
## Introduction
This is a sample health webapp project that user can put in the amount of calories they want and the app will generate a random meal plan accordingly to that number of calories.
## Set-up
- The project used [DotVVM] (https://www.dotvvm.com/) framework for an MVVM webapp approach.
- To test the project, create an **appsettings.json** file in the main folder and put in the server connection setting. 
Sample **appsettings.json** file:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=DESKTOP-K7ACE0T;Database=ThucDon;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```
Just replace
>Server=DESKTOP-K7ACE0T;Database=ThucDon

with your Server connection (Can be retrieved from SQL Server Managment Studio) and desired database name.
- The project will seed and create the database using Entity Framework Core.
