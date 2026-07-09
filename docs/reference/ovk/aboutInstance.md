<div class="vk-card">

# ovk.aboutInstance

Возвращает подробную информацию и статистику о текущем инстансе OpenVK.

<div class="vk-info">
  <span>💡 Для вызова этого метода не требуется авторизация пользователя (токен необязателен).</span>
</div>

## Вызов метода

```csharp
using OpenVkNetApi.Models.Enums;

var info = await api.Ovk.AboutInstanceAsync(
    fields: OvkInstanceFields.Statistics | OvkInstanceFields.Links,
    adminFields: UserFields.FirstName | UserFields.LastName,
    groupFields: GroupFields.None
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **fields** <br> `OvkInstanceFields` | Битовые флаги для выбора возвращаемых полей инстанса (статистика, ссылки, администраторы, популярные сообщества). <br> <span style="color: var(--vp-c-text-3)">перечисление флагов, по умолчанию: None</span> |
| **adminFields** <br> `UserFields` | Дополнительные поля профилей администраторов, если они запрашиваются. <br> <span style="color: var(--vp-c-text-3)">перечисление флагов, по умолчанию: None</span> |
| **groupFields** <br> `GroupFields` | Дополнительные поля профилей сообществ, если они запрашиваются. <br> <span style="color: var(--vp-c-text-3)">перечисление флагов, по умолчанию: None</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [OvkAboutInstance](/reference/models/ovk/ovk-about-instance), содержащий запрошенную информацию о текущем инстансе OpenVK.

</div>
