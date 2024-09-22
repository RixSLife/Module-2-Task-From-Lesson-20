namespace Module_2_Task_From_Lesson_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);

            Console.WriteLine("Welcome to the employee list:");

            while (true)
            {
                Console.WriteLine("Please choose what you want to do");

                var mainMenu = actionService.GetMenuActionByMenuName("MainMenu");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
                }

                var operation = Console.ReadKey();
                MenuActionService menuActionService = new MenuActionService();
                EmployeeService employeeService = new EmployeeService();
                switch (operation.KeyChar)
                {
                    case '1':
                        var keyInfo = employeeService.AddNewEmployeeView(actionService);
                        var id = employeeService.AddNewEmployee(keyInfo.KeyChar);
                        break;
                    case '2':
                        var removeId = employeeService.RemoveEmployeeView();
                        employeeService.RemoveEmployee(removeId);
                        break;
                    case '3':

                        break;
                    case '4':

                        break;
                    case '5':

                        break;
                    default:
                        Console.WriteLine("Choosen option is not available.");
                        break;
                }
            }
        }
        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Add new employee", "MainMenu");
            actionService.AddNewAction(2, "Remove employee", "MainMenu");
            actionService.AddNewAction(3, "Amend employee details", "MainMenu");
            actionService.AddNewAction(4, "View employees", "MainMenu");
            actionService.AddNewAction(5, "Search employee", "MainMenu");
            return actionService;

            actionService.AddNewAction(1, "Transport/driver", "addEmployeeMenu");
            actionService.AddNewAction(2, "Office/admin", "addEmployeeMenu");
            actionService.AddNewAction(3, "Warehouse/operative", "addEmployeeMenu");
            return actionService;
        }
    }
}
