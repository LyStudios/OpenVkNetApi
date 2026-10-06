<div class="vk-card">

# messages.search

Осуществляет полнотекстовый поиск по сообщениям текущего пользователя.

# Вызов метода

```csharp
Collection<Message> results = await api.Messages.SearchAsync(
    q: "важный проект",
    count: 20
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **q** <br> `string` | Поисковая строка. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **peerId** <br> `int?` | Идентификатор диалога/беседы для ограничения поиска. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **date** <br> `long?` | Дата, не позднее которой должны быть найдены сообщения. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **previewLength** <br> `int?` | Количество символов для предпросмотра найденного сообщения. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **offset** <br> `int?` | Смещение относительно начала списка найденных сообщений. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **count** <br> `int?` | Количество возвращаемых результатов (по умолчанию 20). <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **extended** <br> `bool?` | Возвращать ли дополнительную информацию о собеседниках. <br> <span style="color: var(--vp-c-text-3)">логическое значение</span> |
| **fields** <br> `string` | Дополнительные поля профилей через запятую. <br> <span style="color: var(--vp-c-text-3)">строка</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `Collection<Message>`, содержащий количество совпадений и список сообщений.

</div>
