using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Task_From_Lesson_20
{
    public class EmployeeService
    {
        public List<Employee> Employees { get; set; }
        public EmployeeService()
        {
            Employees = new List<Employee>();
        }
        public ConsoleKeyInfo AddNewEmployeeView(MenuActionService actionService)
        {
            var addEmployeeMenu = actionService.GetMenuActionByMenuName("addEmployeeMenu");
            Console.WriteLine("Please select departament:");
            for (int i = 0; i < addEmployeeMenu.Count; i++)
            {
                Console.WriteLine($"{addEmployeeMenu[i].Id}. {addEmployeeMenu[i].Name}");
            }
            var operation = Console.ReadKey();
            return operation;
        }

        public int AddNewEmployee(char employeeDepartament)
        {
            int departamentId;
            Int32.TryParse(employeeDepartament.ToString() , out departamentId);
            Employee employee = new Employee();
            employee.CompanyDepartamentId = departamentId;
            Console.WriteLine("Please enter Employee details:");

            Console.WriteLine("Employee company number(6 digits):");
            var empId = Console.ReadLine();
            int employeeId;
            Int32.TryParse(empId, out employeeId);
            
            Console.WriteLine("First name:");
            var firstName = Console.ReadLine();

            Console.WriteLine("Last name:");
            var lastName = Console.ReadLine();

            Console.WriteLine("age:");
            var empAge = Console.ReadLine();
            int age;
            Int32.TryParse(empAge, out age);
           
            Console.WriteLine("Phone number:");
            string phone = Console.ReadLine();

            Console.WriteLine("Email address:");
            string email = Console.ReadLine();

            employee.EmployeeId = employeeId;
            employee.CompanyDepartamentId = departamentId;
            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.Age = age;
            employee.PhoneNumber = phone;
            employee.Email = email; 

            Employees.Add(employee);
            return employeeId;

        }
        public int RemoveEmployeeView()
        {
            Console.WriteLine("Please enter company number for employee you want to remove from system:");
            var empId = Console.ReadLine();
            int removeId;
            Int32.TryParse(empId.ToString(), out removeId);

            return removeId;
        }

        public void RemoveEmployee(int removeId)
        {
            Employee employeeToRemove = new Employee();
            foreach(var employee in Employees)
            {
                if(employee.EmployeeId == removeId)
                {
                    employeeToRemove = employee;
                    break;
                }
            }
            Employees.Remove(employeeToRemove);
        }
    }
}
