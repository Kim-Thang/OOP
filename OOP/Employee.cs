using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP
{
    internal abstract class Employee
    {
        protected string EmployeeCode { get; set; }
        protected string Name { get; set; }
        protected double BaseSalary { get; set; }
        protected double LevelNumber { get; set; }
        protected DateTime OnboardData { get; set; }

        GenerateId id = new GenerateId();

        public Employee()
        {

        }
        public Employee(string employeeCode, string name, double baseSalary, double levelNumber, DateTime onboardData)
        {
            this.EmployeeCode = employeeCode;
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.LevelNumber = levelNumber;
            this.OnboardData = onboardData;
        }
        public string getName()
        {
            return this.Name;
        }
        public string getEmployeeCode()
        {
            return this.EmployeeCode;
        }

        public double baseSalary()
        {
            return this.BaseSalary = 1000000;
        }
        public void InputEmployee()
        {

            EmployeeCode = id.generateId();
            this.baseSalary();
            Console.WriteLine("Enter name of employee: ");
            Name = Console.ReadLine();
            while (!!Regex.IsMatch(Name, "[^a-zA-Z0-_ ]+"))
            {
                Console.WriteLine("Input incorrect! please try again");
                Name = Console.ReadLine();
            }

            while (true)
            {
                try
                {

                    Console.WriteLine("Enter level number of employee: ");
                    LevelNumber = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Input incorrect! please try again");
                }
            }
            while (true)
            {
                try
                {

                    Console.Write("Enter onboard date of employee format YYYY-MM-DD: ");
                    OnboardData = Convert.ToDateTime(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Input incorrect! please try again");
                }
            }
        }

        public void OutputEmployee()
        {
            Console.WriteLine("EmployeeCode: " + EmployeeCode);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("BaseSalary: " + BaseSalary);
            Console.WriteLine("LevelNumber: " + LevelNumber);
            Console.WriteLine("Onboard date: " + OnboardData);
            this.PositionEmployee();
        }
       
        public double CountSalary()
        {
            var today = DateTime.Now;
            var WorkingDate = today - this.OnboardData;
            return Convert.ToInt32(this.baseSalary()) * Convert.ToInt32(WorkingDate.Days) * this.LevelNumber;
        }
        public abstract void PositionEmployee();
    }
}