using invoiceTask.Samples;
using Xunit;

namespace invoiceTask.EntityFrameworkCore.Applications;

[Collection(invoiceTaskTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<invoiceTaskEntityFrameworkCoreTestModule>
{

}
