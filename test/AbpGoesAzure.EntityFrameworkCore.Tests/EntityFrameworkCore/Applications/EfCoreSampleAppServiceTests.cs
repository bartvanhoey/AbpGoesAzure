using AbpGoesAzure.Samples;
using Xunit;

namespace AbpGoesAzure.EntityFrameworkCore.Applications;

[Collection(AbpGoesAzureTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AbpGoesAzureEntityFrameworkCoreTestModule>
{

}
