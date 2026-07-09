<div class="vk-card">

# account.getInfo

Возвращает настройки текущего аккаунта.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var info = await api.Account.GetInfoAsync();
```

</div>

<div class="vk-card">

# Параметры

Метод не принимает параметров запроса.

</div>

<div class="vk-card">

# Результат

Возвращает объект [AccountInfo](/reference/models/account/account-info), содержащий настройки аккаунта (страна, язык, статус двухфакторной аутентификации и др.).

</div>
