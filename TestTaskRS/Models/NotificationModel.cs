using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskRS.Models
{
    public class NotificationModel
    {
        public bool IsRead;
        public string Message { get; private set; }
        public string Header { get; private set; }
        public DateTime CreationTime { get;  private set; }

        public NotificationModel(string header, string message)
        {
            Header = header;
            Message = message;
            IsRead = false;
            CreationTime = DateTime.Now;
        }
    }
}
