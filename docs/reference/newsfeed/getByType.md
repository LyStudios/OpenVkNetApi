<div class="vk-card">

# newsfeed.getByType

Возвращает список новостей, отфильтрованных по определенному типу.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Newsfeed;

var parameters = new NewsfeedGetByTypeParams
{
    Type = "photo",
    Count = 10
};

var photoNews = await api.Newsfeed.GetByTypeAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `NewsfeedGetByTypeParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **Type** <br> `string` | Тип возвращаемых новостей (например, `photo` — новости с фотографиями, `post` — посты на стене). <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **Count** <br> `int` | Количество записей, которое необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20, максимум: 100</span> |
| **Offset** <br> `int` | Смещение для выборки определенного подмножества записей. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **StartFrom** <br> `string` | Идентификатор для получения следующей страницы результатов. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [NewsfeedCollection](/reference/models/newsfeed/newsfeed-collection), содержащий список объектов [Post](/reference/models/wall/post).

</div>
