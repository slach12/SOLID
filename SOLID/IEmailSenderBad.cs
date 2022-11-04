using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    interface IEmailSenderBad
    {
        void Send();
        void LogError(Exception exception);
        void AddToStats();
    }
}
