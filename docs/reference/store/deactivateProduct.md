<div class="vk-card">

# store.deactivateProduct

Деактивирует купленный продукт (скрывает набор из панели быстрого доступа).

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
bool success = await api.Store.DeactivateProductAsync(
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

Возвращает `bool` (`true` при успешной деактивации).

</div>
