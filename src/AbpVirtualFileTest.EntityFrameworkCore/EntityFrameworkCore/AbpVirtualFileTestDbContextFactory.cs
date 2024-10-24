﻿using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpVirtualFileTest.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AbpVirtualFileTestDbContextFactory : IDesignTimeDbContextFactory<AbpVirtualFileTestDbContext>
{
    public AbpVirtualFileTestDbContext CreateDbContext(string[] args)
    {
        // https://www.npgsql.org/efcore/release-notes/6.0.html#opting-out-of-the-new-timestamp-mapping-logic
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        
        var configuration = BuildConfiguration();
        
        AbpVirtualFileTestEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<AbpVirtualFileTestDbContext>()
            .UseNpgsql(configuration.GetConnectionString("Default"));
        
        return new AbpVirtualFileTestDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpVirtualFileTest.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
