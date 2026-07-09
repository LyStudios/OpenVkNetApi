<div class="vk-card">

# audio.delete

Удаляет аудиозапись из коллекции пользователя или сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
int result = await api.Audio.DeleteAsync(
    audioId: 456,
    ownerId: 1
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **audioId** <br> `int` | Идентификатор удаляемой аудиозаписи. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **ownerId** <br> `int` | Идентификатор владельца аудиозаписи. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **groupId** <br> `int?` | Идентификатор сообщества, если аудиозапись удаляется из группы. <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного удаления.

</div>
