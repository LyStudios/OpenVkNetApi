<div class="vk-card">

# store.getStickersKeywords

Возвращает словарь ключевых слов и эмодзи для мгновенных подсказок стикеров при вводе текста в чате.

# Вызов метода

```csharp
var keywords = await api.Store.GetStickersKeywordsAsync(
    aliases: true,
    allProducts: true,
    needStickers: true
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **aliases** <br> `bool` | Подключать ли синонимы слов. |
| **allProducts** <br> `bool` | Использовать ли ключевые слова для всех доступных наборов. |
| **needStickers** <br> `bool` | Прикреплять ли объекты стикеров к результату. |
| **count** <br> `int` | Максимальное количество результатов. |
| **userId** <br> `int` | Идентификатор пользователя. |

</div>

<div class="vk-card">

# Результат

Возвращает объект [StickersKeywords](/reference/models/stickers/stickers-keywords) с группами ключевых слов и привязанными стикерами.

</div>
