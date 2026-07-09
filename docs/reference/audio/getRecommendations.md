<div class="vk-card">

# audio.getRecommendations

Возвращает список рекомендованных аудиозаписей для пользователя.

<div class="vk-info">
  <span>💡 Для вызова этого метода не требуется авторизация пользователя (токен необязателен).</span>
</div>

## Вызов метода

```csharp
var recommendations = await api.Audio.GetRecommendationsAsync();
```

</div>

<div class="vk-card">

# Параметры

Метод не принимает параметров.

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<Audio>` с объектами аудиозаписей [Audio](/reference/models/audio/audio). На данный момент метод может возвращать пустой список, если функция не реализована на сервере инстанса.

</div>
