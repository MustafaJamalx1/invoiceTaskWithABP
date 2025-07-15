using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace invoiceTask.Pages;

[Collection(invoiceTaskTestConsts.CollectionDefinitionName)]
public class Index_Tests : invoiceTaskWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
