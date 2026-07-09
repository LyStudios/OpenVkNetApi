<div class="vk-card">

# ovk.test

Тестовый метод для проверки доступности API и состояния авторизации.

<div class="vk-info">
  <span>💡 Для вызова этого метода не требуется авторизация пользователя (токен необязателен).</span>
</div>

## Вызов метода

```csharp
var testResult = await api.Ovk.TestAsync();
```

</div>

<div class="vk-card">

# Параметры

Метод не принимает параметров.

</div>

<div class="vk-card">

# Результат

Возвращает объект [OvkTest](/reference/models/ovk/ovk-test), содержащий статус авторизации, метод авторизации и версию API.

</div>
