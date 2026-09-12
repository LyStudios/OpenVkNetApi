<div class="vk-card">

# Объект ApiError (Ошибка API)

Представляет собой модель ошибки, возвращаемую сервером OpenVK в случае неуспешного запроса.

</div>

<div class="vk-card">

# Поля объекта

| Поле / Тип | Описание |
| :--- | :--- |
| **ErrorCode** <br> `int` | Числовой код ошибки API. |
| **ErrorMessage** <br> `string` | Сообщение с описанием причины возникновения ошибки. |
| **Error** <br> `string` | Строковый код ошибки авторизации / OAuth / 2FA (например, `need_validation`, `invalid_grant`). |
| **ErrorDescription** <br> `string` | Текстовое описание ошибки авторизации или 2FA (например, `use app code`). |
| **RequestParams** <br> `object` | Параметры запроса, которые привели к ошибке. |

</div>
