<div class="vk-card">

# newsfeed.getGlobal

Возвращает глобальный (общий) список записей (постов) со всего сервера OpenVK.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Newsfeed;

var parameters = new NewsfeedGetGlobalParams
{
    Count = 15
};

var globalNews = await api.Newsfeed.GetGlobalAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `NewsfeedGetGlobalParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **Filter** <br> `string` | Список типов источников новостей, разделенных запятыми. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Count** <br> `int` | Количество записей, которое необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20, максимум: 100</span> |
| **Offset** <br> `int` | Смещение для выборки определенного подмножества записей. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **StartFrom** <br> `string` | Идентификатор для получения следующей страницы результатов. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [NewsfeedCollection](/reference/models/newsfeed/newsfeed-collection), содержащий список объектов [Post](/reference/models/wall/post).

</div>
