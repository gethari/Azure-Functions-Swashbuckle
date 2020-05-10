using AzureFunctions.Extensions.Swashbuckle;
using AzureFunctions_SwashBuckle;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using System.Reflection;

[assembly: WebJobsStartup(typeof(Startup))]
namespace AzureFunctions_SwashBuckle
{
    public class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.AddSwashBuckle(Assembly.GetExecutingAssembly());
        }
    }
}
