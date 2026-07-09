<div class="vk-card">

# audio.add

Добавляет аудиозапись в коллекцию пользователя или сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Audio;

var parameters = new AudioAddParams
{
    AudioId = 456,
    OwnerId = 1
};

string newAudioId = await api.Audio.AddAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `AudioAddParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **AudioId** <br> `int` | Идентификатор добавляемой аудиозаписи. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **OwnerId** <br> `int` | Идентификатор владельца аудиозаписи. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **GroupId** <br> `int?` | Идентификатор сообщества, если аудиозапись добавляется в сообщество. <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает строку (`string`) — идентификатор добавленной аудиозаписи.

</div>
