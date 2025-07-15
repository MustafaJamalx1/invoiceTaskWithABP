using Volo.Abp.Modularity;

namespace invoiceTask;

/* Inherit from this class for your domain layer tests. */
public abstract class invoiceTaskDomainTestBase<TStartupModule> : invoiceTaskTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
