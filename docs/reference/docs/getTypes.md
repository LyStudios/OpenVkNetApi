<div class="vk-card">

# docs.getTypes

Возвращает список доступных типов документов для указанного пользователя или сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var docTypes = await api.Docs.GetTypesAsync(ownerId: 1);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **ownerId** <br> `int?` | Идентификатор владельца документов (если не передан, используется ID текущего пользователя). <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<DocType>`, содержащую список объектов [DocType](/reference/models/docs/doc-type).

</div>
