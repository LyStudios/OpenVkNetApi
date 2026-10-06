<div class="vk-card">

# account.getToggles

Возвращает конфигурацию фиче-тогглов (feature flags) и экспериментальных функций для пользователя.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var toggles = await api.Account.GetTogglesAsync();
```

</div>

<div class="vk-card">

# Параметры

Метод не принимает параметров.

</div>

<div class="vk-card">

# Результат

Возвращает [AccountToggles](/reference/models/account/account-toggles) со списком переключателей возможностей.

</div>
