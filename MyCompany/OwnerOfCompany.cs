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
        /*public override string ToString()
        {
            return $"OwnerOfCompany: \n\t" +
                base.ToString() +
                $"\n\tNameCompany: {NameCompany} ; " +
                $"\n\tKindOfActivity: {KindOfActivity} ; ";
        }*/
        public override string ToString()
        {
            return $"OwnerOfCompany: \n\t" +
                $"\n\tCOMPANY: {myCompany} ; " +
                $"\n\tKindOfActivity: {KindOfActivity} ; \n\t\n\t" +
            base.ToString();
        }
    }
}

/*    public Director(string name, string surname, string patronymic, DateTime birthDate,
        Gender gender, Nationality nationality, DirectorLevel directorLevel, float salary)
  : base(name, surname, patronymic, birthDate, gender, nationality, EducationLevel.Higher, salary)
    {
        this.directorLevel = directorLevel;
        Salary = salary;
    }
    public override string ToString()
    {
        return $"Director: \n\t" +
            base.ToString() + "" +
            $"\n\tDirectorLevel: {directorLevel} ;";*//* +
                $"\n\tSalary: {Salary} $ ; \n\t";*/
    



    /*public Human()
    {
        Name = "noname";
        Surname = "nosurname";
        Patronymic = "nopatronymic";
        BirthDate = DateTime.Now;
        gender = default;
        nationality = default;
    }
    public override string ToString()
    {
        return //$"Human: \n\t" +
            $"Name: {Name};\n\t" +
            $"Surname: {Surname};\n\t" +
            $"Patronymic: {Patronymic};\n\t" +
            $"Gender: {gender};\n\t" +
            $"Nationality: {nationality};\n\t" +
            $"Birth Date: {BirthDate.ToShortDateString()};\n\t";
    }
    public Human(string name, string surname, string patronymic, DateTime birthDate, Gender gender, Nationality nationality)
    {
        Name = name;
        Surname = surname;
        Patronymic = patronymic;
        BirthDate = birthDate;
        this.gender = gender;
        this.nationality = nationality;
    }

}*/


