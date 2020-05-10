using AzureFunctions.Extensions.Swashbuckle;
using AzureFunctions.Extensions.Swashbuckle.Attribute;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading.Tasks;

namespace AzureFunctions_SwashBuckle
{
    public class SwaggerJson
    {
        [FunctionName("SwaggerJson")]
        [SwaggerIgnore]
        public static Task<HttpResponseMessage> Run(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "json")]
        HttpRequestMessage req,
    ILogger log,
    [SwashBuckleClient] ISwashBuckleClient swashBuckleClient)
        {
            return Task.FromResult(swashBuckleClient.CreateSwaggerDocumentResponse(req));
        }
    }
}
