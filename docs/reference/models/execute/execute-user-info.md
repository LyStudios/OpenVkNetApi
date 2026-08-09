<div class="vk-card">

# Объект ExecuteUserInfo (Агрегированные данные пользователя)

Описывает комбинированный ответ метода `execute.getUserInfo`.

</div>

<div class="vk-card">

# Поля объекта

| Поле / Тип | Описание |
| :--- | :--- |
| **Profile** <br> `User` | Полная информация о профиле текущего пользователя. |
| **Info** <br> `AccountInfo` | Основные настройки и параметры аккаунта. |
| **Counters** <br> `AccountCounters` | Счетчики неактивностей (сообщения, друзья, уведомления и др.). |
| **Newsfeed** <br> `ExecuteNewsfeedData` | Первичные данные и таймауты ленты новостей. |
| **Time** <br> `long` | Текущее время сервера в формате Unix time. |
| **AllowBuyVotes** <br> `int` | Разрешена ли покупка голосов/коинов. |
| **ShowHtmlGames** <br> `int` | Отображение HTML-игр. |
| **DefaultAudioPlayer** <br> `string` | Идентификатор аудиоплеера по умолчанию. |

</div>
