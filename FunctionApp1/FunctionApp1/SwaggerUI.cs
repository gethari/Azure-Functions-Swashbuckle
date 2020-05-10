using AzureFunctions.Extensions.Swashbuckle;
using AzureFunctions.Extensions.Swashbuckle.Attribute;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading.Tasks;

namespace AzureFunctions_SwashBuckle
{
    public class SwaggerUI
    {
        [FunctionName("SwaggerUI")]
        [SwaggerIgnore]
        public static Task<HttpResponseMessage> RunUI(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "swaggerUI")]
        HttpRequestMessage req,
    ILogger log,
    [SwashBuckleClient] ISwashBuckleClient swashBuckleClient)
        {
            return Task.FromResult(swashBuckleClient.CreateSwaggerUIResponse(req, "json"));
        }
    }
}
