using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerApp1._2
{
    public static class Repeater
    {
        //ID точки
        public static int PointId { get; set; }

        //Поля-счетчики
        public static int AmountOfLines { get; set; }
        public static int AmountOfClicks { get; set; }

        //Поля, хранящие путь к файлам
        public static string PathFrom { get; set; }
#if DEBUG
        public static string PathIn { get; set; }
#endif
        //Задержка
        public static int Delay { get; set; } = 2;

        //Контейнер имен
        //public static List<string> NamesList;

        //Контейнер методов
        public static List<string> MethodsList;

        //Функция сброса
        public static void Reset()
        {
            PointId =
                AmountOfLines =
                    AmountOfClicks = 0;

            MethodsList?.Clear();

            MethodsList = new List<string>
            {
                "MouseClick",
                "MouseDoubleClick",
                "MouseRightClick",
                "InsertText",
                "InsertJobs"
            };
        }
    }
}
