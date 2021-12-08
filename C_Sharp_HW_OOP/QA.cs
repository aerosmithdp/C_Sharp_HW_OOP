

namespace C_Sharp_HW_OOP
{
    class QA : Employee
    {
        private string _name;
        private int _salary;
        private int _subordinates;

        public QA(string name, int salary, int subordinates)
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
            return "QA Engineer";
        }

        public override string ResponsibilityLevels()
        {
            return "Software product quality assurance, quality control assurance, testing";
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