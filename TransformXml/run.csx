#load "models.csx"

using System.IO;
using System.Net;
using System.Net.Http;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Verbose($"C# HTTP trigger function processed a request. RequestUri={req.RequestUri}");

    var streamProvider = new MultipartFormDataStreamProvider(tempPath);
    var readResult = await req.Content.ReadAsMultipartAsync(streamProvider);

    if (readResult.FormData["xml"] == null)
    {
        return req.CreateResponse(HttpStatusCode.BadRequest);
    }

    
    if (readResult.FormData["xslt"] == null)
    {
        return req.CreateResponse(HttpStatusCode.BadRequest);
    }

    // Get request body
    dynamic data = await req.Content.ReadAsAsync<object>();

    // Set name to query string or body data
    return req.CreateResponse(HttpStatusCode.OK, "OK");
}