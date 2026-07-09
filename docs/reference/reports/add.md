<div class="vk-card">

# reports.add

Отправляет жалобу на пользователя, сообщество или контент.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Reports;

var parameters = new ReportsAddParams
{
    Type = "user",
    OwnerId = 12,
    Reason = 0,
    Comment = "Спам и оскорбления в комментариях"
};

int result = await api.Reports.AddAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `ReportsAddParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **Type** <br> `string` | Тип объекта жалобы (`user` — пользователь, `group` — сообщество, `post` — запись на стене и т.д.). <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **OwnerId** <br> `int` | Идентификатор владельца объекта. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **ItemId** <br> `int?` | Идентификатор самого объекта (например, ID поста, если жалоба на пост). <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **Reason** <br> `int` | Причина жалобы (числовое значение от 0 до 8). <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **Comment** <br> `string` | Дополнительный комментарий к жалобе. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного отправления жалобы.

</div>
