using Volo.Abp.Modularity;

namespace invoiceTask;

public abstract class invoiceTaskApplicationTestBase<TStartupModule> : invoiceTaskTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
