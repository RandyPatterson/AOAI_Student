### [< Previous Challenge](./Challenge-03.md) - **[Home](./README.md)** - [Next Challenge >](./Challenge-05.md)

# Challenge 04 -  Create a workflow plugins using a Logic App

## Introduction

As Developers we already use developer tools like Azure DevOps and GitHub. So why not see what cool thing Semantic Kernel can do with Azure Logic Apps. In this challenge, you will learn how to create a workflow plugin using Azure Logic Apps and how to integrate it with Azure OpenAI to build powerful AI infused applications. Using Logic Apps brings together over 1400 connectors (APIs) to help you integrate with other services and applications. Logic Apps is a powerful tool that can be used to automate workflows and business processes. Using Semantic Kernel, you can chain together multiple prompts to create a more complex conversation with the AI that is interconnected to multiple APIs and services. 

## Pre-requisites

1. [Setup Azure DevOps](./Challenge-04-Prereq-ADO.md)
1. [Setup Azure Logic Apps](./Challenge-04-Prereq-LogicApp.md)

>NOTE: These pre-requisites are required to complete the challenges in this module. If you have not completed the pre-requisites, please do so before proceeding with the challenges. Most of the challenges in this module will require the Azure DevOps project and Azure Logic App created in the pre-requisites.

### Challenges

This challenge will introduce you to how to import OpenAPI API as Semantic Kernels Plugins in C#, and how to chain plugins using the Auto Function Calling capabilities of Semantic Kernel.

1. Launch your AI Chat app, and ask the bot `What are my work items?`
    - Test the prompt "What are my work items?" see how it responds.
1. In addition to Challenge 3, you will be adding a new plugin to your Semantic Kernel using the Logic App you created in the pre-req.
    - You will import your Logic App from the pre-req into Semantic Kernel.
    - Test the prompt "What are my work items?" see how it responds.
1. You will create 2 additional Logic Apps Workflows to chained together to create a more complex conversation with the AI.

## Success Criteria

1. Your chat bot should be able to answer the question "What are my work items?" with a list of work items from Azure DevOps.

## Learning Resources

[Integrate Logic App workflows as plugins with Semantic Kernel: Step-by-step guide](https://techcommunity.microsoft.com/t5/azure-integration-services-blog/integrate-logic-app-workflows-as-plugins-with-semantic-kernel/ba-p/4210854)

[Add Logic Apps as plugins](https://learn.microsoft.com/en-us/semantic-kernel/concepts/plugins/adding-logic-apps-as-plugins)

[Add plugins from OpenAPI specifications](https://learn.microsoft.com/en-us/semantic-kernel/concepts/plugins/adding-openapi-plugins?pivots=programming-language-csharp)

[OpenApiFunctionExecutionParameters](https://learn.microsoft.com/en-us/dotnet/api/microsoft.semantickernel.plugins.openapi.openapifunctionexecutionparameters?view=semantic-kernel-dotnet)

[ImportPluginFromOpenApiAsync](https://learn.microsoft.com/en-us/dotnet/api/microsoft.semantickernel.plugins.openapi.openapikernelextensions.importpluginfromopenapiasync?view=semantic-kernel-dotnet)

### [< Previous Challenge](./Challenge-03.md) - **[Home](./README.md)** - [Next Challenge >](./Challenge-05.md)
