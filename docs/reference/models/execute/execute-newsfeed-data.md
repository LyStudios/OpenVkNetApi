<div class="vk-card">

# Объект ExecuteNewsfeedData (Данные новостной ленты)

Описывает блок новостной ленты в составе ответа `execute.getUserInfo`.

</div>

<div class="vk-card">

# Поля объекта

| Поле / Тип | Описание |
| :--- | :--- |
| **FeedType** <br> `string` | Тип ленты (например, `"top"`). |
| **RefreshTimeoutRecent** <br> `int` | Интервал обновления свежих новостей в миллисекундах. |
| **RefreshTimeoutTop** <br> `int` | Интервал обновления топовых новостей в миллисекундах. |
| **RefreshTimeoutRecommended** <br> `int` | Интервал обновления рекомендаций в миллисекундах. |
| **Items** <br> `List<Post>` | Список записей на стене. |
| **Profiles** <br> `List<User>` | Профили пользователей, упомянутых в новостях. |
| **Groups** <br> `List<Group>` | Сообщества, упомянутые в новостях. |

</div>
