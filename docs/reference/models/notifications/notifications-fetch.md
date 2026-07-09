<div class="vk-card">

# Объект NotificationsFetch (Результат получения уведомлений)

Представляет ответ метода `notifications.get` / `notifications.fetch`, содержащий список уведомлений, а также связанные профили пользователей и сообществ.

</div>

<div class="vk-card">

# Поля объекта

| Поле / Тип | Описание |
| :--- | :--- |
| **Items** <br> `List<Notification>` | Список полученных уведомлений [Notification](/reference/models/notifications/notification). |
| **Profiles** <br> `List<ProfileInfo>` | Профили пользователей, действия которых вызвали уведомления. |
| **Groups** <br> `List<Group>` | Профили сообществ, связанных с уведомлениями. |
| **NextLastId** <br> `string` | Временной штамп/идентификатор для пагинации к следующей странице результатов. |
| **NewLastId** <br> `string` | Идентификатор последнего полученного уведомления. |

</div>
