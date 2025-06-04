import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: 'task-posting',
    loadChildren: () =>
      import('./features/task-posting/task-posting.module').then(
        (m) => m.TaskPostingModule
      ),
  },
  {
    path: 'bidding',
    loadChildren: () =>
      import('./features/bidding/bidding.module').then(
        (m) => m.BiddingModule
      ),
  },
  {
    path: 'chat',
    loadChildren: () =>
      import('./features/chat/chat.module').then((m) => m.ChatModule),
  },
  {
    path: 'notifications',
    loadChildren: () =>
      import('./features/notifications/notifications.module').then(
        (m) => m.NotificationsModule
      ),
  },
];
