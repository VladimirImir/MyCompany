using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    class Accountant : Employee
    {
        public AccountandLevel accountandLevel;
        public MyCompany myCompany;
        public SubordinationLevel subordinationLevel;
        public string TypeAccountant
        {
            get; set;
        }
        public Accountant(string name, string surname, string patronymic, DateTime birthDate,
                Gender gender, Nationality nationality, EducationLevel educationLevel, float salary,
                AccountandLevel accountandLevel, MyCompany myCompany, SubordinationLevel subordinationLevel)
         : base(name, surname, patronymic, birthDate, gender, nationality, educationLevel, salary)
        {
            this.myCompany = myCompany;
            this.subordinationLevel = subordinationLevel;
            this.accountandLevel = accountandLevel;
        }
        public override string ToString()
        {
            return $"Accontand: \n\t" +
                $"COMPANY: {myCompany} ;\n\t" +
                $"Subordinate: {subordinationLevel} ;\n\t\n\t" +
                base.ToString() +
                $"\n\tTypeAccountant: {accountandLevel}; \n\t";
        }
    }
}
