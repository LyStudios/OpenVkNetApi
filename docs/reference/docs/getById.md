<div class="vk-card">

# docs.getById

Возвращает информацию о документах по их уникальным идентификаторам.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var docsList = await api.Docs.GetByIdAsync(docs: "1_456239012,2_456239013", returnTags: true);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **docs** <br> `string` | Идентификаторы документов в формате `owner_id_doc_id`, разделенные запятыми (например, `1_456,2_789`). <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **returnTags** <br> `bool` | Возвращать ли теги документов. <br> <span style="color: var(--vp-c-text-3)">логический тип, по умолчанию: false</span> |

</div>

<div class="vk-card">

# Результат

Возвращает список `List<Doc>`, содержащий объекты [Doc](/reference/models/docs/doc).

</div>
