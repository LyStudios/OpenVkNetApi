<div class="vk-card">

# Аудиозаписи (Музыка)

Раздел `Audio` предоставляет методы для взаимодействия с аудиозаписями, плейлистами и трансляциями. Вызовы доступны через свойство `api.Audio` после успешной авторизации.

</div>

<div class="vk-card">

# Получение списка аудиозаписей

Вы можете получить аудиозаписи конкретного пользователя или сообщества. По умолчанию возвращаются аудиозаписи текущего авторизованного пользователя.

```csharp
using System;
using System.Threading.Tasks;
using OpenVkNetApi;
using OpenVkNetApi.Models.RequestParameters.Audio;

class Program
{
    static async Task Main(string[] args)
    {
        var api = new OpenVkApi("https://api.openvk.org");
        await api.AuthorizeAsync("логин", "пароль");

        // Настраиваем параметры запроса
        var parameters = new AudioGetParams
        {
            Count = 50,      // Сколько треков получить
            Offset = 0,      // Смещение для пагинации
            NeedUser = true  // Вернуть информацию о загрузившем пользователе
        };

        var audioCollection = await api.Audio.GetAsync(parameters);

        Console.WriteLine($"Всего аудиозаписей в коллекции: {audioCollection.Count}");

        foreach (var track in audioCollection.Items)
        {
            Console.WriteLine($"- {track.Artist} — {track.Title} ({track.Duration} сек.)");
            Console.WriteLine($"  Ссылка на поток: {track.Url}");
        }
    }
}
```

</div>

<div class="vk-card">

# Поиск музыки

```csharp
using OpenVkNetApi.Models.RequestParameters.Audio;

var searchParams = new AudioSearchParams
{
    Query = "Lagtrain",
    Count = 10
};

var searchResult = await api.Audio.SearchAsync(searchParams);
foreach (var track in searchResult.Items)
{
    Console.WriteLine($"Найдено: {track.Artist} - {track.Title}");
}
```

</div>

<div class="vk-card">

# Работа с плейлистами (альбомами)

Вы можете создавать новые плейлисты, добавлять в них треки и запрашивать список альбомов:

```csharp
// 1. Создание нового плейлиста
int playlistId = await api.Audio.AddAlbumAsync("Мой супер плейлист", "Описание плейлиста");
Console.WriteLine($"Создан плейлист с ID: {playlistId}");

// 2. Добавление аудиозаписи в плейлист (требуются IDs в формате "owner_id_audio_id")
await api.Audio.MoveToAlbumAsync(playlistId, "1_456239012");
```

</div>

<div class="vk-card">

# Трансляция статуса (Broadcast)

Вы можете транслировать проигрываемую аудиозапись в свой статус профиля или сообщества.

```csharp
// Устанавливаем текущий статус вещания
// Параметр audio принимает ID в формате "owner_id_audio_id"
// Параметр targetIds указывает ID получателей статуса (например, ваш ID)
await api.Audio.SetBroadcastAsync("1_456239012", api.CurrentUserId.ToString());
```

</div>
