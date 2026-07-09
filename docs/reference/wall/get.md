<div class="vk-card">

# wall.get

Возвращает список записей со стены пользователя или сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Wall;

var parameters = new WallGetParams
{
    OwnerId = 1,
    Count = 10,
    Filter = "owner"
};

var wallData = await api.Wall.GetAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `WallGetParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **OwnerId** <br> `int?` | Идентификатор пользователя или сообщества, со стены которого необходимо получить записи. Для сообщества укажите отрицательное значение. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: текущий пользователь</span> |
| **Domain** <br> `string` | Короткий адрес пользователя или сообщества (например, `durov`). <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Offset** <br> `int` | Смещение, необходимое для выборки определенного подмножества записей. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **Count** <br> `int` | Количество записей, которое необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 20, максимум: 100</span> |
| **Filter** <br> `string` | Определяет типы возвращаемых записей (`all`, `owner`, `others`). <br> <span style="color: var(--vp-c-text-3)">строка, по умолчанию: "all"</span> |
| **Extended** <br> `bool` | Возвращать ли дополнительную информацию о профилях и сообществах. <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект `WallGet`, содержащий общее количество записей (`Count`) и список объектов [Post](/reference/models/wall/post) в поле `Items`.

</div>
