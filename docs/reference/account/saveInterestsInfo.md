<div class="vk-card">

# account.saveInterestsInfo

Редактирует информацию об интересах и увлечениях текущего пользователя.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Account;

var parameters = new SaveInterestsInfoParams
{
    Music = "Рок, Электроника",
    Games = "RPG, Стратегии",
    About = "Разработчик на C#"
};

var result = await api.Account.SaveInterestsInfoAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `SaveInterestsInfoParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **Activities** <br> `string` | Деятельность пользователя. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Interests** <br> `string` | Интересы пользователя. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Music** <br> `string` | Любимая музыка. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Movies** <br> `string` | Любимые фильмы. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Tv** <br> `string` | Любимые телепередачи. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Books** <br> `string` | Любимые книги. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Games** <br> `string` | Любимые игры. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Quotes** <br> `string` | Любимые цитаты. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **About** <br> `string` | Информация «О себе». <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает объект [AccountSaveInterests](/reference/models/account/account-save-interests), содержащий статус сохранения изменений.

</div>
