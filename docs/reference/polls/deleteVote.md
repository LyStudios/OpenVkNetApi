<div class="vk-card">

# polls.deleteVote

Снимает голос текущего пользователя с опроса.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
int result = await api.Polls.DeleteVoteAsync(pollId: 45);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **pollId** <br> `int` | Идентификатор опроса, с которого нужно снять голос. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного удаления голоса, иначе `0`.

</div>
