using System;
using System.Collections.Generic;
using System.Text;

namespace DisplayHello
{
    public partial class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Employee()
        {
            this.ID = -1;
            this.Name = null;
            this.DateOfBirth = null;
        }
        public Employee(string name, DateTime dateOfBirth) : this()
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }
        public override int GetHashCode()
        {
            return this.ID.GetHashCode() ^ this.Name.GetHashCode();
        }
    }
}
