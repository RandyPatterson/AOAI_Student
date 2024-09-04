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

- [Setup GitHub CodeSpace](#setup-github-codespace)

- [Use Local Workstation](#use-local-workstation)


### Setup GitHub CodeSpace

You can use [GitHub CodeSpaces](https://docs.github.com/en/codespaces/overview) where we have a pre-configured Visual Studio Code lab environment set up and ready to go for you, or you can setup a Development environment on your local workstation.

A GitHub CodeSpace is a development environment that is hosted in the cloud that you access via a browser. All of the pre-requisite developer tools for this hack are pre-installed and available in the CodeSpace.

- [Use GitHub CodeSpaces](#use-github-codespaces)

We highly recommend using GitHub CodeSpaces to make it easier complete this hack.

#### Use GitHub CodeSpaces

You must have a GitHub account to use GitHub v. If you do not have a GitHub account, you can [Sign Up Here](https://github.com/signup).

GitHub CodeSpaces is available for developers in every organization. All personal GitHub.com accounts include a monthly quota of free usage each month. GitHub will provide users in the Free plan 120 core hours, or 60 hours of run time on a 2 core CodeSpace, plus 15 GB of storage each month.

You can see your balance of available CodeSpace hours on the [GitHub billing page](https://github.com/settings/billing/summary).

The GitHub CodeSpace for this hack will host Visual Studio Code with .NET 8 and relevant extensions installed, the starter application, configuration files, and other data files needed for this event. Here are the steps you will need to follow:

- A GitHub repo containing the student resources and CodeSpace for this hack is hosted here:
  - [WTH OpenAI and Semantic Kernel Fundamentals Repo](https://github.com/RandyPatterson/AOAI_Student)
  - Please open this link and sign in with your personal GitHub account.

**NOTE:** Make sure you do not sign in with your enterprise managed GitHub account.

- Once you are signed in, click on the green "Code" button. Then click on "CodeSpaces". Finally, hit "Create CodeSpace on main".

Your CodeSpace environment should load in a new browser tab. It will take approximately 3-5 minutes the first time you create the CodeSpace for it to load.

- When the CodeSpace completes loading, you should find an instance of Visual Studio Code running in your browser with the files needed for this hackathon.

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

- Verify you have the following files & folders available in the CodeSpace:

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
