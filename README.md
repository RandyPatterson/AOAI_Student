# What The Hack - Azure Open AI and Semantic Kernel Fundamentals

## Introduction

The Azure OpenAI and Semantic Kernel Fundamentals What The Hack is an introduction to understanding the conceptual foundations of infusing your application with AI using the Semantic Kernel development kit. Materials from this hack can serve as a foundation for building your own AI infused solutions with Semantic Kernel.

This hack consists of eight challenges and is designed to encourage learning and research. If you want a deeper understanding of how to implement an AI solution but have little or no experience with OpenAI or Semantic Kernel then this hack is for you.

Hack-a-thons are hosted as a 1 day event and is a team based activity where students work in groups of 3-5 people to solve the challenges. Each challenge is designed to be completed in 30-90 minutes.

## Learning Objectives

This hack is designed for individuals who want to gain practical experience in working with Azure OpenAI and Semantic Kernel. By applying this knowledge, you will be able to integrate AI into your own applications.

Participants will learn how to:

- Build a simple chat using Semantic Kernel
- Add plugins and enable auto calling
- Create a workflow plugin using Logic Apps
- Implement Retrieval Augmented Generation (RAG)
  - Document Chunking
  - Grounding AI
- Add Form Recognizer to parse digital forms

## Challenges

- **[Challenge 00: Prerequisites - Ready, Set, GO!](./Challenge-00.md)**
  - Prepare your workstation to work with Azure.
- [Challenge 01](./Challenge-01.md): Azure OpenAI Fundamentals
  - Deploy an Azure OpenAI Model
  - Prompt Engineering
  - What's possible through prompt engineering
  - Best practices when using OpenAI text and chat models
- [Challenge 02](./Challenge-02.md): Semantic Kernel Fundamentals
  - Semantic Kernel Fundamentals
  - Connect your OpenAI model using Semantic Kernel
  - Test Your Application
- [Challenge 03](./Challenge-03.md): Plugins
  - Functions and Plugins Fundamentals
  - Creating Semantic Kernel Plugins
  - Enable auto function calling
  - What is a Planner
- [Challenge 04](./Challenge-04.md): Import OpenAPI API as Semantic Kernel Plugin
  - Create a workflow plugin using Logic Apps
  - Import Logic App into Semantic Kernel
- [Challenge 05](./Challenge-05.md): RAG
  - Document Chunking
  - Add [Azure AI Document Intelligence](https://learn.microsoft.com/en-us/azure/ai-services/document-intelligence/overview?view=doc-intel-4.0.0) to parse digital forms??
  - [Document Intelligence Studio](https://documentintelligence.ai.azure.com/studio)
- [Challenge 06](./Challenge-06.md): Responsible AI
  - What are services and tools to identify and evaluate harms and data leakage in LLMs?
  - What are ways to evaluate truthfulness and reduce hallucinations? What are methods to evaluate a model if you don't have a ground truth dataset for comparison?
- [Challenge 07](./Challenge-07.md): Image Generation using DALL-E
  - Working with Text to Image Models
  - Creating an Image Generating Plugin
- [Challenge 08](./Challenge-08.md): Multi-Agents
  
## Prerequisites

- Access to an Azure Subscription
  - If you don't have one, [Sign Up for Azure HERE](https://azure.microsoft.com/en-us/free/) 
- [Access to Azure OpenAI](https://customervoice.microsoft.com/Pages/ResponsePage.aspx?id=v4j5cvGGr0GRqy180BHbR7en2Ais5pxKtso_Pz4b1_xUOFA5Qk1UWDRBMjg0WFhPMkIzTzhKQ1dWNyQlQCN0PWcu)
- [Access to GitHub Codespaces](https://github.com/signup)
  - All GitHub users have free access to [GitHub Codespaces](https://docs.github.com/en/codespaces/overview), a cloud-hosted development environment that you access via web browser.
  - If you don't have a GitHub account, [Sign up for GitHub here](https://github.com/signup).
  - If you use GitHub Codespaces, you do NOT need to install ANY prerequisites on your local workstation!

Students who wish to run this hack from their local workstation will require the following:

- [Visual Studio Code](https://code.visualstudio.com/download)
  - [C# Dev Kit Extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)
- Or Visual Studio 2022 +
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Git CLI](https://git-scm.com/downloads)
- [Azure CLI (Optional)](https://aka.ms/installazurecli)
- [Student Resources](./Challenge-00.md#student-resources)

## Contributors

- [Chris McKee](https://github.com/ChrisMcKee1)
- [Randy Patterson](https://github.com/RandyPatterson)
- [Zack Way](https://github.com/seiggy)
