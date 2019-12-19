using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskRS.Common;
using TestTaskRS.Models;

namespace TestTaskRS.ViewModels
{
    class NotificationViewModel : ViewModelBase
    {
        public bool IsRead
        {
            get => Model.IsRead;
            set => SetValue(ref Model.IsRead, value, nameof(IsRead));
        }

        public NotificationModel Model { get; }
        public Command ReadCommand { get; }

        public NotificationViewModel(NotificationModel model)
        {
            Model = model ?? throw new ArgumentException("NotificationModel");

            ReadCommand = new Command(ChangeReadState);
        }

        private void ChangeReadState()
        {
            IsRead = !IsRead;
        }
    }
}
