<div class="vk-card">

# execute.procedure

Выполняет сохраненную серверную процедуру OpenVK (хранимый скрипт из каталога `VKAPI/Procedures`, например `getNewsfeedSmart` или `getProfiles`).

## Вызов метода

```csharp
var result = await api.Execute.ProcedureAsync<JToken>("getNewsfeedSmart", new { count = 20 });
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **procedureName** <br> `string` | **Обязательный.** Имя хранимой процедуры (без расширения `.vks`). |
| **parameters** <br> `object` | Необязательный. Объект параметров или словарь с аргументами для процедуры. |

</div>

<div class="vk-card">

# Результат

Возвращает результат выполнения процедуры, десериализованный в тип `T`.

</div>
