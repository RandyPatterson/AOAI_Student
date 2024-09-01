using AOAI_Workshop;
using Azure;
using Azure.Search.Documents.Indexes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Microsoft.Identity.Client;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.SemanticKernel.Plugins.OpenApi;
using System.Net.Http.Headers;


#pragma warning disable SKEXP0001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
#pragma warning disable SKEXP0050 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
#pragma warning disable SKEXP0010 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
#pragma warning disable SKEXP0040 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
#pragma warning disable SKEXP0020 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

var webHostBuilder = WebApplication.CreateBuilder(args);
IConfiguration config = webHostBuilder.Configuration;

AuthenticationResult authResult = null;
// Uncomment this code block to add authentication to the Logic App for CHALLENGE 4
/*
string ClientId = config["LOGIC_APP_CLIENT_ID"]!;
    string TenantId = config["TENANT_ID"]!;
    string Scope = config["LOGIC_APP_SCOPE"]!;
    string Authority = $"https://login.microsoftonline.com/{TenantId}";
    string[] Scopes = { Scope };

    var publicClient = PublicClientApplicationBuilder.Create(ClientId)
                .WithAuthority(Authority)
                .WithDefaultRedirectUri() // Uses http://localhost for a console app
                .Build();

    try
    {
        authResult = await publicClient.AcquireTokenInteractive(Scopes).ExecuteAsync();
    }
    catch (MsalException ex)
    {
        Console.WriteLine("An error occurred acquiring the token: " + ex.Message);
    }
*/

//Configure Semantic Kernel
var kernelBuilder = Kernel.CreateBuilder();

//Add Azure OpenAI Chat Completion
kernelBuilder.AddAzureOpenAIChatCompletion(
    config["AOI_DEPLOYMODEL"] ?? "gpt-35-turbo",
    config["AOI_ENDPOINT"]!,
    config["AOI_API_KEY"]!);
kernelBuilder.Services.AddHttpClient();
kernelBuilder.Services.AddLogging(builder => {
    builder.AddConfiguration(config.GetSection("Logging"));
    builder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Debug);
    builder.AddConsole();
});

// Build the kernel
var kernel = kernelBuilder.Build();
//add kernel to DI
webHostBuilder.Services.AddSingleton<Kernel>(kernel);


//Challenge 3: Add Plugins to Semantic Kernel
await AddPlugins(config, kernel, authResult);

var app = webHostBuilder.Build();


app.UseStaticFiles(new StaticFileOptions {
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "html")),
    RequestPath = "/content"
});

app.MapGet("/", () => {
    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "html", "index.html");
    var fileContent = File.ReadAllText(filePath);
    return Results.Text(fileContent, "text/html");
});

app.MapPost("/chat", async (
    HttpContext context,
    [FromBody] ChatRequest chatRequest,
    [FromServices] Kernel kernel) => {


        //Convert chat history from client to Semantic Kernel ChatHistory collection
        var chatHistory = ExtractHistory(chatRequest);

        //Challenge 2: add current prompt to chatHistory


        //Challenge 2: Get the chat completion service from Semantic Kernel

        //Challenge 3: Configure the execution settings for the OpenAI chat completion

        //Challenge 2: Get the response from the AI


        //Challenge 2: return a JSON response that has a single property 'response' with a value containing the response from the LLM
        //ie: new { response = response[0].Content }
    });

app.Run();

//convert Chat History received from client to Semantic Kernel ChatHistory collection
static ChatHistory ExtractHistory(ChatRequest chatRequest)
{
    var chatHistory = new ChatHistory();
    foreach (var history in chatRequest.History) {
        if (history.Role == "user")
            chatHistory.AddUserMessage(history.Content);
        else
            chatHistory.AddAssistantMessage(history.Content);
    }

    return chatHistory;
}


static async Task<bool> AddPlugins(IConfiguration config, Kernel kernel, AuthenticationResult? authResult)
{


    return true;
}
