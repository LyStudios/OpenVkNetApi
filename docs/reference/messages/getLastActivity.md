<div class="vk-card">

# messages.getLastActivity

Возвращает информацию о последней активности пользователя (онлайн/оффлайн статус и время последнего визита).

# Вызов метода

```csharp
UserLastActivity activity = await api.Messages.GetLastActivityAsync(
    userId: 1
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **userId** <br> `long` | Идентификатор пользователя. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект `UserLastActivity`, содержащий флаг `Online` (`1` — в сети, `0` — оффлайн) и Unix timestamp `Time`.

</div>
