<div class="vk-card">

# friends.getMutual

Возвращает список общих друзей между пользователями.

# Вызов метода

```csharp
List<int> mutual = await api.Friends.GetMutualAsync(
    targetUid: 2
);
```

Также доступна перегрузка для получения общих друзей по нескольким пользователям:

```csharp
List<MutualFriends> mutualList = await api.Friends.GetMutualAsync(
    targetUids: new[] { 2, 3, 4 }
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **targetUid** <br> `int` | ID целевого пользователя. |
| **sourceUid** <br> `int` | ID пользователя, чьи друзья сравниваются (по умолчанию текущий). |
| **targetUids** <br> `IEnumerable<int>` | Коллекция ID пользователей. |
| **order** <br> `string` | Порядок сортировки. |
| **count** <br> `int` | Количество записей. |
| **offset** <br> `int` | Смещение. |

</div>

<div class="vk-card">

# Результат

При запросе для одного пользователя возвращает `List<int>` с идентификаторами общих друзей. При запросе коллекции пользователей возвращает `List<MutualFriends>`.

</div>
