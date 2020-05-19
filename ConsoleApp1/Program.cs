using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string departmentName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            string level = Console.ReadLine();
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Console.Write("How many contracts to this worker? ");
            int amountContracts = int.Parse(Console.ReadLine());
            for (int i=1; i <= amountContracts; i++)
            {
                Console.WriteLine("Enter #{0} contract data: ",i);
                Console.Write("Date (DD/MM/YYYY): ");
                string dateContract = Console.ReadLine();
                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string date = Console.ReadLine();

        }
    }
}
