using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Developer : Employee
    {

        public Developer()
        {

        }

        public Developer(string employeeCode, string name, int baseSalary, double levelNumber, DateTime onboardData)
            :base(employeeCode, name, baseSalary, levelNumber, onboardData)
        {

        }
        public override void PositionEmployee()
        {
            Console.WriteLine("Position developer \n");
        }
    }
}
