<div class="vk-card">

# wall.getArchiveYears

Возвращает список годов, за которые у пользователя или сообщества имеются архивированные посты.

# Вызов метода

```csharp
List<int> years = await api.Wall.GetArchiveYearsAsync(
    ownerId: 1
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **ownerId** <br> `int` | Идентификатор владельца стены (по умолчанию текущий пользователь). |

</div>

<div class="vk-card">

# Результат

Возвращает `List<int>` со списком годов, в которых присутствуют записи архива стены.

</div>
