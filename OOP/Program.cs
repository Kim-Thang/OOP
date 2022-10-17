using OOP;

Team team = new Team();
int choose;
int flag = 0;
do
{
    Console.WriteLine("#######################################################################################");
    Console.WriteLine("# Choose an option:                                                                   #");
    Console.WriteLine("# 1. Add employee                                                                     #");
    Console.WriteLine("# 2. Show all employee                                                                #");
    Console.WriteLine("# 3. Remove employee                                                                  #");
    Console.WriteLine("# 4. Show total salary of all employee                                                #");
    Console.WriteLine("# 5. Show the name of manager who have most crowded member in the company             #");
    Console.WriteLine("# 6. Show the name of manager in team not enough 4 positions                          #");
    Console.WriteLine("# Exit                                                                                #");
    Console.WriteLine("#######################################################################################");

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
        case (int)Option.ADD_EMPLOYEE:
            Console.WriteLine("############################################################");
            Console.WriteLine("# 1. Manager                                               #");
            Console.WriteLine("# 2. Developer                                             #");
            Console.WriteLine("# 3. Tester                                                #");
            Console.WriteLine("# 4. Designer                                              #");
            Console.WriteLine("# Exit                                                     #");
            Console.WriteLine("############################################################");
            int chooseTypeEmployee;
            {
            while (true)
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
                case (int) Position.MANAGER:
                    Employee manager = new Manager();
                    manager.InputEmployee();
                    team.InputManager(manager);
                    break;

                case (int) Position.DEVELOPER:
                    Employee developer = new Developer();
                    developer.InputEmployee();
                    Console.WriteLine("Enter code employee of manager: ");
                    string codeManager = Console.ReadLine();
                    team.InputOtherEmployee(developer, codeManager);
                    break;

                case (int) Position.TESTER:
                    Employee tester = new Tester();
                    tester.InputEmployee();
                    Console.WriteLine("Enter code employee of manager: ");
                    codeManager = Console.ReadLine();
                    team.InputOtherEmployee(tester, codeManager);
                    break;

                case (int) Position.DESIGNER:
                    Employee desinger = new Designer();
                    desinger.InputEmployee();
                    Console.WriteLine("Enter code employee of manager: ");
                    codeManager = Console.ReadLine();
                    team.InputOtherEmployee(desinger, codeManager);
                    break;

                default:
                    break;
            }
            break;
        case (int)Option.SHOW_ALL_EMPLOYEE:
            Console.WriteLine("Show all employee in company: ");
            team.OutputEmployee();
            break;

        case (int) Option.REMOVE_EMPLOYEE:
            Console.WriteLine("Enter code employee you need remove: ");
            string codeEmployeeNeedRemove = Console.ReadLine();
            team.RemoveEmployee(codeEmployeeNeedRemove);
            break;

        case (int) Option.SHOW_TOTAL_SALARY:
            double totalSalary = team.TotalSalary();
            Console.WriteLine("Total salary of all employee: " + totalSalary);
            break;

        case (int) Option.SHOW_MANAGER_MOST_EMPLOYEE:
            Console.WriteLine("Name of manager who have most crowded member in the company: ");
            team.getManagerManyMembers();
            break;

        case (int) Option.SHOW_MANAGER_NOT_ENOUGH_4_POSITION:
            Console.WriteLine("Show the name of manager in team not enough 4 positions: ");
            team.getManagerNotEnoughMember();
            break;

        default:
            flag = 1;
            break;
    }
}
while (flag != 1);


enum Option
{
    ADD_EMPLOYEE = 1,
    SHOW_ALL_EMPLOYEE = 2,
    REMOVE_EMPLOYEE = 3,
    SHOW_TOTAL_SALARY = 4,
    SHOW_MANAGER_MOST_EMPLOYEE = 5,
    SHOW_MANAGER_NOT_ENOUGH_4_POSITION = 6,
}

enum Position
{
    MANAGER = 1,
    DEVELOPER = 2,
    TESTER = 3,
    DESIGNER = 4
}

