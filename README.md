# OpenVkNetApi

[Читать на русском языке (Russian)](README.ru.md)

[![Documentation](https://img.shields.io/badge/docs-website-brightgreen.svg?style=flat-square)](https://lystudios.github.io/OpenVkNetApi/)
[![NuGet Version](https://img.shields.io/nuget/v/OpenVkNetApi.svg?style=flat-square)](https://www.nuget.org/packages/OpenVkNetApi/)
[![Target Framework](https://img.shields.io/badge/.NET%20Standard-1.1-blue.svg?style=flat-square)](https://learn.microsoft.com/en-us/dotnet/standard/net-standard)
[![License](https://img.shields.io/github/license/LyStudios/OpenVkNetApi.svg?style=flat-square)](LICENSE)

A fully asynchronous C#/.NET library for interacting with the **OpenVK API**. Built with ease of use and performance in mind, targeting `.NET Standard 1.1` to ensure maximum compatibility across diverse platforms (including .NET Framework, .NET Core, Xamarin, and Unity).

> 💡 **Looking for API Reference?** Check out the [Documentation Website](https://lystudios.github.io/OpenVkNetApi/).

---

## Features

- **Fully Asynchronous:** All network requests and disk operations are async-first.
- **Strongly Typed:** Complete mapping of OpenVK models (Profiles, Groups, Messages, Video, Attachments, etc.) to C# classes with clean JSON serialization.
- **Robust Long Poll Service:** High-performance background listening of server events, including:
  - New message events.
  - Real-time typing indicators (`User is typing...`) in private dialogues.
  - Automatic session key refreshing and retry logic on connection dropouts.

---

## Installation

Install the package via NuGet Package Manager CLI:

```bash
dotnet add package OpenVkNetApi
```

Or search for `OpenVkNetApi` in the Visual Studio NuGet Package Manager.

---

## Quick Start

### 1. Initialize Client & Authorize

```csharp
using OpenVkNetApi;

// Create the API client for your target OpenVK instance
var api = new OpenVkApi("https://api.openvk.org");

// Authorize with username and password
var authInfo = await api.AuthorizeAsync("your_username", "your_password");

Console.WriteLine($"Authorized successfully! Access Token: {api.AccessToken}");
```

### 2. Basic API Call (Send a Message)

```csharp
using OpenVkNetApi.Models.RequestParameters.Messages;

var messageParams = new MessagesSendParams
{
    PeerId = 12345, // Target user or chat ID
    Message = "Hello from OpenVkNetApi!"
};

var sentIds = await api.Messages.SendAsync(messageParams);
Console.WriteLine($"Message sent! ID: {sentIds[0]}");
```

### 3. Use the Long Poll Service

Listen to incoming messages and typing status in real-time:

```csharp
using System;
using System.Threading;
using OpenVkNetApi.Services;

// Initialize the service (uses internal HTTP client optimized for background polling)
using var longPoll = api.LongPoll;

// Subscribe to events
longPoll.OnMessageNew += (sender, e) =>
{
    Console.WriteLine($"New message from {e.Message.FromId}: {e.Message.Text}");
};

longPoll.OnUserTyping += (sender, e) =>
{
    Console.WriteLine($"User {e.UserId} is typing...");
};

longPoll.OnError += (sender, e) =>
{
    Console.WriteLine($"Long Poll Error: {e.ErrorMessage}");
};

// Start listening (Async Loop)
var cts = new CancellationTokenSource();
Console.WriteLine("Listening for events... Press Ctrl+C to stop.");
await longPoll.StartAsync(cts.Token);
```

---

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
