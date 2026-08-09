<div class="vk-card">

# execute

Выполняет произвольный скрипт на языке VKScript на стороне сервера OpenVK.

## Вызов метода

```csharp
// Типизированный вызов:
var result = await api.Execute.ExecuteAsync<List<User>>("return API.users.get({'user_ids': 1});");

// Сырой вызов JToken:
var jsonResult = await api.Execute.ExecuteAsync("return { 'time': API.utils.getServerTime() };");
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **code** <br> `string` | **Обязательный.** Исполняемый код на языке VKScript. |

</div>

<div class="vk-card">

# Результат

Возвращает результат выполнения VKScript, десериализованный в тип `T` или в `Newtonsoft.Json.Linq.JToken`.

</div>
