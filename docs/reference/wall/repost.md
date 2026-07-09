<div class="vk-card">

# wall.repost

Создает копию (репост) объекта (записи, фотографии, видео и др.) на стене пользователя или сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Wall;

var parameters = new WallRepostParams
{
    Object = "wall1_100",
    Message = "Рекомендую к прочтению!"
};

var result = await api.Wall.RepostAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `WallRepostParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **Object** <br> `string` | Идентификатор репостимого объекта в формате `typeowner_id_media_id` (например, `wall1_100`). <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **Message** <br> `string` | Сопроводительный текст к репосту (комментарий пользователя). <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **GroupId** <br> `int?` | Идентификатор сообщества, если репост нужно сделать на стену сообщества. <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0 (репост на личную стену)</span> |
| **MarkAsAds** <br> `bool` | Помечать ли репост как рекламу. <br> <span style="color: var(--vp-c-text-3)">логическое значение, по умолчанию: false</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект `WallRepost`, содержащий количество репостов (`RepostsCount`), количество лайков (`LikesCount`) и идентификатор созданного репоста (`PostId`).

</div>
