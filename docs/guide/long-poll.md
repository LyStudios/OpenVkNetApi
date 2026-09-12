<div class="vk-card">

# Long Poll (Прослушивание событий)

Служба **Long Poll** позволяет вашему приложению получать уведомления о новых событиях (входящие и отредактированные сообщения, прочтение диалогов, онлайн/оффлайн статус пользователей, набор текста и запись голосовых сообщений) практически мгновенно, без необходимости периодически опрашивать сервер вручную.

Для использования Long Poll в вашей программе должен быть авторизованный клиент `OpenVkApi`.

</div>

<div class="vk-card">

# Поддерживаемые события

Служба `LongPollService` поддерживает следующие события:

| Событие | Аргументы | Описание |
| :--- | :--- | :--- |
| **`OnMessageNew`** | `NewMessageEventArgs` | Поступление нового сообщения. |
| **`OnMessageEdit`** | `MessageEditEventArgs` | Редактирование сообщения. |
| **`OnMessagesRead`** | `MessagesReadEventArgs` | Прочтение входящих или исходящих сообщений. |
| **`OnUserOnline`** | `UserOnlineEventArgs` | Пользователь появился в сети. |
| **`OnUserOffline`** | `UserOfflineEventArgs` | Пользователь вышел из сети. |
| **`OnChatChanged`** | `ChatChangeEventArgs` | Изменение параметров беседы. |
| **`OnUnreadCountChanged`** | `UnreadCountEventArgs` | Изменение счетчика непрочитанных диалогов. |
| **`OnUserTyping`** | `UserTypingEventArgs` | Собеседник набирает текст или записывает аудио. |
| **`OnError`** | `LongPollErrorEventArgs` | Сетевые ошибки или сбои подключения. |

</div>

<div class="vk-card">

# Пример использования

```csharp
using System;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi;
using OpenVkNetApi.Services;

class Program
{
    static async Task Main(string[] args)
    {
        var api = new OpenVkApi("https://openvk.su");
        await api.AuthorizeAsync("логин", "пароль");

        using var longPoll = api.LongPoll;

        // Новые сообщения
        longPoll.OnMessageNew += (sender, e) =>
        {
            var msg = e.Message;
            Console.WriteLine($"[Сообщение] От {msg.FromId} в {msg.PeerId}: {msg.Text}");
        };

        // Редактирование сообщений
        longPoll.OnMessageEdit += (sender, e) =>
        {
            Console.WriteLine($"[Изменено #{e.MessageId}]: {e.Text}");
        };

        // Прочтение сообщений
        longPoll.OnMessagesRead += (sender, e) =>
        {
            Console.WriteLine($"[Прочтение] В диалоге {e.PeerId} прочитано до #{e.LocalId}");
        };

        // Онлайн / Оффлайн
        longPoll.OnUserOnline += (sender, e) =>
        {
            Console.WriteLine($"[Онлайн] Пользователь {e.UserId}");
        };

        longPoll.OnUserOffline += (sender, e) =>
        {
            Console.WriteLine($"[Оффлайн] Пользователь {e.UserId}");
        };

        // Индикатор набора текста / записи аудио
        longPoll.OnUserTyping += (sender, e) =>
        {
            string act = e.IsAudioMessage ? "записывает аудио" : "набирает текст";
            Console.WriteLine($"[Активность] Пользователь {e.UserId} {act}...");
        };

        // Изменение счетчика непрочитанных
        longPoll.OnUnreadCountChanged += (sender, e) =>
        {
            Console.WriteLine($"[Непрочитано] Диалогов: {e.Count}");
        };

        // Ошибки
        longPoll.OnError += (sender, e) =>
        {
            Console.WriteLine($"[Ошибка] {e.ErrorMessage}");
        };

        var cts = new CancellationTokenSource();
        Console.CancelKeyPress += (sender, eventArgs) =>
        {
            eventArgs.Cancel = true;
            cts.Cancel();
        };

        Console.WriteLine("Служба Long Poll запущена. Нажмите Ctrl+C для выхода...");

        try
        {
            await longPoll.StartAsync(cts.Token);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Прослушивание остановлено.");
        }
    }
}
```

</div>

<div class="vk-card">

# Автоматическое восстановление ключа сессии

Сервер OpenVK периодически аннулирует сессионные ключи Long Poll или сбрасывает историю событий (возвращая код `failed` 2 или 3). Служба `LongPollService` обрабатывает эти ситуации автоматически: она отправляет запрос на обновление параметров к основному API OpenVK (`RefreshServerAsync`) и плавно возобновляет работу, поэтому вам не нужно перезапускать службу вручную при сбое сессии.

</div>
