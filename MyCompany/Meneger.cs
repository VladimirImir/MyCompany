using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    class Meneger : Employee
    {
        public ManagerLevel managerLevel;
        private int _number_of_sales;
        public MyCompany myCompany;
        public SubordinationLevel subordinationLevel;
        public int Number_of_sales
        {
            get
            {
                return _number_of_sales;
            }
            set
            {
                if (value >= 0.0f && value < int.MaxValue)
                {
                    _number_of_sales = value;
                }
                else
                {
                    throw new ArgumentException("Что то не так с продажами.");
                }
            }
        }
        public Meneger() : base()
        {
            Number_of_sales = default;
        }
        public Meneger(string name, string surname, string patronymic, DateTime birthDate,
                Gender gender, Nationality nationality, EducationLevel educationLevel, float salary,
                ManagerLevel managerLevel, int number_of_sales, MyCompany myCompany,
                SubordinationLevel subordinationLevel)
          : base(name, surname, patronymic, birthDate, gender, nationality, educationLevel, salary)
        {
            this.myCompany = myCompany;
            this.subordinationLevel = subordinationLevel;
            this.educationLevel = educationLevel;
            Salary = salary;
            this.managerLevel = managerLevel;
            Number_of_sales = number_of_sales;
        }
        public override string ToString()
        {
            return $"Meneger: \n\t" +
                $"COMPANY: {myCompany} ;\n\t" +
                $"Subordinate: {subordinationLevel} ;\n\t\n\t" +
                base.ToString() + "\n\t" +
                $"\n\tManagerLevel: {managerLevel} " +
                $"\n\tNumber_of_sales: {_number_of_sales}";
        }
    }
}
