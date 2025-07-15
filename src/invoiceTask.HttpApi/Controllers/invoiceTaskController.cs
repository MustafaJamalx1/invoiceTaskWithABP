using invoiceTask.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace invoiceTask.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class invoiceTaskController : AbpControllerBase
{
    protected invoiceTaskController()
    {
        LocalizationResource = typeof(invoiceTaskResource);
    }
}
