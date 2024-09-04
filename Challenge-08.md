### [< Previous Challenge](./Challenge-07.md) - **[Home](./README.md)**

# Challenge 08 - Multi-Agent System

## Introduction

Multi-Agent Systems (MAS) consist of multiple autonomous agents, each with distinct goals, behaviors, and areas of responsibility. These agents can interact with each other, either cooperating or competing, depending on the objectives they are designed to achieve. In MAS, each agent operates independently, making decisions based on its local knowledge and the environment, but they can communicate and share information to solve complex problems collectively.

MAS is often used in scenarios where tasks are distributed across different entities, and the overall system benefits from decentralization. Examples include simulations of real-world systems like traffic management, robotic teams, distributed AI applications, or networked systems where agents need to coordinate actions without a central controller. MAS allows for flexibility, scalability, and adaptability in solving dynamic and complex problems where a single agent or centralized system might be less efficient or incapable of handling the complexity on its own.

## Description

In this challenge, you will create a multi-agent system that takes the user's request and feeds it to a collection of agents. Each agent will have it's own persona and responsibility. The final response will be a collection of answers from all agents that together will satisfy the user's request based on each persona's area of expertise.

### Challenges

1. First, we're going to open the AOAI_Workshop.Console app. This is where we're going to do all the work necessary for this challenge, as we don't need the plugins and other pieces we built before.

2. Open the User Secrets for the AOAI_Workshop.Console app. Add in your Azure OpenAI details that you used in the previous exercises. Ensure that the following details are set. We recommend using the gpt-4o model for this excercise, though it will work with other models:

```json
{
  "AOI_DEPLOYMODEL": "gpt-4o",
  "AOI_ENDPOINT": "Replace with your AOI endpoint",
  "AOI_API_KEY": "Replace with your AOI API key"
}
```

1. Open the `Program.cs` file. The first thing we need to do is create the personas for our 3 agents. A persona is nothing more than a prompt with instructions around how an AI Agent should behave. We're going to use the following 3 persona's.

```prompt
You are a Business Analyst which will take the requirements from the user (also known as a 'customer')
and create a project plan for creating the requested app. The Business Analyst understands the user
requirements and creates detailed documents with requirements and costing. The documents should be 
usable by the Software Engineer as a reference for implementing the required features, and by the 
Product Owner for reference to determine if the application delivered by the Software Engineer meets
all of the user's requirements.
```

```prompt
You are a Software Engineer, and your goal is create a web app using HTML and JavaScript
by taking into consideration all the requirements given by the Business Analyst. The application should
implement all the requested features. Deliver the code to the Product Owner for review when completed.
You can also ask questions of the Business Analyst to clarify any requirements that are unclear.
```

```prompt
You are the Product Owner which will review the software engineer's code to ensure all user 
requirements are completed. You are the guardian of quality, ensuring the final product meets
all specifications and receives the green light for release. Once all client requirements are
completed, you can approve the request by just responding "approve". Do not ask any other agent
or the user for approval. If there are missing features, you will need to send a request back
to the Software Engineer or Business Analyst with details of the defect.
```

4. Create string objects and add these personas. Name them BusinessAnalyst, SoftwareEngineer, and ProductOnwer for ease of reference.

5. Next we need to create an Agent for each persona. These Agents should be `ChatCompletionAgent` objects. They will all share the same Kernel Configuration.

6. Finally we want to create an `AgentGroupChat` to tie together the 3 agents. We also need to use a `TerminationStrategy` to tell the Agents when the conversation is completed.

7. At the bottom of `Program.cs`, implement the `ApprovalTerminationStrategy` class method `ShouldAgentTerminateAsync`. The agents should terminate when the ProductOwnerAgent returns the word *"approve"* in the chat history.

8. Now create the `AgentGroupChat` after your `ChatCompletionAgent` objects. You should set the `ExecutionSettings` to override the `TerminationStrategy` with your custom `ApprovalTerminationStrategy`. Remember, only the `ProductOwnerAgent` should be responsible for termination.

9. Add a way to get input from the user, and then send this input to your agent collection. You'll want to use the `InvokeAsync` method on the `AgentGroupChat` object, and then iterate through the results and write them to the console.

10. Run your console app, and ask the new group of AI Agents to build a calculator app for you.

### Success Criteria

- You have a console app that will write out the following from a conversation with 3 AI Agents:
   1. Software Development Plan and Requirements
   2. Source Code in HTML and Javascript
   3. Code Review and Approval

## Learning Resources

- [MetaGPT](https://github.com/geekan/MetaGPT) - Multi-agent Framework. Great example of what a complex multi-agent system can do.
- [AutoGen Multi-Agent Conversational Framework](https://microsoft.github.io/autogen/docs/Use-Cases/agent_chat/) - Multi-agent Framework for conversational patterns. Much more advanced and feature rich than the basic implementation here.
- [AutoGen with Semantic Kernel](https://devblogs.microsoft.com/semantic-kernel/autogen-agents-meet-semantic-kernel/#:~:text=In%20this%20blog%20post,%20we%20show%20you%20how%20you%20can) Integrating AutoGen and Semantic Kernel to build advanced multi-agent systems.

### [< Previous Challenge](./Challenge-07.md) - **[Home](./README.md)**
