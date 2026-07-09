<div class="vk-card">

# docs.add

Добавляет документ в коллекцию пользователя или сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
string addedDocId = await api.Docs.AddAsync(ownerId: 1, docId: 456239012, accessKey: "abcdf1234");
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **ownerId** <br> `int` | Идентификатор владельца документа. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **docId** <br> `int` | Идентификатор документа. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **accessKey** <br> `string` | Ключ доступа к документу (требуется, если документ приватный). <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает уникальный идентификатор добавленного документа (`string`).

</div>
