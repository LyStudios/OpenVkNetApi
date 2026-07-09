<div class="vk-card">

# account.getOvkSettings

Возвращает специфические для инстанса OpenVK настройки аккаунта.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя. Набор параметров зависит от используемого сервера OpenVK.</span>
</div>

# Вызов метода

```csharp
var settings = await api.Account.GetOvkSettingsAsync();
```

</div>

<div class="vk-card">

# Параметры

Метод не принимает параметров запроса.

</div>

<div class="vk-card">

# Результат

Возвращает объект [AccountOvkSettings](/reference/models/account/account-ovk-settings) со свойствами настроек (например, статус темной темы, параметры приватности или включенные модули OpenVK).

</div>
