using invoiceTask.Samples;
using Xunit;

namespace invoiceTask.EntityFrameworkCore.Domains;

[Collection(invoiceTaskTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<invoiceTaskEntityFrameworkCoreTestModule>
{

}
