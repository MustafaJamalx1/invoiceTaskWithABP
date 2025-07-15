using Volo.Abp.Modularity;

namespace invoiceTask;

[DependsOn(
    typeof(invoiceTaskDomainModule),
    typeof(invoiceTaskTestBaseModule)
)]
public class invoiceTaskDomainTestModule : AbpModule
{

}
