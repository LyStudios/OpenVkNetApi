<div class="vk-card">

# audio.get

Возвращает список аудиозаписей пользователя или сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Audio;

var parameters = new AudioGetParams
{
    OwnerId = 1,
    Count = 10
};

var audioList = await api.Audio.GetAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `AudioGetParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **OwnerId** <br> `int` | Идентификатор владельца аудиозаписей. Для сообщества укажите отрицательное значение. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **AlbumId** <br> `int?` | Идентификатор альбома, из которого нужно получить аудиозаписи. <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **AudioIds** <br> `string` | Идентификаторы конкретных аудиозаписей через запятую. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Offset** <br> `int` | Смещение для выборки подмножества аудиозаписей. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество возвращаемых аудиозаписей. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 50, максимум: 5000</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [AudioCollectionWithShuffle](/reference/models/audio/audio-collection-with-shuffle), содержащий список аудиозаписей [Audio](/reference/models/audio/audio).

</div>
