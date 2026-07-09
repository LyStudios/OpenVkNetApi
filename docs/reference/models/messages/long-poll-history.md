<div class="vk-card">

# Объект LongPollHistory (История Long Poll)

Представляет ответ метода `messages.getLongPollHistory`, содержащий список событий и новых сообщений с момента последнего запроса.

</div>

<div class="vk-card">

# Поля объекта

| Поле / Тип | Описание |
| :--- | :--- |
| **History** <br> `List<object>` | Список сырых событий истории от Long Poll сервера. |
| **Messages** <br> `Collection<Message>` | Коллекция новых сообщений, полученных за данный период. |
| **Profiles** <br> `List<User>` | Профили пользователей, связанных с полученными событиями. |
| **NewPts** <br> `int` | Новое значение `pts` для использования в следующем запросе `getLongPollHistory`. |

</div>
