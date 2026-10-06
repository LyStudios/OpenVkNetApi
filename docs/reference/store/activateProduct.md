<div class="vk-card">

# store.activateProduct

Активирует купленный продукт (например, делает набор стикеров активным в быстром доступе).

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
bool success = await api.Store.ActivateProductAsync(
    productId: 10
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **productId** <br> `int` | Идентификатор продукта. |

</div>

<div class="vk-card">

# Результат

Возвращает `bool` (`true` при успешной активации).

</div>
