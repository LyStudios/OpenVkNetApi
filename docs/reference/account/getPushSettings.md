<div class="vk-card">

# account.getPushSettings

Возвращает настройки push-уведомлений для текущего устройства или аккаунта.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var pushSettings = await api.Account.GetPushSettingsAsync(
    deviceId: "device_token_xyz"
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **deviceId** <br> `string` | Идентификатор устройства для push-уведомлений. |

</div>

<div class="vk-card">

# Результат

Возвращает [AccountPushSettings](/reference/models/account/account-push-settings) с флагами включенных категорий уведомлений.

</div>
