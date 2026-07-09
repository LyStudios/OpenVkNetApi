<div class="vk-card">

# docs.save

Сохраняет документ после его успешной загрузки на сервер.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя. Метод вызывается после выполнения POST-запроса с файлом на URL сервера загрузки.</span>
</div>

# Вызов метода

```csharp
using OpenVkNetApi.Models.RequestParameters.Docs;

var parameters = new DocsSaveParams
{
    File = "uploaded_file_string",
    Title = "Документ.pdf",
    Tags = "документы, пдф"
};

int savedDocId = await api.Docs.SaveAsync(parameters);
```

</div>

<div class="vk-card">

# Параметры

Принимает объект `DocsSaveParams` со следующими свойствами:

| Параметр / Тип | Описание |
| :--- | :--- |
| **File** <br> `string` | Строка, полученная в результате загрузки файла на сервер. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **Title** <br> `string` | Название (заголовок) документа. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |
| **Tags** <br> `string` | Теги для поиска документа, разделенные запятыми. <br> <span style="color: var(--vp-c-text-3)">строка, необязательный параметр</span> |

</div>

<div class="vk-card">

# Результат

Возвращает уникальный идентификатор сохраненного документа (`int`).

</div>
