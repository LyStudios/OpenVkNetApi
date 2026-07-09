<div class="vk-card">

# account.getProfileInfo

Возвращает информацию о текущем профиле пользователя.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var info = await api.Account.GetProfileInfoAsync();
```

</div>

<div class="vk-card">

# Параметры

Метод не принимает параметров запроса.

</div>

<div class="vk-card">

# Результат

Возвращает объект [ProfileInfo](/reference/models/account/profile-info), содержащий информацию о профиле (имя, фамилия, пол, дата рождения, город и др.).

</div>
