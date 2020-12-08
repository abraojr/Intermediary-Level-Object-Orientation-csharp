using Polymorphism.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            /* A company has its own employees and outsourced. For each employee, it is desired to register name, hours worked and value per hour. 
             *Outsourced employees also have an additional expense.
             * The employees' pay corresponds to the value of the hour multiplied by the hours worked, and the outsourced employees still receive a bonus
             *corresponding to 110% of their additional expense.
             * Make a program to read the data of N employees (N provided by the user) and store them in a list. After reading all the data, show name and 
             *payment of each employee in the same order they were typed.*/

            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: U$ ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Additional charge: U$ ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hour, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hour, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - U$ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
