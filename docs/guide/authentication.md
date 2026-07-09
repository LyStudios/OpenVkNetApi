<div class="vk-card">

# Авторизация

Для работы с большинством методов API (например, для чтения личных сообщений, управления аудиозаписями или отправки постов) требуется авторизоваться на сервере и получить access token.

В **OpenVkNetApi** поддерживается два основных способа авторизации:
1. Авторизация по логину и паролю.
2. Использование уже существующего access token.

</div>

<div class="vk-card">

# 1. Авторизация по логину и паролю

Этот метод выполняет POST-запрос на авторизацию и автоматически сохраняет полученный токен внутри экземпляра клиента.

```csharp
using System;
using System.Threading.Tasks;
using OpenVkNetApi;

class Program
{
    static async Task Main(string[] args)
    {
        var api = new OpenVkApi("https://api.openvk.org");

        try
        {
            // Авторизуемся по логину (или email) и паролю
            var authInfo = await api.AuthorizeAsync("ваш_логин", "ваш_пароль");
            
            Console.WriteLine("Успешный вход!");
            Console.WriteLine($"Ваш токен: {api.AccessToken}");
            Console.WriteLine($"ID пользователя: {authInfo.UserId}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка авторизации: {ex.Message}");
        }
    }
}
```

</div>

<div class="vk-card">

# 2. Использование существующего токена

Если у вас уже сохранен токен авторизации (например, из базы данных или настроек приложения), вы можете передать его напрямую в клиент:

```csharp
using OpenVkNetApi;

// Передаем токен сразу в конструктор
var api = new OpenVkApi("https://api.openvk.org", "ваш_сохраненный_токен");

// Теперь можно сразу делать защищенные запросы
var myProfile = await api.Users.GetAsync();
```

</div>
