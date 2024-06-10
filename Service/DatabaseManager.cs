using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.Storage;
using System.IO;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Service
{
    public class DatabaseManager
    {
        //dotnet tool install --global dotnet-ef --version 6.0.423
        //dotnet ef migrations add InitialCreate
        //dotnet ef database update
    }
}