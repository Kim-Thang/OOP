using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Tester : Employee
    {

        public Tester()
        {

        }

        public Tester(string employeeCode, string name, int baseSalary, double levelNumber, DateTime onboardData)
           : base(employeeCode, name, baseSalary, levelNumber, onboardData)
        {

        }
        public override void PositionEmployee()
        {
            Console.WriteLine("Position tester \n");
        }
    }
}
