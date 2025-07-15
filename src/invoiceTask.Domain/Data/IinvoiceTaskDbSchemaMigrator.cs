using System.Threading.Tasks;

namespace invoiceTask.Data;

public interface IinvoiceTaskDbSchemaMigrator
{
    Task MigrateAsync();
}
