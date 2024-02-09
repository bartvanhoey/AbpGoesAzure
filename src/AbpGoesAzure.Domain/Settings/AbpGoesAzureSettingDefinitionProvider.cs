using Volo.Abp.Settings;

namespace AbpGoesAzure.Settings;

public class AbpGoesAzureSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpGoesAzureSettings.MySetting1));
    }
}
