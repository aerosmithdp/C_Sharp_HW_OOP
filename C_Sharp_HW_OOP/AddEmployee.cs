using System.Collections.Generic;


namespace C_Sharp_HW_OOP
{
    class AddEmployee
    {
        public static void AddNewEmployee(int choice, string name, int salary, int subordinates, List<Employee> employees)
        {
            switch(choice)
            {
                case 1:
                    employees.Add(new TeamLead(name, salary, subordinates));
                    break;
                case 2:
                    employees.Add(new TechLead(name, salary, subordinates));
                    break;
                case 3:
                    employees.Add(new PM(name, salary, subordinates));
                    break;
                case 4:
                    employees.Add(new Developer(name, salary, subordinates));
                    break;
                case 5:
                    employees.Add(new QA(name, salary, subordinates));
                    break;
                case 6:
                    employees.Add(new Designer(name, salary, subordinates));
                    break;
                case 7:
                    employees.Add(new BusinessAnalyst(name, salary, subordinates));
                    break;
                 
            }
        }
    }
}
