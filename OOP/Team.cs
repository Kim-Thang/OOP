using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Team : Company
    {
        public void InputManager(Employee manager)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(manager);
            listMemberInCompany.Add(employees);
        }
        public void InputOtherEmployee(Employee employee, string manager)
        {
            foreach (List<Employee> employees in listMemberInCompany)
            {
                foreach (Employee e in employees)
                {
                    string code = e.getEmployeeCode();
                    if (code == manager)
                    {
                        employees.Add(employee);
                        break;
                    }
                }
            }
        }
        public void OutputEmployee()
        {
            foreach (List<Employee> employees in listMemberInCompany)
            {
                foreach (Employee e in employees)
                {
                    e.OutputEmployee();

                }
            }
        }

        public void RemoveEmployee(string codeEmployee)
        {

            int elementDelete = -1;
            int team = 0;
            foreach (List<Employee> employees in listMemberInCompany)
            {
                foreach (Employee e in employees)
                {
                    string code = e.getEmployeeCode();
                    if (code == codeEmployee)
                    {
                        elementDelete++;
                    }
                }
                team++;
            }
            if (elementDelete == -1)
            {
                Console.WriteLine("Not found code employee you need remove!!!");
            } else
            {
                Console.WriteLine("Remove successlly!");
                listMemberInCompany[team].RemoveAt(elementDelete);
            }
        }

        public double TotalSalary()
        {
            double total = 0;
            foreach (List<Employee> employees in listMemberInCompany)
            {
                foreach (Employee e in employees)
                {
                    total += e.CountSalary();
                }
            }
            return total;
        }

        public void getManagerManyMembers()
        {
            int count = 0;
            string nameManager = "";
            foreach (List<Employee> employees in listMemberInCompany)
            {
                int countMember = employees.Count();

                if (count < countMember)
                {
                    foreach (Employee e in employees)
                    {
                        string manager = e.GetType().Name;
                        if (manager == TypeEmployee.Manager.ToString())
                        {
                            nameManager = e.getName();
                        }
                    }
                    count = countMember;
                }
            }
            Console.WriteLine(nameManager);
        }

        public void getManagerNotEnoughMember()
        {
            string employee = "";
            foreach (List<Employee> employees in listMemberInCompany)
            {
                int manager = 0, designer = 0, developer = 0, tester = 0;
                foreach (Employee e in employees)
                {
                    string name = e.GetType().Name;
                    if (name == TypeEmployee.Manager.ToString())
                    {
                        manager++;
                        employee = e.getName();
                    }
                    else if (name == TypeEmployee.Developer.ToString())
                    {
                        developer++;
                    }
                    else if (name == TypeEmployee.Designer.ToString())
                    {
                        designer++;
                    } 
                    else
                    {
                        tester++;
                    }
                    
                }
                if (manager == 0 || designer == 0 || developer == 0 || tester == 0)
                {
                    Console.WriteLine(employee);
                }
            }
        }
    }


}
enum TypeEmployee
{
    Developer,
    Manager,
    Tester,
    Designer
}

