using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public interface ILoger
    {
        void LogError(Exception exception);
    }
}
