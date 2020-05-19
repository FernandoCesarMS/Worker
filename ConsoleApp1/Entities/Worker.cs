using ConsoleApp1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level  { get; set; }
        public double BaseSalary { get; set; }

        public void AddContract(HourContract contract)
        {

        }
        public void RemoveContract(HourContract contract)
        {

        }
        public double Income(int year,int month)
        {
            return 0.0;
        }
    }
}
