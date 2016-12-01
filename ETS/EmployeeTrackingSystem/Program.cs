using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours=0;
            Employee employees = new Employee();
            employees.EmpId="101";
            employees.Name = "gouse";

            Department departments = new Department();
            departments.DepartmentId = "IT001";
            departments.DepartmentName = "IT";
            
            IDCard idCards = new IDCard();
            idCards.SignIn = 9;
            idCards.Signout = 20;
            hours = employees.Calculate(hours,idCards);

            Console.WriteLine(employees.EmpId);
            Console.WriteLine(employees.Name);
            Console.WriteLine(departments.DepartmentName);
            Console.WriteLine(hours);

            Console.ReadLine();
        }
    }
}
