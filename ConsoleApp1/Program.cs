using ConsoleApp1.Entities;
using ConsoleApp1.Entities.Enums;
using System;
using System.Diagnostics.Contracts;
using System.Resources;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            Department department = new Department(Console.ReadLine());
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Worker worker = new Worker(name, level, baseSalary, department);
            Console.Write("How many contracts to this worker? ");
            int amountContracts = int.Parse(Console.ReadLine());
            for (int i=1; i <= amountContracts; i++)
            {
                Console.WriteLine("Enter #{0} contract data: ",i);
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime dateContract = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(dateContract,valuePerHour,hours);
                worker.AddContract(contract);
            }
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string date = Console.ReadLine();
            int month = int.Parse(date.Substring(0, 2));
            int year = int.Parse(date.Substring(3));
            Console.WriteLine("Name: {0}",worker.Name);
            Console.WriteLine("Department: {0}",worker.Department.Name);
            Console.WriteLine("Income for {0}/{1}: {2}",month,year,worker.Income(year,month));
        }
    }
}
