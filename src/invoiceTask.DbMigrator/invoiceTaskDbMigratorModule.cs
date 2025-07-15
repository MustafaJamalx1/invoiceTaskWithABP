using invoiceTask.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace invoiceTask.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(invoiceTaskEntityFrameworkCoreModule),
    typeof(invoiceTaskApplicationContractsModule)
)]
public class invoiceTaskDbMigratorModule : AbpModule
{
}
