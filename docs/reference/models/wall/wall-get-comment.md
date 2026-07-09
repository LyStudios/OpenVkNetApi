<div class="vk-card">

# Объект WallGetComment (Результат получения комментария)

Содержит информацию об одном или нескольких комментариях, полученных по конкретному запросу.

</div>

<div class="vk-card">

# Поля объекта

| Поле / Тип | Описание |
| :--- | :--- |
| **Items** <br> `List<WallComment>` | Список комментариев [WallComment](/reference/models/comments/wall-comment). |
| **CanPost** <br> `bool` | Может ли текущий пользователь комментировать эту запись. |
| **ShowReplyButton** <br> `bool` | Нужно ли показывать кнопку ответа. |
| **GroupsCanPost** <br> `bool` | Могут ли сообщества оставлять комментарии здесь. |
| **Profiles** <br> `List<ProfileInfo>` | Профили пользователей-авторов комментариев. |

</div>
