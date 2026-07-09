<div class="vk-card">

# wall.post

Публикует новую запись на стене пользователя или сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Wall;

var parameters = new WallPostParams
{
    Message = "Привет, OpenVK!",
    OwnerId = 12
};

var result = await api.Wall.PostAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `WallPostParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **OwnerId** <br> `int?` | Идентификатор владельца стены, на которой публикуется запись. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: текущий пользователь</span> |
| **FriendsOnly** <br> `bool` | Публиковать ли запись только для друзей (при публикации на своей стене). <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |
| **FromGroup** <br> `bool` | Публиковать ли запись от имени сообщества (при публикации на стене группы). <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |
| **Message** <br> `string` | Текст публикации. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр (если нет вложений)</span> |
| **Attachments** <br> `string` | Список вложений в формате `typeowner_id_media_id`. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Services** <br> `string` | Список сервисов для экспорта. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Signed** <br> `bool` | Подписывать ли автора публикации (при публикации от имени сообщества). <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |
| **PublishDate** <br> `long?` | Время отложенной публикации записи в формате Unix-time. <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **MarkAsAds** <br> `bool` | Помечать ли публикацию как рекламу. <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект `WallPostId`, содержащий уникальный числовой идентификатор созданной записи в поле `PostId`.

</div>
