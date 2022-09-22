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
        protected int BaseSalary { get; set; }
        protected double LevelNumber { get; set; }
        protected DateTime OnboardData { get; set; }

        public Employee()
        {

        }
        public Employee(string employeeCode, string name, int baseSalary, double levelNumber, DateTime onboardData)
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

        public void InputEmployee()
        {
            Console.WriteLine("Enter code of employee");
            EmployeeCode = Console.ReadLine();
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

                    Console.WriteLine("Enter base salary of employee: ");
                    BaseSalary = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("Onboard date: " + OnboardData + "\n");
        }
        public double CountSalary()
        {
            var today = DateTime.Now;
            var WorkingDate = today - this.OnboardData;
            return Convert.ToInt32(this.BaseSalary) * Convert.ToInt32(WorkingDate.Days) * this.LevelNumber;
        }
        public abstract void PositionEmployee();
    }
}
