

namespace C_Sharp_HW_OOP
{
    class TeamLead : Employee
    {
        private string _name;
        private int _salary;
        private int _subordinates;

        public TeamLead(string name, int salary, int subordinates)
        {
            _name = name;
            _salary = salary;
            _subordinates = subordinates;
        }

        public override string Name()
        {
            return _name;
        }

        public override string Position()
        {
            return "Team Lead";
        }

        public override string ResponsibilityLevels()
        {
            return "Development team leader on the project";
        }

        public override int Salary()
        {
            return _salary;
        }

        public override int Subordinates()
        {
            return _subordinates;
        }

    }
}
