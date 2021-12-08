

namespace C_Sharp_HW_OOP
{
    class Designer : Employee
    {
        private string _name;
        private int _salary;
        private int _subordinates;

        public Designer(string name, int salary, int subordinates)
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
            return "UI/UX Designer";
        }

        public override string ResponsibilityLevels()
        {
            return "Analysis of design requirements, design development";
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
