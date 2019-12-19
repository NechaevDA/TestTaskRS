using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskRS.Common;
using TestTaskRS.Models;

namespace TestTaskRS.ViewModels
{
    class MainWindowViewModel : ViewModelBase, IDisposable
    {
        public NotificationFormViewModel NotificationFormViewModel { get; }
        public ObservableCollection<NotificationViewModel> Notifications { get; }
        public Command ClearAllNotificationsCommand { get; }

        public MainWindowViewModel()
        {
            Notifications = new ObservableCollection<NotificationViewModel>();
            NotificationFormViewModel = new NotificationFormViewModel();
            NotificationFormViewModel.NewNotification += OnNewNotification; // Источник может быть заменен на любой класс, реализующий интерфейс с событием нового сообщения
            ClearAllNotificationsCommand = new Command(ClearNotifications);
        }

        private void ClearNotifications()
        {
            Notifications.Clear();
        }

        private void OnNewNotification(NotificationModel notification)
        {
            var notificationViewModel = new NotificationViewModel(notification);
            Notifications.Add(notificationViewModel);
        }

        public void Dispose()
        {
            NotificationFormViewModel.NewNotification -= OnNewNotification;
        }
    }
}
