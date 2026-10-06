<div class="vk-card">

# places.getCheckins

Возвращает список отметок пользователей (чекинов) в местах.

# Вызов метода

```csharp
Collection<Checkin> checkins = await api.Places.GetCheckinsAsync(
    latitude: 55.7558,
    longitude: 37.6173,
    count: 20
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **latitude** <br> `double?` | Географическая широта точки. <br> <span style="color: var(--vp-c-text-3)">дробное число</span> |
| **longitude** <br> `double?` | Географическая долгота точки. <br> <span style="color: var(--vp-c-text-3)">дробное число</span> |
| **place** <br> `int?` | Идентификатор конкретного места. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **userId** <br> `int?` | Идентификатор пользователя, чьи чекины необходимо получить. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **offset** <br> `int?` | Смещение относительно начала списка. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **count** <br> `int?` | Количество возвращаемых отметок (по умолчанию 20, максимум 100). <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **timestamp** <br> `long?` | Время чекина, не позднее которого они были сделаны. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **friendsOnly** <br> `bool?` | Учитывать только чекины друзей. <br> <span style="color: var(--vp-c-text-3)">логическое значение</span> |
| **needPlaces** <br> `bool?` | Возвращать ли информацию о самих местах. <br> <span style="color: var(--vp-c-text-3)">логическое значение</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект `Collection<Checkin>`, содержащий количество элементов `Count` и список отметок `Items`.

</div>
