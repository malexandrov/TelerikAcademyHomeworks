using System;
using System.Linq;

namespace _2.HumanHierarchy
{
    class Worker : Human
    {
        private float weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, float weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public int WorkHoursPerDay { get; set; }
        public float WeekSalary { get; set; }

        public float MoneyPerHour()
        {
            float moneyPerHour = weekSalary / (workHoursPerDay * 5);
            return moneyPerHour;
        }
    }
}
