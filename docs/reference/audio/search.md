<div class="vk-card">

# audio.search

Выполняет поиск аудиозаписей по текстовому запросу.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Audio;

var parameters = new AudioSearchParams
{
    Query = "Miku",
    Count = 10
};

var searchResult = await api.Audio.SearchAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `AudioSearchParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **Query** <br> `string` | Текст поискового запроса. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **Count** <br> `int` | Количество возвращаемых треков. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 30, максимум: 300</span> |
| **Offset** <br> `int` | Смещение выборки. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<Audio>` с найденными объектами аудиозаписей [Audio](/reference/models/audio/audio).

</div>
