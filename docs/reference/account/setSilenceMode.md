<div class="vk-card">

# account.setSilenceMode

Управляет режимом «Не беспокоить» (беззвучный режим уведомлений) для устройства или конкретного чата.

<div class="vk-warning">
  <span>💡 Для вызова этого метода требуется авторизация пользователя.</span>
</div>

# Вызов метода

```csharp
int result = await api.Account.SetSilenceModeAsync(
    token: "device_push_token_xyz",
    time: 3600,
    peerId: 2000000001
);
```

</div>

<div class="vk-card">

# Параметры

| Параметр / Тип | Описание |
| :--- | :--- |
| **token** <br> `string` | Токен устройства. <br> <span style="color: var(--vp-c-text-3)">строка, обязательный параметр</span> |
| **deviceId** <br> `string` | Уникальный идентификатор устройства. <br> <span style="color: var(--vp-c-text-3)">строка</span> |
| **time** <br> `int?` | Период тишины в секундах (например, `3600`), `-1` для бессрочного отключения или `0` для снятия режима тишины. <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **peerId** <br> `int?` | Идентификатор диалога/беседы, для которого настраивается режим (если не задан — режим применяется ко всем уведомлениям). <br> <span style="color: var(--vp-c-text-3)">целое число</span> |
| **sound** <br> `int?` | Включать ли звуковое оповещение (`1` — со звуком, `0` — без звука). <br> <span style="color: var(--vp-c-text-3)">целое число</span> |

</div>

<div class="vk-card">

# Результат

Возвращает `1` в случае успешного сохранения параметров.

</div>
