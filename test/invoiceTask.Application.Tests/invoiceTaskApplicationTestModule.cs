using Volo.Abp.Modularity;

namespace invoiceTask;

[DependsOn(
    typeof(invoiceTaskApplicationModule),
    typeof(invoiceTaskDomainTestModule)
)]
public class invoiceTaskApplicationTestModule : AbpModule
{

}
