using System;
using System.Collections.Generic;

namespace C_Sharp_HW_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test string for GitHub");
            Console.Write("Hello!\nThis is a program for adding new employees.\n\nEnter the number of employees: ");
            int numberEmployees = Check.ForNumberWithoutZero(Console.ReadLine());
            string name; int salary; int subordinates;
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < numberEmployees; i++)
            {
                Console.WriteLine("\nSelect the position of the new employee");
                Console.WriteLine("\t1. Team Lead\n\t2. Tech Lead\n\t3. PM\n\t4. Developer\n\t5. QA\n\t6. Designer\n\t7. Business Analyst");
                Console.Write("In order to select a position, enter from 1 to 7: ");
                int position = Check.ForNumberWithoutZero(Console.ReadLine());
                while (position < 1 || position > 7)
                {
                    Console.WriteLine("\nOnly 1 to 7 can be selected.\n");
                    Console.Write("In order to select a position, enter from 1 to 7: ");
                    position = Check.ForNumberWithoutZero(Console.ReadLine());
                }
                Console.WriteLine($"\nYou have selected position {position}");
                Console.Write("Enter the name of the employee: ");
                name = Console.ReadLine();
                while (name.Length == 0)
                {
                    Console.WriteLine("\n\tThe string cannot be empty.\n");
                    Console.Write("Enter the name of the employee: ");
                    name = Console.ReadLine();
                }

                Console.Write("Enter the employee's salary: ");
                salary = Check.ForNumberWithZero(Console.ReadLine());
                Console.Write("Enter the number of subordinates of the employee: ");
                subordinates = Check.ForNumberWithZero(Console.ReadLine());
                AddEmployee.AddNewEmployee(position, name, salary, subordinates, employees);
            }
            Console.Clear();
            Console.WriteLine("\n\tYou have added information about the employee.\n\tDo you need information about employees??");
            Console.WriteLine("\tIf yes, enter the word 'get', if no, enter anything and program will be stopped.\n");
            Console.Write("Your choice?: ");

            if (Console.ReadLine() == "get")
            {
                Console.Write("\nHere is a list of employees: \n");
                foreach (Employee employee in employees)
                {
                    Console.WriteLine("\n\t" + employee.Position() + " - " + employee.Name());
                }
                Console.WriteLine();

                bool check = false;
                while (check != true)
                {
                    Console.Write("Enter the name of the employee you want to see information about: ");
                    name = Console.ReadLine();
                    foreach (Employee employee in employees)
                    {
                        if (name == employee.Name())
                        { 
                            Console.WriteLine("\nHere is the information on the employee you are interested in.");
                            Console.WriteLine("\tName: " + employee.Name());
                            Console.WriteLine("\tPosition: " + employee.Position());
                            Console.WriteLine("\tResponsibility levels: " + employee.ResponsibilityLevels());
                            Console.WriteLine("\tSalary: " + employee.Salary() + "$");
                            Console.WriteLine("\tNumber of subordinates: " + employee.Subordinates());
                            check = true;
                        }
                    }
                    if (check == false)
                    {
                        Console.WriteLine("\n\tThere is no information about this employee.\n");
                    }
                }
            }
        }
    }
}
