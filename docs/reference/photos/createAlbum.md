<div class="vk-card">

# photos.createAlbum

Создает новый пустой фотоальбом.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
var newAlbum = await api.Photos.CreateAlbumAsync(
    title: "Мой новый альбом",
    groupId: 0,
    description: "Описание альбома"
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **title** <br> `string` | Название фотоальбома. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **groupId** <br> `int` | Идентификатор сообщества, если альбом создается в сообществе. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **description** <br> `string` | Текстовое описание альбома. <br> <span style="color: var(--vp-c-text-3)">строка, по умолчанию: пустая</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект созданного альбома [Album](/reference/models/photos/album).

</div>
