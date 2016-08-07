﻿namespace HumanResourcesSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class HumanResources
    {
        public static List<IEmployee> allEmployees = new List<IEmployee>();
        private static int nextId = 1;

        public static void HireEmployee()
        {
            IEmployee newEmployee = new IEmployee();
            
            Console.Write("Please, enter the first name of the employee: ");
            // try catch
            newEmployee.FirstName = Console.ReadLine();
            Console.Write("Please, enter the last name of the employee: ");
            newEmployee.LastName = Console.ReadLine();
            Console.Write("Please, enter the employee position: ");
            newEmployee.PositionAtWork = Console.ReadLine();
            newEmployee.EmployeeId = nextId;
            allEmployees.Add(newEmployee);
            nextId++;
        }

        public static List<IEmployee> GetEmployees()
        {
            return allEmployees;
        }

        public static void PrintAllEmployee()
        {
            if (allEmployees.Count < 1)
            {
                throw new ArgumentNullException("No employees hired yet.");
            }
            Console.WriteLine("List of all employees");
            foreach (var emp in allEmployees)
            {
                Console.WriteLine("Name: {0} {1}, Position: {2}, ProjectID: {3}, Salary: ${4}, EmployeeID: {5}", emp.FirstName, emp.LastName, emp.PositionAtWork, emp.Project, emp.Salary, emp.EmployeeId);
            }
        }
    }
}
