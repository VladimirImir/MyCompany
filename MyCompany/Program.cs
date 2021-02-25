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

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(ownerOfCompany);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(director1);
            Console.WriteLine(director2);
            Console.WriteLine(director3);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(meneger1);
            Console.WriteLine(meneger2);
            Console.WriteLine(meneger3);




            // Работники.

            Worker worker3 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker4 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker5 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker6 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker7 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker8 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker9 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker10 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker11 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker12 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker13 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker14 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker15 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker16 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker17 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker18 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker19 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker20 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker21 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker22 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker23 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker24 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");            
            Worker worker25 = new Worker("Олександр", "Гринюк", "Миколайович", new DateTime(1978, 8, 18),
                                        Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                        "Колоть дрова");


















/*            ListOfWorkers listOfWorkers = new ListOfWorkers();
            for (int i = 0; i < 25; i++)
            {

                listOfWorkers.AddWorker(new Worker("worker_" + 1, "tested", "tested",
                                                    DateTime.Now, Gender.FAMALE, Nationality.Argentina,
                                                    EducationLevel.Higher, 1000, "Рабоатет."));
            }
            Console.WriteLine(listOfWorkers);*/


            /*                        listOfWorkers[5] = new Worker();
                                    Console.WriteLine(((Worker)listOfWorkers[5]).Name); // по индексу.*/

            /*            Console.WriteLine(((Worker)listOfWorkers[listOfWorkers.Workers[5]]).Name);// через ссылку на объект.
                        listOfWorkers[listOfWorkers.Workers[6]] = new Worker();
                        Console.WriteLine(((Worker)listOfWorkers[listOfWorkers.Workers[6]]));
                        Console.WriteLine(worker);*/
            /*            Worker worker = new Worker("Владимир", "Полтавченко", "Русланович", new DateTime(1979, 11, 28),
                                                                    Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                                                    "Колоть дрова");
                        Worker worker1 = new Worker("Владимир", "Полтавченко", "Русланович", new DateTime(1979, 11, 28),
                                                                    Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                                                    "Колоть дрова");
                        Console.WriteLine(worker);
                        Console.WriteLine(worker1);*/

        }
    }
}
