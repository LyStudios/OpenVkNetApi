<div class="vk-card">

# messages.delete

Удаляет одно или несколько сообщений из диалогов.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя. Удаленные сообщения можно восстановить методом `restore` до обновления страницы.</span>
</div>

# Вызов метода

```csharp
var deleteResult = await api.Messages.DeleteAsync(messageIds: "12,13", spam: false, deleteForAll: true);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **messageIds** <br> `string` | Список идентификаторов сообщений, разделенных запятыми. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **spam** <br> `bool` | Пометить ли сообщения как спам (доступно при входящих сообщениях). <br> <span style="color: var(--vp-c-text-3)">логический тип, по умолчанию: false</span> |
| **deleteForAll** <br> `bool` | Удалить ли сообщения также и для собеседников (работает в беседе или ЛС, если не истек срок редактирования). <br> <span style="color: var(--vp-c-text-3)">логический тип, по умолчанию: false</span> |

</div>

<div class="vk-card">

# Результат

Возвращает словарь `Dictionary<string, int>`, где ключом является ID сообщения, а значением — статус удаления (`1` — успешно удалено).

</div>
