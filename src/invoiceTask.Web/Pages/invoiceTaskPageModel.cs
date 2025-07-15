using invoiceTask.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace invoiceTask.Web.Pages;

public abstract class invoiceTaskPageModel : AbpPageModel
{
    protected invoiceTaskPageModel()
    {
        LocalizationResourceType = typeof(invoiceTaskResource);
    }
}
