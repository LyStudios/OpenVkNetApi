<div class="vk-card">

# users.report

Отправляет жалобу на пользователя.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
int result = await api.Users.ReportAsync(
    userId: 12,
    type: "spam",
    comment: "Рассылка нежелательной рекламы в личные сообщения"
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **userId** <br> `int` | Идентификатор пользователя, на которого отправляется жалоба. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **type** <br> `string` | Тип жалобы (например, `spam`, `abuse`). <br> <span style="color: var(--vp-c-text-3)">строка, по умолчанию: "spam"</span> |
| **comment** <br> `string` | Дополнительный комментарий к жалобе. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного отправления жалобы.

</div>
