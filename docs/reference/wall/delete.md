<div class="vk-card">

# wall.delete

Удаляет запись со стены пользователя или сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
int result = await api.Wall.DeleteAsync(
    ownerId: 1,
    postId: 123
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **ownerId** <br> `int` | Идентификатор владельца стены. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **postId** <br> `int` | Идентификатор удаляемой записи. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного удаления записи.

</div>
