using Xunit;

namespace AbpGoesAzure.EntityFrameworkCore;

[CollectionDefinition(AbpGoesAzureTestConsts.CollectionDefinitionName)]
public class AbpGoesAzureEntityFrameworkCoreCollection : ICollectionFixture<AbpGoesAzureEntityFrameworkCoreFixture>
{

}
