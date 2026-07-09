<div class="vk-card">

# docs.delete

Удаляет документ из коллекции пользователя или сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя. Пользователь должен иметь права на удаление этого документа.</span>
</div>

# Вызов метода

```csharp
int result = await api.Docs.DeleteAsync(ownerId: 1, docId: 456239012);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **ownerId** <br> `int` | Идентификатор владельца документа. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **docId** <br> `int` | Идентификатор документа. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного удаления.

</div>
