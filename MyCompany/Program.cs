using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Владелец компанинии.

            OwnerOfCompany ownerOfCompany = new OwnerOfCompany("Анаторий", "Рысь", "Борисович", new DateTime(1977, 4, 11),
                                                            Gender.MALE, Nationality.Ukrainian, MyCompany.COMFY,
                                                            "Магазин електроники");

            // Директора.

            Director director1 = new Director("Владимир", "Полтавченко", "Русланович", new DateTime(1990, 11, 28),
                                        Gender.MALE, Nationality.Ukrainian,DirectorLevel.General_Director, 10000,
                                        MyCompany.COMFY, SubordinationLevel.OwnerOfCompany);
            Director director2 = new Director("Андрей", "Кузнецов", "Михаилович", new DateTime(1988, 2, 17),
                                        Gender.MALE, Nationality.Ukrainian,DirectorLevel.Commercial_Director, 9000,
                                        MyCompany.COMFY, SubordinationLevel.OwnerOfCompany);
            Director director3 = new Director("Сергей", "Смирнов", "Иванович", new DateTime(1985, 9, 2),
                                        Gender.MALE, Nationality.Ukrainian,DirectorLevel.Financial_Director, 8000,
                                        MyCompany.COMFY, SubordinationLevel.OwnerOfCompany);

            // Бухгалтер.

            Accountant accountant1 = new Accountant("Яна", "Зубченко", "Семеновна", new DateTime(1987, 9, 6),
                            Gender.FAMALE, Nationality.Ukrainian, EducationLevel.Higher, 4500,
                            AccountandLevel.AccountantCashier, MyCompany.COMFY, SubordinationLevel.Financial_Director);
            Accountant accountant2 = new Accountant("Тамара", "Морозук", "Стантиславовна", new DateTime(1972, 12, 16),
                            Gender.FAMALE, Nationality.Ukrainian, EducationLevel.Higher, 4500,
                            AccountandLevel.AssetAccountant, MyCompany.COMFY, SubordinationLevel.Financial_Director);
            Accountant accountant3 = new Accountant("Яна", "Зубченко", "Семеновна", new DateTime(1975, 8, 10),
                            Gender.FAMALE, Nationality.Ukrainian, EducationLevel.Higher, 4500,
                            AccountandLevel.VAT_Accountant, MyCompany.COMFY, SubordinationLevel.Financial_Director);

            // Менеджера.

            Meneger meneger1 = new Meneger("Галина", "Гладко", "Григорьевна", new DateTime(1986, 1, 21),
                                        Gender.FAMALE, Nationality.Ukrainian, EducationLevel.Higher, 6500,
                                        ManagerLevel.SeniorManagers, 993, MyCompany.COMFY,
                                        SubordinationLevel.General_Director);
            Meneger meneger2 = new Meneger("Олександ", "Котов", "Федорович", new DateTime(1989, 4, 17),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Secondary, 5900,
                                        ManagerLevel.MiddleManagers, 593, MyCompany.COMFY,
                                        SubordinationLevel.Commercial_Director);
            Meneger meneger3 = new Meneger("Виталий", "Рыбалко", "Семенович", new DateTime(1988, 10, 10),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Secondary, 5900,
                                        ManagerLevel.MiddleManagers, 393, MyCompany.COMFY,
                                        SubordinationLevel.Financial_Director);

            // Работники менеждера #1.

            Worker worker1 = new Worker("Катерина", "Смирна", "Андреевна", new DateTime(1998, 12, 14),
                                        Gender.FAMALE, Nationality.Ukrainian, EducationLevel.Higher, 3400,
                                        "Аналитик комп'ютерних систем", MyCompany.COMFY, SubordinationLevel.SeniorManagers);            
            Worker worker2 = new Worker("Василий", "Шпак", "Васильевич", new DateTime(1981, 2, 15),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 3750,
                                        "Продавец-консультант", MyCompany.COMFY, SubordinationLevel.SeniorManagers);            
            Worker worker3 = new Worker("Лидия", "Ковалева", "Леонидовна", new DateTime(1972, 4, 30),
                                        Gender.FAMALE, Nationality.Ukrainian, EducationLevel.Higher, 1700,
                                        "Уборщица", MyCompany.COMFY, SubordinationLevel.SeniorManagers);            
            Worker worker4 = new Worker("Олег", "Сорока", "Владимировия", new DateTime(1985, 6, 9),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 2400,
                                        "Личный водитель", MyCompany.COMFY, SubordinationLevel.SeniorManagers);            
            Worker worker5 = new Worker("Светлана", "Бунина", "Ивановна", new DateTime(1994, 1, 13),
                                        Gender.FAMALE, Nationality.Ukrainian, EducationLevel.Higher, 900,
                                        "Касир", MyCompany.COMFY, SubordinationLevel.SeniorManagers);

            // Работники менеждера #2.

            Worker worker6 = new Worker("Людмила", "Чума", "Игоревна", new DateTime(1992, 2, 2),
                                        Gender.FAMALE, Nationality.Ukrainian, EducationLevel.Higher, 3400,
                                        "Аналитик комп'ютерних систем", MyCompany.COMFY, SubordinationLevel.MiddleManagers);
            Worker worker7 = new Worker("Петро", "Рог", "Иванович", new DateTime(1979, 12, 1),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 3750,
                                        "Продавец-консультант", MyCompany.COMFY, SubordinationLevel.MiddleManagers);
            Worker worker8 = new Worker("Ольга", "Мищенко", "Романовна", new DateTime(1968, 4, 30),
                                        Gender.FAMALE, Nationality.Ukrainian, EducationLevel.Higher, 1700,
                                        "Уборщица", MyCompany.COMFY, SubordinationLevel.MiddleManagers);
            Worker worker9 = new Worker("Олександ", "Четвертый", "Одлександрович", new DateTime(1984, 3, 19),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 2400,
                                        "Личный водитель", MyCompany.COMFY, SubordinationLevel.MiddleManagers);
            Worker worker10 = new Worker("Леся", "Лазаренко", "Ивановна", new DateTime(1990, 11, 24),
                                        Gender.FAMALE, Nationality.Ukrainian, EducationLevel.Higher, 900,
                                        "Касир", MyCompany.COMFY, SubordinationLevel.MiddleManagers);

            // Работники менеждера #3.

            Worker worker11 = new Worker("Катерина", "Смирна", "Андреевна", new DateTime(1998, 12, 14),
                                        Gender.FAMALE, Nationality.Ukrainian, EducationLevel.Higher, 3400,
                                        "Аналитик комп'ютерних систем", MyCompany.COMFY, SubordinationLevel.MiddleManagers);
            Worker worker12 = new Worker("Дмитрий", "Котовский", "Аркадьевич", new DateTime(1988, 12, 5),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 3750,
                                        "Продавец-консультант", MyCompany.COMFY, SubordinationLevel.MiddleManagers);
            Worker worker13 = new Worker("Лидия", "Ковалева", "Леонидовна", new DateTime(1972, 4, 30),
                                        Gender.FAMALE, Nationality.Ukrainian, EducationLevel.Higher, 1700,
                                        "Уборщица", MyCompany.COMFY, SubordinationLevel.MiddleManagers);
            Worker worker14 = new Worker("Олег", "Сорока", "Владимировия", new DateTime(1985, 6, 9),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 2400,
                                        "Личный водитель", MyCompany.COMFY, SubordinationLevel.MiddleManagers);
            Worker worker15 = new Worker("Светлана", "Бунина", "Ивановна", new DateTime(1994, 1, 13),
                                        Gender.FAMALE, Nationality.Ukrainian, EducationLevel.Higher, 900,
                                        "Касир", MyCompany.COMFY, SubordinationLevel.MiddleManagers);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(ownerOfCompany);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(director1);
            Console.WriteLine(director2);
            Console.WriteLine(director3);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(accountant1);
            Console.WriteLine(accountant2);
            Console.WriteLine(accountant3);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(meneger1);
            Console.WriteLine(meneger2);
            Console.WriteLine(meneger3);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(worker1);
            Console.WriteLine(worker2);
            Console.WriteLine(worker3);
            Console.WriteLine(worker4);
            Console.WriteLine(worker5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(worker6);
            Console.WriteLine(worker7);
            Console.WriteLine(worker8);
            Console.WriteLine(worker9);
            Console.WriteLine(worker10);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(worker11);
            Console.WriteLine(worker12);
            Console.WriteLine(worker13);
            Console.WriteLine(worker14);
            Console.WriteLine(worker15);

        }
    }
}
