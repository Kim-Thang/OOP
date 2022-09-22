using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Company
    {

        protected List<List<Employee>> listMemberInCompany = new List<List<Employee>>();

        public Company()
        {
            List<Employee> listEmployee1 = new List<Employee>();
            listEmployee1.AddRange(new Employee[] {
            new Manager("111", "Nguyen Van A", 1000000, 2.5, new DateTime(2022, 8, 1)),
            new Developer("001" ,"Nguyen Van C", 800000, 2, new DateTime(2022, 8, 1, 0, 0, 0)),
            new Designer("002" ,"Nguyen Van E", 700000, 1.5, new DateTime(2022, 8, 2, 0, 0, 0) ),
            new Designer("003" ,"Nguyen Van F", 700000, 1.5,  new DateTime(2022,  8, 2, 0, 0, 0)),
            new Tester("004" ,"Nguyen Van D", 500000, 1.2, new DateTime(2022, 8, 2, 0, 0, 0)),
            new Tester("005" ,"Nguyen Van L", 500000, 1.2, new DateTime(2022, 8, 2, 0, 0, 0)),
             }); ;

            List<Employee> listEmployee2 = new List<Employee>();
            listEmployee2.AddRange(new Employee[] {
            new Manager("112", "Nguyen Van B",1000000, 2.5, new DateTime(2022, 8, 1)),
            new Tester("006" ,"Nguyen Van H", 500000, 1.2, new DateTime(2022, 8, 1, 0, 0, 0)),
            new Developer("006" ,"Nguyen Van Z", 800000, 2, new DateTime(2022, 8, 2, 0, 0, 0)),
            new Developer("008" ,"Nguyen Van O", 800000, 2, new DateTime(2022, 8, 2, 0, 0, 0) ),
            new Developer("009" ,"Nguyen Van K", 800000, 2, new DateTime(2022, 8, 2, 0, 0, 0)),
             }); ;

            listMemberInCompany.AddRange(new List<Employee>[] { listEmployee1, listEmployee2 });
        }
    }
}
