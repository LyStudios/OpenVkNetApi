<div class="vk-card">

# account.registerDevice

Регистрирует устройство для отправки Push-уведомлений.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя. Метод используется мобильными и настольными клиентами для регистрации FCM/APNs токенов.</span>
</div>

# Вызов метода

```csharp
int result = await api.Account.RegisterDeviceAsync(
    token: "device_push_token_xyz",
    deviceModel: "Lumia 950",
    systemVersion: "Windows 10 Mobile"
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **token** <br> `string` | Уникальный токен устройства для сервиса push-уведомлений. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **deviceModel** <br> `string` | Модель устройства. <br> <span style="color: var(--vp-c-text-3)">строка</span> |
| **deviceYear** <br> `int?` | Год выпуска устройства. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **deviceId** <br> `string` | Уникальный идентификатор устройства. <br> <span style="color: var(--vp-c-text-3)">строка</span> |
| **systemVersion** <br> `string` | Версия операционной системы. <br> <span style="color: var(--vp-c-text-3)">строка</span> |
| **settings** <br> `string` | Сериализованный JSON с настройками push-уведомлений. <br> <span style="color: var(--vp-c-text-3)">строка</span> |
| **sandbox** <br> `bool?` | Использовать ли тестовый (sandbox) сервер уведомлений. <br> <span style="color: var(--vp-c-text-3)">логическое значение</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешной регистрации устройства.

</div>
