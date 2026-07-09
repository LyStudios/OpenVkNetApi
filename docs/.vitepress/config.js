import fs from 'fs';
import path from 'path';
import { fileURLToPath } from 'url';

const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);

function getSidebarItems(folder, prefix = '') {
  const dirPath = path.resolve(__dirname, '..', folder);
  if (!fs.existsSync(dirPath)) return [];

  return fs.readdirSync(dirPath)
    .filter(file => file.endsWith('.md') && file !== 'index.md')
    .map(file => {
      const name = file.replace('.md', '');
      const filePath = path.join(dirPath, file);
      let text = prefix + name;

      try {
        const content = fs.readFileSync(filePath, 'utf-8');
        const match = content.match(/^#\s+(.+)$/m);
        if (match && match[1]) {
          text = match[1].trim();
        }
      } catch (e) { }

      return {
        text,
        link: `/${folder}/${name}`
      };
    })
    .sort((a, b) => a.text.localeCompare(b.text));
}

export default {
  title: 'OpenVkNetApi',
  description: 'Документация C# библиотеки для OpenVK API',
  lang: 'ru-RU',
  base: '/OpenVkNetApi/',
  ignoreDeadLinks: true,

  themeConfig: {
    aside: false,
    logo: '/logo.svg',
    docFooter: {
      prev: false,
      next: false
    },
    nav: [
      { text: 'Руководство', link: '/guide/getting-started' },
      { text: 'NuGet', link: 'https://www.nuget.org/packages/OpenVkNetApi/' },
      { text: 'GitHub', link: 'https://github.com/LyStudios/OpenVkNetApi' }
    ],
    sidebar: [
      {
        text: 'Начало работы',
        items: [
          { text: 'Введение', link: '/guide/getting-started' },
          { text: 'Авторизация', link: '/guide/authentication' },
          { text: 'Long Poll (События)', link: '/guide/long-poll' },
          { text: 'Аудио (Музыка)', link: '/guide/audio' }
        ]
      },
      {
        text: 'Методы API',
        items: [
          {
            text: 'Аккаунт (Account)',
            collapsed: true,
            items: getSidebarItems('reference/account', 'account.')
          },
          {
            text: 'Аудиозаписи (Audio)',
            collapsed: true,
            items: getSidebarItems('reference/audio', 'audio.')
          },
          {
            text: 'Обсуждения (Board)',
            collapsed: true,
            items: getSidebarItems('reference/board', 'board.')
          },
          {
            text: 'Документы (Docs)',
            collapsed: true,
            items: getSidebarItems('reference/docs', 'docs.')
          },
          {
            text: 'Друзья (Friends)',
            collapsed: true,
            items: getSidebarItems('reference/friends', 'friends.')
          },
          {
            text: 'Подарки (Gifts)',
            collapsed: true,
            items: getSidebarItems('reference/gifts', 'gifts.')
          },
          {
            text: 'Сообщества (Groups)',
            collapsed: true,
            items: getSidebarItems('reference/groups', 'groups.')
          },
          {
            text: 'Лайки (Likes)',
            collapsed: true,
            items: getSidebarItems('reference/likes', 'likes.')
          },
          {
            text: 'Сообщения (Messages)',
            collapsed: true,
            items: getSidebarItems('reference/messages', 'messages.')
          },
          {
            text: 'Лента новостей (Newsfeed)',
            collapsed: true,
            items: getSidebarItems('reference/newsfeed', 'newsfeed.')
          },
          {
            text: 'Заметки (Notes)',
            collapsed: true,
            items: getSidebarItems('reference/notes', 'notes.')
          },
          {
            text: 'Уведомления (Notifications)',
            collapsed: true,
            items: getSidebarItems('reference/notifications', 'notifications.')
          },
          {
            text: 'Утилиты инстанса (Ovk)',
            collapsed: true,
            items: getSidebarItems('reference/ovk', 'ovk.')
          },
          {
            text: 'Платежная система (Pay)',
            collapsed: true,
            items: getSidebarItems('reference/pay', 'pay.')
          },
          {
            text: 'Фотографии (Photos)',
            collapsed: true,
            items: getSidebarItems('reference/photos', 'photos.')
          },
          {
            text: 'Опросы (Polls)',
            collapsed: true,
            items: getSidebarItems('reference/polls', 'polls.')
          },
          {
            text: 'Жалобы (Reports)',
            collapsed: true,
            items: getSidebarItems('reference/reports', 'reports.')
          },
          {
            text: 'Статус (Status)',
            collapsed: true,
            items: getSidebarItems('reference/status', 'status.')
          },
          {
            text: 'Пользователи (Users)',
            collapsed: true,
            items: getSidebarItems('reference/users', 'users.')
          },
          {
            text: 'Утилиты (Utils)',
            collapsed: true,
            items: getSidebarItems('reference/utils', 'utils.')
          },
          {
            text: 'Видеозаписи (Video)',
            collapsed: true,
            items: getSidebarItems('reference/video', 'video.')
          },
          {
            text: 'Стена (Wall)',
            collapsed: true,
            items: getSidebarItems('reference/wall', 'wall.')
          }
        ]
      },
      {
        text: 'Модели данных',
        items: [
          {
            text: 'Базовые и общие модели',
            collapsed: true,
            items: [
              { text: 'Ошибка API (ApiError)', link: '/reference/models/api-error' },
              { text: 'Авторизация (Auth)', link: '/reference/models/auth' },
              { text: 'Универсальная коллекция (Collection)', link: '/reference/models/collection' },
              { text: 'Информация о комментариях (CommentsInfo)', link: '/reference/models/comments-info' },
              { text: 'Расширенная коллекция (ExtendedCollection)', link: '/reference/models/extended-collection' },
              { text: 'Расширенная коллекция уведомлений (ExtendedNotificationsCollection)', link: '/reference/models/extended-notifications-collection' },
              { text: 'Гео-метка (Geo)', link: '/reference/models/geo' },
              { text: 'Счетчик отметок (LikesInfo)', link: '/reference/models/likes-info' },
              { text: 'Коллекция новостной ленты (NewsfeedCollection)', link: '/reference/models/newsfeed-collection' },
              { text: 'Коллекция уведомлений (NotificationsCollection)', link: '/reference/models/notifications-collection' },
              { text: 'Запись на стене (Post)', link: '/reference/models/post' },
              { text: 'Информация о репостах (RepostsInfo)', link: '/reference/models/reposts-info' }
            ]
          },
          {
            text: 'Аккаунт (Account)',
            collapsed: true,
            items: getSidebarItems('reference/models/account')
          },
          {
            text: 'Аудиозаписи (Audio)',
            collapsed: true,
            items: getSidebarItems('reference/models/audio')
          },
          {
            text: 'Обсуждения (Board)',
            collapsed: true,
            items: getSidebarItems('reference/models/board')
          },
          {
            text: 'Комментарии (Comments)',
            collapsed: true,
            items: getSidebarItems('reference/models/comments')
          },
          {
            text: 'Документы (Docs)',
            collapsed: true,
            items: getSidebarItems('reference/models/docs')
          },
          {
            text: 'Друзья (Friends)',
            collapsed: true,
            items: getSidebarItems('reference/models/friends')
          },
          {
            text: 'Подарки (Gifts)',
            collapsed: true,
            items: getSidebarItems('reference/models/gifts')
          },
          {
            text: 'Сообщества (Groups)',
            collapsed: true,
            items: getSidebarItems('reference/models/groups')
          },
          {
            text: 'Отметки Мне нравится (Likes)',
            collapsed: true,
            items: getSidebarItems('reference/models/likes')
          },
          {
            text: 'Сообщения (Messages)',
            collapsed: true,
            items: getSidebarItems('reference/models/messages')
          },
          {
            text: 'Лента новостей (Newsfeed)',
            collapsed: true,
            items: getSidebarItems('reference/models/newsfeed')
          },
          {
            text: 'Заметки (Notes)',
            collapsed: true,
            items: getSidebarItems('reference/models/notes')
          },
          {
            text: 'Уведомления (Notifications)',
            collapsed: true,
            items: getSidebarItems('reference/models/notifications')
          },
          {
            text: 'Утилиты инстанса (Ovk)',
            collapsed: true,
            items: getSidebarItems('reference/models/ovk')
          },
          {
            text: 'Фотографии (Photos)',
            collapsed: true,
            items: getSidebarItems('reference/models/photos')
          },
          {
            text: 'Опросы (Polls)',
            collapsed: true,
            items: getSidebarItems('reference/models/polls')
          },
          {
            text: 'Статус (Status)',
            collapsed: true,
            items: getSidebarItems('reference/models/status')
          },
          {
            text: 'Пользователи (Users)',
            collapsed: true,
            items: getSidebarItems('reference/models/users')
          },
          {
            text: 'Утилиты (Utils)',
            collapsed: true,
            items: getSidebarItems('reference/models/utils')
          },
          {
            text: 'Видеозаписи (Video)',
            collapsed: true,
            items: getSidebarItems('reference/models/video')
          },
          {
            text: 'Стена (Wall)',
            collapsed: true,
            items: getSidebarItems('reference/models/wall')
          }
        ]
      }
    ],
    socialLinks: [
      { icon: 'github', link: 'https://github.com/LyStudios/OpenVkNetApi' }
    ],
    footer: {
      message: 'Выпущено под лицензией MIT.',
      copyright: 'Copyright © 2026 LyStudios'
    }
  }
}
