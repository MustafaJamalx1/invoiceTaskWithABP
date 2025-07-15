using invoiceTask.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace invoiceTask.Permissions;

public class invoiceTaskPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(invoiceTaskPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(invoiceTaskPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<invoiceTaskResource>(name);
    }
}
