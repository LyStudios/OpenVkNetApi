<div class="vk-card">

# groups.getSettings

Возвращает детальные настройки и приватность разделов указанного сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя с правами модератора или администратора в сообществе.</span>
</div>

# Вызов метода

```csharp
var settings = await api.Groups.GetSettingsAsync(groupId: "12");
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **groupId** <br> `string` | Идентификатор сообщества. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [GroupSettings](/reference/models/groups/group-settings), содержащий настройки приватности разделов (стена, фото, аудио, обсуждения и др.).

</div>
