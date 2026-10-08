<div class="vk-card">

# messages.getHistoryAttachments

Возвращает материалы диалога (вложения: фотографии, видео, документы, аудио и ссылки).

# Вызов метода

```csharp
ExtendedCollection<HistoryAttachmentItem> attachments = await api.Messages.GetHistoryAttachmentsAsync(
    peerId: 2000000001,
    mediaType: "photo",
    count: 30
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **peerId** <br> `long` | Идентификатор диалога/беседы. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **mediaType** <br> `string` | Тип искомых вложений (`"photo"`, `"video"`, `"audio"`, `"doc"`, `"link"`, `"market"`). По умолчанию `"photo"`. <br> <span style="color: var(--vp-c-text-3)">строка</span> |
| **startFrom** <br> `string` | Курсор пагинации для получения следующей страницы результатов. <br> <span style="color: var(--vp-c-text-3)">строка</span> |
| **count** <br> `int?` | Количество возвращаемых вложений (по умолчанию 30, максимум 200). <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **photoSizes** <br> `bool?` | Возвращать ли расширенные размеры фотографий. <br> <span style="color: var(--vp-c-text-3)">логическое значение</span> |
| **fields** <br> `string` | Дополнительные поля профилей авторов. <br> <span style="color: var(--vp-c-text-3)">строка</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `ExtendedCollection<HistoryAttachmentItem>`, содержащий список элементов `Items`, профили `Profiles`, группы `Groups` и маркер следующей страницы `NextFrom`.

</div>
