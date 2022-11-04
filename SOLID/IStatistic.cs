using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public interface IStatistic
    {
        void Add(IEmailSender emailSender);
    }
}
