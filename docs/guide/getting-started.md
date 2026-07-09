<div class="vk-card">

# Начало работы

**OpenVkNetApi** — это библиотека на языке C#, спроектированная для быстрого и простого взаимодействия с API социальной сети OpenVK. Она построена на базе стандарта `.NET Standard 1.1`, что даёт возможность использовать её во многих проектах (от десктопных Windows Forms / WPF и веб-сервисов ASP.NET до мобильных Xamarin-приложений и игр на Unity).

</div>

<div class="vk-card">

# Установка пакета

Вы можете подключить библиотеку к проекту с помощью NuGet.

## Через .NET CLI

Выполните команду в терминале вашего проекта:
```bash
dotnet add package OpenVkNetApi
```

## Через консоль диспетчера пакетов (Package Manager Console)

```powershell
Install-Package OpenVkNetApi
```

</div>

<div class="vk-card">

# Инициализация клиента

Для выполнения любых запросов к API вам понадобится экземпляр класса `OpenVkApi`. При его создании необходимо передать адрес инстанса OpenVK, с которым вы планируете работать.

```csharp
using OpenVkNetApi;

// Инициализируем API-клиент для официального сервера
var api = new OpenVkApi("https://api.openvk.org");
```

</div>

<div class="vk-card">

# Отправка первого запроса

Для выполнения большинства запросов требуется обязательная авторизация. Ниже приведен пример получения информации о пользователе с ID `1` после успешного входа:

```csharp
using System;
using System.Threading.Tasks;
using OpenVkNetApi;

class Program
{
    static async Task Main(string[] args)
    {
        var api = new OpenVkApi("https://api.openvk.org");

        // Авторизуемся перед выполнением запросов
        await api.AuthorizeAsync("ваш_логин", "ваш_пароль");

        // Запрашиваем информацию о пользователе с ID 1
        var users = await api.Users.GetAsync("1");
        
        if (users.Count > 0)
        {
            var user = users.Items[0];
            Console.WriteLine($"Имя: {user.FirstName} {user.LastName}");
            Console.WriteLine($"Никнейм: {user.ScreenName}");
        }
    }
}
```

</div>
