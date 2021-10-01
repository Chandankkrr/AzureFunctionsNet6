new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .Build()
    .Run();

public static class AzureFunctionsPreview
{
    [Function("AzureFunctionsPreview")]
    public static HttpResponseData Run(
        [HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequestData request
    )
    {
        var response = request.CreateResponse(HttpStatusCode.OK);
        response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

        var content = @"                                 
                          %%%%%%
                         %%%%%%
                    @   %%%%%%    @
                  @@   %%%%%%      @@
               @@@    %%%%%%%%%%%    @@@
             @@      %%%%%%%%%%        @@
               @@         %%%%       @@
                 @@      %%%       @@
                   @@    %%      @@
                        %%
                        %

        Hello from Azure Function V4 early preview";

        response.WriteString(content);
        return response;
    }
}

