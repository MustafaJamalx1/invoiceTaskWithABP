using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace invoiceTask.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class invoiceTaskDbContextFactory : IDesignTimeDbContextFactory<invoiceTaskDbContext>
{
    public invoiceTaskDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        invoiceTaskEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<invoiceTaskDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new invoiceTaskDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../invoiceTask.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
