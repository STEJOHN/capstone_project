# AssetTrack

AssetTrack is an inventory management system that allows users to register/login for access and store, view or manipulate data from SQL Server. 

## Installation
This application was built with the following:

[Visual Studio 2022](https://visualstudio.microsoft.com/vs/)

[.NET 6](https://dotnet.microsoft.com/enus/download/dotnet/6.0/)

[Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)


After installing the previous mentioned software, you will need to download the project dependencies listed below. 

From the Visual Studio Tools menu, select NuGet Package Manager > Package Manager Console (PMC).


```
Install-Package  Microsoft.VisualStudio.Web.CodeGeneration.Design
Install-Package  Microsoft.EntityFrameworkCore.Design 
Install-Package  Microsoft.AspNetCore.Identity.EntityFrameworkCore 
Install-Package  Microsoft.AspNetCore.Identity.UI 
Install-Package  Microsoft.EntityFrameworkCore.SqlServer 
Install-Package  Microsoft.EntityFrameworkCore.Tools 
Install-Package  Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore 
```

Since the application connects to SQL Server, you will need to use the EF Core Migrations feature to create the database.
This can be done via Package Manager Console (PMC). More information regarding EF Core can be found [here](https://docs.microsoft.com/en-us/ef/core/cli/powershell)

```
Add-Migration InitialCreate
Update-Database
```

If you are experiencing issues with connecting to SQL Server, please verify the information in the connection string located in the ```appsettings.json``` file:

```c
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "MvcMovieContext": "Server=(localdb)\\mssqllocaldb;Database=MvcMovieContext-7dc5b790-765f-4381-988c-5167405bb107;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```



## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.


## License
This project is licensed under the [MIT](https://choosealicense.com/licenses/mit/) license. Feel free to edit and distribute this template as you like.
