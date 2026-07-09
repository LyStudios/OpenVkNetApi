<div class="vk-card">

# audio.getPlaylistById

Возвращает информацию о плейлисте (альбоме) по его идентификатору.

<div class="vk-info">
  <span>💡 Для вызова этого метода не требуется авторизация пользователя (токен необязателен).</span>
</div>

## Вызов метода

```csharp
var playlist = await api.Audio.GetPlaylistByIdAsync(
    ownerId: 1,
    playlistId: 12
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **ownerId** <br> `int` | Идентификатор владельца плейлиста. Для сообщества используйте отрицательное значение. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **playlistId** <br> `int` | Уникальный числовой идентификатор плейлиста. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект плейлиста [Album](/reference/models/audio/album).

</div>
