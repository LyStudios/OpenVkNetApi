<div class="vk-card">

# photos.delete

Удаляет одну или несколько фотографий.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
int result = await api.Photos.DeleteAsync(
    ownerId: 1,
    photoId: 123
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **ownerId** <br> `int?` | Идентификатор владельца фотографии. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: текущий пользователь</span> |
| **photoId** <br> `int?` | Идентификатор фотографии (для удаления одной фотографии). <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **photos** <br> `string` | Список идентификаторов фотографий через запятую (для удаления нескольких фотографий). <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного удаления.

</div>
