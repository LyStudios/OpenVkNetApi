<div class="vk-card">

# utils.getServerTime

Возвращает текущее время на сервере API инстанса OpenVK.

<div class="vk-info">
  <span>💡 Для вызова этого метода не требуется авторизация пользователя (токен необязателен).</span>
</div>

## Вызов метода

```csharp
long unixTime = await api.Utils.GetServerTimeAsync();
```

</div>

<div class="vk-card">

# Параметры

Метод не принимает параметров запроса.

</div>

<div class="vk-card">

# Результат

Возвращает число типа `long` — текущее время сервера в Unix-формате (количество секунд с начала эпохи).

</div>
