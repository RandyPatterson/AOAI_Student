### **[Home](./README.md)** - [Next Challenge >](./Challenge-01.md)

# Challenge 00 - Prerequisites - Ready, Set, GO!

## Introduction

Thank you for participating in the OpenAI & Semantic Kernel Fundamentals What The Hack. Before you can hack, you will need to set up some prerequisites.

## Description

In this challenge, you will set up the necessary prerequisites and environment to complete the rest of the hack.

### Access Azure OpenAI

You will need an Azure subscription to complete this hack. If you don't have one, choose one of the following options:

- [Azure Subscription](https://azure.microsoft.com/en-us/free/)

- Azure Passes: If your hack-a-thon group has access to an Azure Pass, you can utilize it to gain access to Azure OpenAI and other necessary Azure resources for this Hack-a-thon. Please see your instructor or event organizer for details on how to redeem your Azure Pass.

### Development Environment

You will need a development environment to complete the challenges. You can use GitHub CodeSpaces or set up a local development environment on your workstation.  We recommend using GitHub CodeSpaces as it is pre-configured with all the necessary tools and resources for this hack.

- [GitHub CodeSpaces](#github-codespaces)
- [Local Workstation](#use-local-workstation)

#### GitHub CodeSpaces

GitHub CodeSpaces is a cloud-based development environment that allows you to develop entirely in the cloud. It provides a fully configured environment with all the tools and resources you need to complete the challenges. If you want to learn more about GitHub CodeSpaces, you can visit the [GitHub CodeSpaces Overview](https://docs.github.com/en/codespaces/overview). However we provide you with a pre-configured GitHub CodeSpaces for this hack.

Let's get started with a pre-configured GitHub CodeSpaces: [Launch CodeSpaces](https://codespaces.new/RandyPatterson/AOAI_Student)

#### Use Local Workstation

Using your local workstation is another option to complete the challenges. You will need to set up the necessary tools and resources on your local workstation to complete the challenges and will need to clone the Student Resources Git Repository to your local workstation.

##### Install the following tools on your Local Workstation:

- [Visual Studio Code](https://code.visualstudio.com/download)
  - [C# Dev Kit Extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)
- Or [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Git CLI](https://git-scm.com/downloads)
- [Azure CLI (Optional)](https://aka.ms/installazurecli)
- [Student Resources](#student-resources)
 
##### Clone the Student Resources to your Local Workstation

From a directory where you want to store the resources, clone the [repository](https://github.com/RandyPatterson/AOAI_Student). You can do this by running the following command in your terminal or command prompt:

  ```powershell
  git clone https://github.com/RandyPatterson/AOAI_Student.git
  ```

The rest of the challenges will refer to the relative paths inside the Git Repository where you can find the various resources to complete the challenges.

## Success Criteria

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

### If working on a Local Workstation

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

### **[Home](./README.md)** - [Next Challenge >](./Challenge-01.md)
