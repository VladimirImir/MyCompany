using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    class Director : Employee
    {
        public DirectorLevel directorLevel;
        public MyCompany myCompany;
        public SubordinationLevel subordinationLevel;
        public Director(string name, string surname, string patronymic, DateTime birthDate,
                Gender gender, Nationality nationality, DirectorLevel directorLevel, float salary, MyCompany myCompany,
                SubordinationLevel subordinationLevel)
          : base(name, surname, patronymic, birthDate, gender, nationality, EducationLevel.Higher, salary)
        {
            this.myCompany = myCompany;
            this.subordinationLevel = subordinationLevel;
            this.directorLevel = directorLevel;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Director: \n\t" +
                $"COMPANY: {myCompany} ;\n\t" +
                $"Subordinate: {subordinationLevel} ;\n\t\n\t" +
                base.ToString() + "" +
                $"\n\tDirectorLevel: {directorLevel} ;";/* +
                $"\n\tSalary: {Salary} $ ; \n\t";*/
        }
    }
}
