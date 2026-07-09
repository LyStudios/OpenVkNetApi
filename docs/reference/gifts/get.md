<div class="vk-card">

# gifts.get

Возвращает список полученных пользователем подарков.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
var giftsCollection = await api.Gifts.GetAsync(userId: 1, count: 10, offset: 0);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **userId** <br> `int` | Идентификатор пользователя, список подарков которого нужно получить. Если передать `0`, возвращаются подарки текущего пользователя. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |
| **count** <br> `int` | Количество возвращаемых подарков. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 10</span> |
| **offset** <br> `int` | Смещение для выборки определенного подмножества подарков. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |

</div>

<div class="vk-card">

# Результат

Возвращает коллекцию `Collection<UserGift>`, содержащую список объектов [UserGift](/reference/models/gifts/user-gift).

</div>
