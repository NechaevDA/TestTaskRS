using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskRS.Models;

namespace TestTaskRS.Common
{
    public delegate void NotificationEventHandler(NotificationModel notification);

    public class NotificationEventArgs
    {
        public NotificationModel Notification { get; }

        public NotificationEventArgs(NotificationModel notification)
        {
            Notification = notification;
        }
    }
}
