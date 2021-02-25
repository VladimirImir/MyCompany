using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    class OwnerOfCompany : Human
    {
        private string _kindOfActivity;     // вид деятельности.
        public MyCompany myCompany;
        public string KindOfActivity
        {
            get; set;
        }

        public OwnerOfCompany(string name, string surname, string patronymic, DateTime birthDate,
                              Gender gender, Nationality nationality, MyCompany myCompany, string kindOfActivity)
                : base(name, surname, patronymic, birthDate, gender, nationality)
        {
            KindOfActivity = kindOfActivity;
        }
        public override string ToString()
        {
            return $"OwnerOfCompany: \n\t" +
                $"\n\tCOMPANY: {myCompany} ; " +
                $"\n\tKindOfActivity: {KindOfActivity} ; \n\t\n\t" +
            base.ToString();
        }
    }
}


