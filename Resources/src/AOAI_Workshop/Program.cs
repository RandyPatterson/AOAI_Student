using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.SemanticKernel.Plugins.Web;
using Microsoft.SemanticKernel.Plugins.Web.Bing;
using YamlDotNet.Serialization;

#pragma warning disable SKEXP0001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
#pragma warning disable SKEXP0050 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

var webHostBuilder = WebApplication.CreateBuilder(args);
IConfiguration config = webHostBuilder.Configuration;

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
    builder.SetMinimumLevel(LogLevel.Debug);
    builder.AddConsole();
});

// Build the kernel
var kernel = kernelBuilder.Build();
//add kernel to DI
webHostBuilder.Services.AddSingleton<Kernel>(kernel);


//Challenge 3: Add Plugins to Semantic Kernel
AddPlugins(config, kernel);

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

    if (chatRequest == null || kernel == null) {
        context.Response.StatusCode = 400; // Bad Request
        return;
    }
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


    
static void AddPlugins(IConfiguration config, Kernel kernel)
{

}
