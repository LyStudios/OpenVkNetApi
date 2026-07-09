<div class="vk-card">

# audio.getPlaylists

Возвращает список плейлистов (альбомов) пользователя или сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Audio;

var parameters = new AudioGetAlbumsParams
{
    OwnerId = 1,
    Count = 10
};

var playlists = await api.Audio.GetPlaylistsAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `AudioGetAlbumsParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **OwnerId** <br> `int` | Идентификатор владельца плейлистов. Для сообщества укажите отрицательное значение. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **Offset** <br> `int` | Смещение для выборки. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество плейлистов, которое необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 50, максимум: 100</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<Album>` с объектами плейлистов [Album](/reference/models/audio/album).

</div>
