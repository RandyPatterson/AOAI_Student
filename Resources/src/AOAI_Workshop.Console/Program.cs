using System.ComponentModel;
using Microsoft.Extensions.Configuration;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Agents;
using Microsoft.SemanticKernel.Agents.OpenAI;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.SemanticKernel.Agents.Chat;

#pragma warning disable SKEXP0110 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
#pragma warning disable SKEXP0001 // Type is for evaluation purposes only.

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddUserSecrets<Program>()
    .Build();
    
var oaiApiKey = config["AOI_API_KEY"];
var modelId = config["AOI_DEPLOYMODEL"];

var kernel = Kernel.CreateBuilder()
    .AddAzureOpenAIChatCompletion(
        config["AOI_DEPLOYMODEL"] ?? "gpt-35-turbo",
        config["AOI_ENDPOINT"]!,
        config["AOI_API_KEY"]!)
    .Build();
    
// Create Agent Personas


// Create an Agent for each Persona

// Create a Chat between the Agents

// Get the user input
string? input = "";
Console.WriteLine("Type out the requirements for your application.");
input = Console.ReadLine();

// Add the user's request to the chat history

// Invoke the agent and write the results to the console.


// Create a Termination Strategy to Determine when the Agents are finished
sealed class ApprovalTerminationStrategy : TerminationStrategy
{
    protected override Task<bool> ShouldAgentTerminateAsync(Agent agent, IReadOnlyList<ChatMessageContent> history, CancellationToken cancellationToken = default)
        => Task.FromResult(true);
}