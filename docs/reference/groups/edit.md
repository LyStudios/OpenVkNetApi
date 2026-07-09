<div class="vk-card">

# groups.edit

Редактирует основную информацию и настройки сообщества.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя с правами администратора или создателя в редактируемом сообществе.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Groups;

var parameters = new GroupsEditParams
{
    GroupId = 12,
    Title = "Новое название сообщества",
    Description = "Обновленное описание сообщества"
};

int result = await api.Groups.EditAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `GroupsEditParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **GroupId** <br> `int` | Идентификатор сообщества. <br> <span style="color: var(--vp-c-text-3)">целое число, обязательный параметр</span> |
| **Title** <br> `string` | Заголовок (название) сообщества. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Description** <br> `string` | Описание сообщества. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Access** <br> `int?` | Тип доступа (0 — открытая, 1 — закрытая, 2 — частная). <br> <span style="color: var(--vp-c-text-3)">целое число, необязательный параметр</span> |
| **Website** <br> `string` | Адрес официального сайта сообщества. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного изменения настроек.

</div>
