<div class="vk-card">

# captcha.force

Инициирует принудительный ответ проверки капчи со стороны сервера. Используется для отладки и тестирования обработки ошибок капчи в клиентских приложениях.

# Вызов метода

```csharp
var res = await api.Captcha.ForceAsync();
```

</div>

<div class="vk-card">

# Параметры

Метод не принимает обязательных параметров.

</div>

<div class="vk-card">

# Результат

Возвращает `JToken` с ответом сервера или выбрасывает [OvkApiException](/reference/models/api-error) с ошибкой капчи (код 14).

</div>
