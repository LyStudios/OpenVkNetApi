<div class="vk-card">

# audio.getById

Возвращает информацию об аудиозаписях по их идентификаторам.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
var audios = await api.Audio.GetByIdAsync(
    audios: "1_456,1_789",
    needUser: true
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **audios** <br> `string` | Идентификаторы аудиозаписей, разделенные запятыми, в формате `owner_id_audio_id`. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **hash** <br> `string` | Специфический хеш безопасности для доступа. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **needUser** <br> `bool` | Возвращать ли профили пользователей, загрузивших эти аудиозаписи. <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<Audio>` с объектами аудиозаписей [Audio](/reference/models/audio/audio).

</div>
