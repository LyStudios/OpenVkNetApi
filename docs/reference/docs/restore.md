<div class="vk-card">

# docs.restore

Восстанавливает ранее удаленный документ.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя. Восстановление возможно только в течение некоторого времени после удаления.</span>
</div>

# Вызов метода

```csharp
int result = await api.Docs.RestoreAsync(ownerId: 1, docId: 456239012);
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

Возвращает `1` в случае успешного восстановления.

</div>
