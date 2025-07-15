using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using invoiceTask.Localization;

namespace invoiceTask.Web;

[Dependency(ReplaceServices = true)]
public class invoiceTaskBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<invoiceTaskResource> _localizer;

    public invoiceTaskBrandingProvider(IStringLocalizer<invoiceTaskResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
