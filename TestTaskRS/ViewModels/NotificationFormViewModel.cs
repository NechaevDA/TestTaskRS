using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskRS.Common;
using TestTaskRS.Models;

namespace TestTaskRS.ViewModels
{
    class NotificationFormViewModel : ViewModelBase
    {
        public event NotificationEventHandler NewNotification;

        public string Header
        {
            get => _header;
            set => SetValue(ref _header, value);
        }

        public string Message
        {
            get => _message;
            set => SetValue(ref _message, value);
        }

        public bool IsMessageCorrect
        {
            get => _isMessageCorrect;
            set => SetValue(ref _isMessageCorrect, value);
        }

        public bool IsHeaderCorrect
        {
            get => _isHeaderCorrect;
            set => SetValue(ref _isHeaderCorrect, value);
        }

        public Command CreateNotificationCommand { get; }

        private string _header;
        private string _message;
        private bool _isMessageCorrect;
        private bool _isHeaderCorrect;

        public NotificationFormViewModel()
        {
            CreateNotificationCommand = new Command(CreateNotification);
            Header = "Hello world!";
        }

        private void CreateNotification()
        {
            IsHeaderCorrect = !string.IsNullOrWhiteSpace(Header);
            IsMessageCorrect = !string.IsNullOrWhiteSpace(Message);

            if (!IsMessageCorrect || !IsHeaderCorrect)
                return;

            var notificationModel = new NotificationModel(Header, Message);

            NewNotification?.Invoke(notificationModel);
        }
    }
}
