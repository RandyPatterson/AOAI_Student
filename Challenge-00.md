# Challenge 00 - Prerequisites - Ready, Set, GO!

**[Home](../README.md)** - [Next Challenge >](./Challenge-01.md)

## Introduction

Thank you for participating in the OpenAI & Semantic Kernel Fundamentals What The Hack. Before you can hack, you will need to set up some prerequisites.

## Description

In this challenge, you will set up the necessary prerequisites and environment to complete the rest of the hack, including:

- [Access Azure OpenAI](#access-azure-openai)
- [GitHub CodeSpaces](#setup-github-codespace) or [Local Workstation](#use-local-workstation)

### Access Azure OpenAI

You will need an Azure subscription to complete this hack. If you don't have one, choose one of the following options:

- [Azure Subscription](https://azure.microsoft.com/en-us/free/)

- Azure Passes: If your hack-a-thon group has access to an Azure Pass, you can utilize it to gain access to Azure OpenAI and other necessary Azure resources for this Hack-a-thon. Please see your instructor or event organizer for details on how to redeem your Azure Pass.

### Development Environment

You will need a development environment to complete the challenges. You can use GitHub CodeSpaces or set up a local development environment on your workstation.  We recommend using GitHub CodeSpaces as it is pre-configured with all the necessary tools and resources for this hack.

- [GitHub CodeSpaces](#github-codespaces)
- [Local Workstation](#use-local-workstation)


### GitHub CodeSpaces

GitHub CodeSpaces is a cloud-based development environment that allows you to develop entirely in the cloud. It provides a fully configured environment with all the tools and resources you need to complete the challenges. If you want to learn more about GitHub CodeSpaces, you can visit the [GitHub CodeSpaces Overview](https://docs.github.com/en/codespaces/overview). However we provide you with a pre-configured GitHub CodeSpace for this hack.

Let's get started with a pre-configured GitHub CodeSpace: [Launch CodeSpaces](https://open.vscode.dev/RandyPatterson/AOAI_Student)

#### Use Local Workstation

**NOTE:** You can skip this section if are using GitHub CodeSpaces!

##### Local Workstation Requirements

To work on your local workstation, please ensure you have the following tools and resources before hacking:

- [Visual Studio Code](https://code.visualstudio.com/download)
  - [C# Dev Kit Extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)
- Or [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Git CLI](https://git-scm.com/downloads)
- [Azure CLI (Optional)](https://aka.ms/installazurecli)
- [Student Resources](#student-resources)

### Student Resources

[Git Repo Student Resources](https://github.com/RandyPatterson/AOAI_Student)

From a directory where you want to store the resources, clone the repository:

```powershell
git clone https://github.com/RandyPatterson/AOAI_Student.git
```

The rest of the challenges will refer to the relative paths inside the Git Repository where you can find the various resources to complete the challenges.

## Success Criteria

To complete this challenge successfully, you should be able to:

### If using GitHub CodeSpaces

- Verify you have the following files & folders available in the CodeSpaces:

  ```text
  /workspaces/AOAI_Student
  ├───.devcontainer
  └───Resources
      └───src
          └───AOAI_Workshop
              ├───html
              ├───Plugins
              └───Properties
  ```

### If working on a local workstation

- Verify that you have **Visual Studio Code** with the ***C# Dev Kit*** Extension installed or **Visual Studio 2022**
- Verify you have the following files & folders locally:

  ```text
  /AOAI_Student
  ├───.devcontainer
  └───Resources
      └───src
          └───AOAI_Workshop
              ├───html
              ├───Plugins
              └───Properties
  ```

## Learning Resources

- [GitHub CodeSpaces Overview](https://docs.github.com/en/codespaces/overview)
