using Xunit;

namespace invoiceTask.EntityFrameworkCore;

[CollectionDefinition(invoiceTaskTestConsts.CollectionDefinitionName)]
public class invoiceTaskEntityFrameworkCoreCollection : ICollectionFixture<invoiceTaskEntityFrameworkCoreFixture>
{

}
