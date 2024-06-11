using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Service.Model;
using System.IO;

public class BloggingContextFactory : IDesignTimeDbContextFactory<BloggingContext>
{
    public BloggingContext CreateDbContext(string[] args)
    {
        var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .AddJsonFile("..\\MiniBlog\\appsettings.json", optional: false)
            .AddJsonFile($"..\\MiniBlog\\appsettings.{env}.json", optional: true)
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<BloggingContext>();
        var connectionString = configuration.GetConnectionString("DbConnection");
        optionsBuilder.UseSqlite(connectionString);

        return new BloggingContext(optionsBuilder.Options);
    }
}