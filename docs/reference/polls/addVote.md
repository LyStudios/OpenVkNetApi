<div class="vk-card">

# polls.addVote

Отдает голос текущего пользователя за выбранные варианты ответа в опросе.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
int result = await api.Polls.AddVoteAsync(
    pollId: 45,
    answerIds: new[] { 101, 102 }
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **pollId** <br> `int` | Идентификатор опроса. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **answerIds** <br> `IEnumerable<int>` | Идентификаторы выбранных вариантов ответа. <br> <span style="color: var(--vp-c-text-3)">список целых чисел, обязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного сохранения голоса, иначе `0`.

</div>
