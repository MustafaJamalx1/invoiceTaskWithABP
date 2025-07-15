using Volo.Abp.Settings;

namespace invoiceTask.Settings;

public class invoiceTaskSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(invoiceTaskSettings.MySetting1));
    }
}
