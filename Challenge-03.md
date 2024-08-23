# Challenge 03 - Semantic Kernel Plugins

[< Previous Challenge](./Challenge-02.md) - **[Home](../README.md)** - [Next Challenge >](./Challenge-04.md)

## Pre-requisites

* You should have a functional version of the solution running in Visual Studio or Visual Studio Code.

## Introduction

Semantic Kernel starts to really show it's value in LLM development when you add plugins. Plugins are a way to give the AI extra capabilities and knowledge that cannot be trained into the model. Things such as time sensitive data, user specific information, and esoteric knowledge are all areas where the Plugin model can greatly improve the capabilities of your AI. In this challenge, you will implement a time plugin, and a plugin that retrieves the weather for a location to extend the capabilities of your chat bot.

## Description

This challenge will introduce you to building Semantic Kernels Plugins in C#, and how to chain plugins using the Auto Function Calling capabilities of Semantic Kernel.

Continuing from the previous challenge, navigate to ```.\Resources\src\``` and open the provided application in Visual Studio or Visual Studio Code.

Challenges:

* Launch your AI Chat app, and ask the bot `What time is it?`
  * Test the prompt ```What time is it?```

    Since the AI does not have the capability to provide real-time information, you will get a response similar to the following:

    ```plaintext
    I can't provide real-time information, including the current time. You can check the time on your device or through various online sources.
    ```

      Let's fix this by creating a plugin that can provide the current time.

* Create a new class in **./Plugins** directory for your Time Plugin
  * Write a time plugin with the following functions
    1. Return the current Date Time
    1. Return the Year for a date passed in as a parameter
    1. Return the Month for a date passed in as a parameter
    1. Return the Day of Week for a date passed in as a parameter
* Update the application to add your new Plugin to Semantic Kernel
  
  :bulb: Use the provided ```AddPlugins(...)``` method in the **Program.cs** file to add your new Plugin to Semantic Kernel. Review the documentation [Adding native plugins](https://learn.microsoft.com/en-us/semantic-kernel/concepts/plugins/adding-native-plugins?pivots=programming-language-csharp) for examples on how to do this

* Enable Automatic Function Calling

    in ```Program.cs``` below the comment ```//Challenge 3: Configure the execution settings for the OpenAI chat completion``` Configure Semantic Kernel to automatically call the functions in your plugin when the AI recognizes the intent. See [Using Automatic Function Calling](https://learn.microsoft.com/en-us/semantic-kernel/concepts/planning?pivots=programming-language-csharp#using-automatic-function-calling)

* Test the AI by asking the bot `What time is it?` again

  Now, the AI should be able to provide the current time by having Semantic Kernel call the ***GetTime*** function in your plugin. The response should be similar to the following:

  ```plaintext
  The current time is 3:43 PM on August 23, 2024.
  ```

* Create a plugin to take a user's location and return the Lat/Long coordinates. You can use a geocoding service from [Geocoding API](https://geocode.maps.co/)
* Create another Plugin that calls a Weather API, and add this to your Semantic Kernel. You can utilize the [Open Meteo API](https://open-meteo.com/en/docs) API here.  Add Methods to your plugin to:
  * Get the forecast weather at lat/long location and number of days
  * Get the weather at a lat/long location for a specific date range (archive / historical)
* Test your Plugins by asking the following question:
  
  ```plaintext
  What is the weather in San Francisco next Thursday
  ```

  >NOTE: Not necessarily in the following order, but the AI should perform the following steps to answer the question:
  
  :one: The AI should ask Semantic Kernel to call the ```GetDate``` function on the Time Plugin to get **today's** date in order to calculate the number of days until **next Thursday**

  :two: Because the Weather Forecast requires a Latitude and Longitude, the AI should instruct Semantic Kernel to call the ```GetLocation``` function on the Geocoding Plugin to get the coordinates for **San Francisco**

  :three: Finally, the AI should ask Semantic Kernel to call the ```GetWeatherForecast``` function on the Weather Plugin passing in the current date/time and Lat/Long to get the weather forecast for **Next Thursday** (expressed as the number of days in the future) at the coordinates for **San Francisco**

  :bulb: Set breakpoints in your plugins to verify that the functions are being called correctly and that the data is being passed between the plugins correctly.

## Success Criteria

To complete this challenge successfully, the AI should be able to answer the following questions correctly:

* What time is it?
* What was the date 4 days ago?
* What is the day of the week for the last day of next month?
* What day of the week does today's date next year fall on?

In addition, you should have a second plugin that can can answer questions around the weather. You should now be able to get the Chatbot to answer the following questions:

* What is today's weather in San Francisco?
* Is it going to rain next week?
* What's the high temp going to be today?
* Do I need a raincoat for my movie date Friday?

## Learning Resources

*Semantic Kernel Resource Links:*

* [Plugins for Semantic Kernel](https://learn.microsoft.com/en-us/semantic-kernel/concepts/plugins/?pivots=programming-language-csharp)
* [Adding Native Plugins to Semantic Kernel](https://learn.microsoft.com/en-us/semantic-kernel/concepts/plugins/adding-native-plugins?pivots=programming-language-csharp)

* [Planning in Semantic Kernel](https://learn.microsoft.com/en-us/semantic-kernel/concepts/planning?pivots=programming-language-csharp)

* [Planning with Automatic Function Calling](https://devblogs.microsoft.com/semantic-kernel/planning-with-semantic-kernel-using-automatic-function-calling/)

*API Client Resources:*

* [Microsoft Recommendations for HTTP Client](https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/http/httpclient-guidelines#recommended-use)

* [The Right Way to use HttpClient in .NET](https://www.milanjovanovic.tech/blog/the-right-way-to-use-httpclient-in-dotnet)

*API Docs:*

* [Geocoding API](https://geocode.maps.co/)

* [Open-Meteo API](https://open-meteo.com/en/docs)

## Tips

* Use a API test client such as Bruno or Postman to test the APIs  first, before writing code to connect it to your plugin.

## Advanced Challenges (Optional)

Too comfortable?  Eager to do more?  Try these additional challenges!

* Add debug logging messages to your Time plugin.

* Create a Plugin to pull data from a database instead of an API. You can find publicly available data sources here: [Database Star - Free Datasets](https://www.databasestar.com/free-data-sets/)

* Use the resources below to find a public API to build another plugin with.
  * [Public API Search Engine](https://publicapis.io/)
  * [Public API List on GitHub](https://github.com/public-api-lists/public-api-lists)
  * [Open API List](https://apilist.fun/)

* Look for APIs that are either current event related - such as  events and calendars - or something with esoteric knowledge that the AI does poorly with, such as the UPC database, or something like the [PokeAPI - Pokemon Pokedex API](https://pokeapi.co/docs/v2).
