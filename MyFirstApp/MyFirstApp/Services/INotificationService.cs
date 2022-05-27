using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstApp.Services
{
    public interface INotificationService
    {
        void Show(string title, string description);
    }
}
