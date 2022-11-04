using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public interface IEmployee
    {
        void SetFirstName(string firstName);
        void SetLastName(string lastName);

        decimal GetSalary();
    }
}
