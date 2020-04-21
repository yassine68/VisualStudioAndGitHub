using System;
using System.Collections.Generic;

namespace DisplayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { ID = 1, Name = "Jhon", DateOfBirth = new DateTime(1992, 05, 25) },
                new Employee { ID = 2, Name = "Tod", DateOfBirth = new DateTime(1980, 07, 20) },
                new Employee { ID = 3, Name = "Sara", DateOfBirth = new DateTime(1999, 01, 15) },
                new Employee { ID = 4, Name = "ENNAJEM", DateOfBirth = new DateTime(1995, 12, 07) }
            };
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }
            Console.WriteLine("Program Finished.");
        }
    }
}
