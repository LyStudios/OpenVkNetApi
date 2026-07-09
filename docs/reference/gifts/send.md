<div class="vk-card">

# gifts.send

Отправляет подарок одному или нескольким пользователям.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя. Отправка платных подарков списывает голоса с баланса аккаунта.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Gifts;

var parameters = new GiftsSendParams
{
    UserIds = "1,2",
    GiftId = 45,
    Message = "С днём рождения!",
    Privacy = 0 // Подарок увидят все
};

var sendResult = await api.Gifts.SendAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `GiftsSendParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **UserIds** <br> `string` | Идентификаторы получателей подарка, разделенные запятыми. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **GiftId** <br> `int` | Уникальный идентификатор подарка из каталога. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **Message** <br> `string` | Текст сообщения, прикрепляемого к подарку. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Privacy** <br> `int` | Приватность подарка: `0` — имя отправителя и сообщение видны всем; `1` — имя отправителя и сообщение видны только получателю; `2` — имя отправителя скрыто от всех (анонимный подарок). <br> <span style="color: var(--vp-c-text-3)">целое число, по умолчанию: 0</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [GiftsSend](/reference/models/gifts/gifts-send), содержащий информацию об успешности перевода и списке транзакций.

</div>
