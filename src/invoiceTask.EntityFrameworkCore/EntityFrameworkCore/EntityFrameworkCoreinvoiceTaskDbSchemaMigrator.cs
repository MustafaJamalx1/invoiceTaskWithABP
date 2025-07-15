using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using invoiceTask.Data;
using Volo.Abp.DependencyInjection;

namespace invoiceTask.EntityFrameworkCore;

public class EntityFrameworkCoreinvoiceTaskDbSchemaMigrator
    : IinvoiceTaskDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreinvoiceTaskDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the invoiceTaskDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<invoiceTaskDbContext>()
            .Database
            .MigrateAsync();
    }
}
