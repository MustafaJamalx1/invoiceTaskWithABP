using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace invoiceTask.Data;

/* This is used if database provider does't define
 * IinvoiceTaskDbSchemaMigrator implementation.
 */
public class NullinvoiceTaskDbSchemaMigrator : IinvoiceTaskDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
