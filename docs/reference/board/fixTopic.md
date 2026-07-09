<div class="vk-card">

# board.fixTopic

Закрепляет тему обсуждения в самом верху списка тем сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя. Метод доступен только модераторам и администраторам сообщества.</span>
</div>

# Вызов метода

```csharp
int result = await api.Board.FixTopicAsync(groupId: 1, topicId: 12);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **groupId** <br> `int` | Идентификатор сообщества, в котором находится тема. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **topicId** <br> `int` | Идентификатор закрепляемой темы. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного выполнения.

</div>
