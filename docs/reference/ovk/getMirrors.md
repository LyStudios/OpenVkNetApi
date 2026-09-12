<div class="vk-card">

# ovk.getMirrors

Возвращает список действующих доменов-зеркал текущего инстанса OpenVK.

<div class="vk-info">
  <span>💡 Для вызова этого метода не требуется авторизация пользователя.</span>
</div>

## Вызов метода

```csharp
List<string> mirrors = await api.Ovk.GetMirrorsAsync();
```

</div>

<div class="vk-card">

# Параметры

Метод не принимает параметров.

</div>

<div class="vk-card">

# Результат

Возвращает список строк (`List<string>`) с адресами зеркал инстанса (например, `["ovk.to", "openvk.su"]`).

</div>
