using Microsoft.AspNetCore.Builder;
using invoiceTask;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("invoiceTask.Web.csproj"); 
await builder.RunAbpModuleAsync<invoiceTaskWebTestModule>(applicationName: "invoiceTask.Web");

public partial class Program
{
}
