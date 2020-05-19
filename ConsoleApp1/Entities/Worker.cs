using ConsoleApp1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace ConsoleApp1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level  { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();

        public Worker(string name,WorkerLevel level,double baseSalary,Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year,int month)
        {
            double aux = 0.0;
            foreach (HourContract obj in Contracts)
            {
                aux += obj.totalValue();
            }
            return BaseSalary + aux;
        }
    }
}
