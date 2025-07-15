using invoiceTask.Localization;
using Volo.Abp.Application.Services;

namespace invoiceTask;

/* Inherit your application services from this class.
 */
public abstract class invoiceTaskAppService : ApplicationService
{
    protected invoiceTaskAppService()
    {
        LocalizationResource = typeof(invoiceTaskResource);
    }
}
