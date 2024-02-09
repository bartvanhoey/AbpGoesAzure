using AbpGoesAzure.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpGoesAzure.Permissions;

public class AbpGoesAzurePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpGoesAzurePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpGoesAzurePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpGoesAzureResource>(name);
    }
}
