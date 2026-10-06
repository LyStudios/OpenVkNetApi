<div class="vk-card">

# Объект StoreProduct (Товар магазина)

Представляет товар магазина OpenVK (стикерпак и др.).

</div>

<div class="vk-card">

# Поля объекта

| Поле / Тип | Описание |
| :--- | :--- |
| **Id** <br> `int` | Идентификатор товара. |
| **Type** <br> `string` | Тип товара (`"stickers"`). |
| **Title** <br> `string` | Название товара. |
| **Description** <br> `string` | Описание товара. |
| **Author** <br> `string` | Автор товара. |
| **Price** <br> `int` | Стоимость в голосах (0 — бесплатно). |
| **Purchased** <br> `bool` | Куплен ли товар текущим пользователем. |
| **Active** <br> `bool` | Активирован ли товар. |
| **Photo128** <br> `string` | URL превью 128x128. |
| **Stickers** <br> `List<StickerItem>` | Список стикеров внутри набора. |

</div>
