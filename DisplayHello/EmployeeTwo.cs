using System;
using System.Collections.Generic;
using System.Text;

namespace DisplayHello
{
    public partial class Employee
    {
        public override bool Equals(object employee)
        {
            Employee emp = (Employee)employee;
            if (emp != null && emp is Employee)
            {
                return this.Name == emp.Name && this.DateOfBirth == emp.DateOfBirth;
            }
            throw new Exception("Employee Paramater be Employee 'Type' !!");
        }

        public override string ToString()
        {
            return $"ID = {ID} , Name {Name} , Date Of Birth = {DateOfBirth.Value.ToString("dd/MM/yyyy")}";
        }
    }
}
