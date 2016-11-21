#load "models.csx"

using System.IO;
using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Verbose($"C# HTTP trigger function processed a request. RequestUri={req.RequestUri}");

    // Get request body
    dynamic data = await req.Content.ReadAsAsync<object>();

    // Set name to query string or body data

    return req.CreateResponse(HttpStatusCode.OK, "OK");
}