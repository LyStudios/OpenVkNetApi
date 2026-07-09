<div class="vk-card">

# docs.getWallUploadServer

Возвращает адрес сервера для загрузки документа, который планируется прикрепить к записи на стене.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
int uploadServerId = await api.Docs.GetWallUploadServerAsync(groupId: null);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **groupId** <br> `int?` | Идентификатор сообщества (если документ загружается на стену сообщества). <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает идентификатор сервера для загрузки файла (`int`).

</div>
