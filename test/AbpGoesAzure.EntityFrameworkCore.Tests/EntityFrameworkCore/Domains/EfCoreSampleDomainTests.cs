using AbpGoesAzure.Samples;
using Xunit;

namespace AbpGoesAzure.EntityFrameworkCore.Domains;

[Collection(AbpGoesAzureTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AbpGoesAzureEntityFrameworkCoreTestModule>
{

}
