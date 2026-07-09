<div class="vk-card">

# Long Poll (Прослушивание событий)

Служба **Long Poll** позволяет вашему приложению получать уведомления о новых событиях (таких как входящие сообщения или индикация набора текста пользователем) практически мгновенно, без необходимости периодически опрашивать сервер вручную.

Для использования Long Poll в вашей программе должен быть авторизованный клиент `OpenVkApi`.

</div>

<div class="vk-card">

# Поддерживаемые события

На данный момент служба Long Poll в `OpenVkNetApi` поддерживает:
* **`OnMessageNew`** — вызывается при получении нового сообщения. Возвращает объект сообщения и информацию о нём.
* **`OnUserTyping`** — вызывается, когда собеседник начинает вводить текст в диалоге с вами.
* **`OnError`** — возникает при сетевых сбоях, ошибках десериализации или проблемах связи с сервером Long Poll.

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
        var api = new OpenVkApi("https://api.openvk.org");
        await api.AuthorizeAsync("логин", "пароль");

        // Сервис LongPoll доступен как свойство клиента OpenVkApi
        // Он реализует IDisposable, поэтому его удобно оборачивать в using
        using var longPoll = api.LongPoll;

        // Подписываемся на событие новых сообщений
        longPoll.OnMessageNew += (sender, e) =>
        {
            Console.WriteLine($"[Новое сообщение] От: {e.Message.FromId} | Текст: {e.Message.Text}");
        };

        // Подписываемся на индикатор набора текста
        longPoll.OnUserTyping += (sender, e) =>
        {
            Console.WriteLine($"[Печать] Пользователь {e.UserId} вводит сообщение...");
        };

        // Логируем ошибки сети или сервера
        longPoll.OnError += (sender, e) =>
        {
            Console.WriteLine($"[Ошибка Long Poll] {e.ErrorMessage}");
            if (e.Exception != null)
            {
                Console.WriteLine(e.Exception.ToString());
            }
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
            // Метод выполняется бесконечно в асинхронном цикле до отмены CancellationToken
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
