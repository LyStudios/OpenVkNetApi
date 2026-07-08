# OpenVkNetApi

[Read in English](README.md)

[![NuGet Version](https://img.shields.io/nuget/v/OpenVkNetApi.svg?style=flat-square)](https://www.nuget.org/packages/OpenVkNetApi/)
[![Target Framework](https://img.shields.io/badge/.NET%20Standard-1.1-blue.svg?style=flat-square)](https://learn.microsoft.com/en-us/dotnet/standard/net-standard)
[![License](https://img.shields.io/github/license/LyStudios/OpenVkNetApi.svg?style=flat-square)](LICENSE)

Полностью асинхронная C#/.NET библиотека для работы с **OpenVK API**. Спроектирована для высокой производительности и удобства использования, нацелена на `.NET Standard 1.1` для максимальной совместимости между различными платформами (включая .NET Framework, .NET Core, Xamarin и Unity).

---

## Возможности

- **Полная асинхронность:** Все сетевые запросы и дисковые операции по умолчанию асинхронные.
- **Строгая типизация:** Полный маппинг моделей OpenVK (профили, группы, сообщения, видео, вложения и др.) в классы C# с чистой сериализацией JSON.
- **Надежный сервис Long Poll:** Высокопроизводительное прослушивание событий сервера в фоновом режиме, включая:
  - События получения новых сообщений.
  - Оповещения о вводе текста в реальном времени (`Пользователь пишет сообщение...`) в личных диалогах.
  - Автоматическое обновление ключа сессии и логика повторных попыток при разрыве соединения.

---

## Установка

Установите пакет через консоль NuGet Package Manager:

```bash
dotnet add package OpenVkNetApi
```

Или найдите `OpenVkNetApi` через графический менеджер пакетов NuGet в Visual Studio.

---

## Быстрый старт

### 1. Инициализация клиента и авторизация

```csharp
using OpenVkNetApi;

// Инициализация API клиента для нужного инстанса OpenVK
var api = new OpenVkApi("https://api.openvk.org");

// Авторизация по логину и паролю
var authInfo = await api.AuthorizeAsync("your_username", "your_password");

Console.WriteLine($"Авторизация успешна! Токен доступа: {api.AccessToken}");
```

### 2. Простой вызов API (Отправка сообщения)

```csharp
using OpenVkNetApi.Models.RequestParameters.Messages;

var messageParams = new MessagesSendParams
{
    PeerId = 12345, // ID пользователя или диалога
    Message = "Привет от OpenVkNetApi!"
};

var sentIds = await api.Messages.SendAsync(messageParams);
Console.WriteLine($"Сообщение отправлено! ID: {sentIds[0]}");
```

### 3. Использование сервиса Long Poll

Слушайте входящие сообщения и события печати текста в реальном времени:

```csharp
using System;
using System.Threading;
using OpenVkNetApi.Services;

// Инициализация сервиса (использует оптимизированный HttpClient для фонового опроса)
using var longPoll = api.LongPoll;

// Подписка на события
longPoll.OnMessageNew += (sender, e) =>
{
    Console.WriteLine($"Новое сообщение от {e.Message.FromId}: {e.Message.Text}");
};

longPoll.OnUserTyping += (sender, e) =>
{
    Console.WriteLine($"Пользователь {e.UserId} пишет сообщение...");
};

longPoll.OnError += (sender, e) =>
{
    Console.WriteLine($"Ошибка Long Poll: {e.ErrorMessage}");
};

// Запуск прослушивания (Асинхронный цикл)
var cts = new CancellationTokenSource();
Console.WriteLine("Слушаем события... Нажмите Ctrl+C для выхода.");
await longPoll.StartAsync(cts.Token);
```

---

## Лицензия

Этот проект распространяется под лицензией MIT — подробности см. в файле [LICENSE](LICENSE).
