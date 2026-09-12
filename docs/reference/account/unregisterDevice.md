<div class="vk-card">

# account.unregisterDevice

Отменяет регистрацию устройства для отправки Push-уведомлений.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя. Метод следует вызывать при выходе из учетной записи на устройстве.</span>
</div>

# Вызов метода

```csharp
int result = await api.Account.UnregisterDeviceAsync(
    token: "device_push_token_xyz"
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **token** <br> `string` | Токен устройства, для которого отменяется регистрация. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **deviceId** <br> `string` | Уникальный идентификатор устройства. <br> <span style="color: var(--vp-c-text-3)">строка</span> |
| **sandbox** <br> `bool?` | Был ли токен зарегистрирован для sandbox-окружения. <br> <span style="color: var(--vp-c-text-3)">логическое значение</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешной отмены регистрации.

</div>
