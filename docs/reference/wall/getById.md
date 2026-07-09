<div class="vk-card">

# wall.getById

Возвращает список записей со стен по их идентификаторам.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.Enums;

var postsData = await api.Wall.GetByIdAsync(
    posts: "1_45,2_99",
    extended: true,
    fields: UserFields.FirstName | UserFields.LastName
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **posts** <br> `string` | Идентификаторы записей через запятую в формате `owner_id_post_id`. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **extended** <br> `bool` | Возвращать ли дополнительную информацию о профилях и сообществах. <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |
| **fields** <br> `UserFields` | Дополнительные поля профилей пользователей, если `extended` равен `true`. <br> <span style="color: var(--vp-c-text-3)">перечисление флагов, по умолчанию: UserFields.None</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект `WallGetById`, содержащий список полученных записей [Post](/reference/models/wall/post) в поле `Items`.

</div>
