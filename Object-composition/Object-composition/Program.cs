using Object_composition.Entities;
using Object_composition.Entities.Enums;
using System;
using System.Globalization;

namespace Object_composition
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Read the data of a worker with N contracts (N provided by the user). Then ask the user for a month and show what the employee's salary was for
             * that month.*/

            Console.Write("Enter department's name: ");
            string depName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level(Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: U$ ");
            double baseSal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dep = new Department(depName);
            Worker worker = new Worker(name, level, baseSal, dep);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter contract #{i} data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: U$ ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income(MM / YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": U$ " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
