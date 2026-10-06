<div class="vk-card">

# messages.getImportantMessages

Возвращает список сообщений, помеченных пользователем как важные.

# Вызов метода

```csharp
Collection<Message> important = await api.Messages.GetImportantMessagesAsync(
    count: 20,
    offset: 0
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **count** <br> `int?` | Количество сообщений для возврата (по умолчанию 20). <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **offset** <br> `int?` | Смещение относительно начала списка. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **startMessageId** <br> `int?` | Идентификатор сообщения, начиная с которого возвращаются записи. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **previewLength** <br> `int?` | Количество символов для предпросмотра текста сообщений. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **extended** <br> `bool?` | Возвращать ли расширенные данные. <br> <span style="color: var(--vp-c-text-3)">логическое значение</span> |
| **fields** <br> `string` | Дополнительные поля профилей пользователей. <br> <span style="color: var(--vp-c-text-3)">строка</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `Collection<Message>`, содержащий количество и список важных сообщений.

</div>
