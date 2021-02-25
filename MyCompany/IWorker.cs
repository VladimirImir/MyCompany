using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    interface IWorker
    {
        string Work(); // Раз рабочий - значит работать.
        bool IsWorking { get; } // Статус выполнения работы - работает или нет.
    }
}
