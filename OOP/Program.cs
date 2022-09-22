using OOP;

Team team = new Team();
int choose;
int flag = 0;
do
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Add employee");
    Console.WriteLine("2. Remove employee");
    Console.WriteLine("3. Show total salary of all employee");
    Console.WriteLine("4. Show the name of manager who have most crowded member in the company");
    Console.WriteLine("5. Show the name of manager in team not enough 4 positions");
    Console.WriteLine("Any number to exit");
    while (true)
    {
        try
        { 
            choose = Int32.Parse(Console.ReadLine());
            break;
        }
        catch
        {
            Console.WriteLine("Input incorrect! please try again");
        }
    }

    switch (choose)
    {
        case 1:
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Developer");
            Console.WriteLine("3. Tester");
            Console.WriteLine("4. Designer");
            Console.WriteLine("Any number to exit");
            int chooseTypeEmployee;
            while (true)
            {
                try
                {
                    chooseTypeEmployee = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Input incorrect! please try again");
                }
            }
            switch (chooseTypeEmployee)
            {
                case 1:
                    Employee manager = new Manager();
                    manager.InputEmployee();
                    team.InputManager(manager);
                    break;
                case 2:
                    Employee developer = new Developer();
                    developer.InputEmployee();
                    Console.WriteLine("Enter code employee of manager: ");
                    string codeManager = Console.ReadLine();
                    team.InputOtherEmployee(developer, codeManager);
                    break;
                case 3:
                    Employee tester = new Tester();
                    tester.InputEmployee();
                    Console.WriteLine("Enter code employee of manager: ");
                    codeManager = Console.ReadLine();
                    team.InputOtherEmployee(tester, codeManager);
                    break;
                case 4:
                    Employee desinger = new Designer();
                    desinger.InputEmployee();
                    Console.WriteLine("Enter code employee of manager: ");
                    codeManager = Console.ReadLine();
                    team.InputOtherEmployee(desinger, codeManager);
                    break;
                case 5:
                    team.OutputEmployee();
                    break;
                default:
                    break;
            }
            break;
        case 2:
            Console.WriteLine("Enter code employee you need remove: ");
            string codeEmployeeNeedRemove = Console.ReadLine();
            team.RemoveEmployee(codeEmployeeNeedRemove);
            break;
        case 3:
            double totalSalary = team.TotalSalary();
            Console.WriteLine("Total salary of all employee: " + totalSalary);
            break;
        case 4:
            Console.WriteLine("Name of manager who have most crowded member in the company: ");
            team.getManagerManyMembers();
            break;
        case 5:
            Console.WriteLine("Show the name of manager in team not enough 4 positions: ");
            team.getManagerNotEnoughMember();
            break;
        default:
            flag = 1;
            break;
    }
}
while (flag != 1);