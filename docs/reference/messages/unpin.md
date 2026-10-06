<div class="vk-card">

# messages.unpin

Открепляет ранее закрепленное сообщение в беседе.

# Вызов метода

```csharp
int result = await api.Messages.UnpinAsync(
    peerId: 2000000001
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **peerId** <br> `int` | Идентификатор назначения (диалога или чата). <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного открепления сообщения.

</div>
