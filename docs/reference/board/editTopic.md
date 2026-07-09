<div class="vk-card">

# board.editTopic

Редактирует заголовок существующей темы обсуждения.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя. Редактировать заголовок могут авторы темы или администраторы сообщества.</span>
</div>

# Вызов метода

```csharp
int result = await api.Board.EditTopicAsync(groupId: 1, topicId: 12, title: "Новое название темы");
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **groupId** <br> `int` | Идентификатор сообщества, в котором находится тема. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **topicId** <br> `int` | Идентификатор редактируемой темы обсуждения. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **title** <br> `string` | Новый заголовок темы обсуждения. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного выполнения.

</div>
