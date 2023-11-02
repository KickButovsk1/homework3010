using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex12();
            //ex3();
            //ex4();
            //ex5();
            //ex6();
            ex7();
        }

        private static void ex7()
        {
            using (StreamWriter sw = new StreamWriter("CDriveDirs.txt"))
            {
                sw.WriteLine("Расписание звонков :");
                TimeSpan interval = new TimeSpan(8, 30, 00);
                Console.Write(interval.ToString("hh\\:mm") + " - ");
                for (int i = 0; i < 9; i++)
                {
                    interval = interval + TimeSpan.FromMinutes(40);
                    Console.WriteLine(interval.ToString("hh\\:mm"));
                    interval += TimeSpan.FromMinutes(20);
                    Console.Write(interval.ToString("hh\\:mm") + " - ");
                    sw
                }
                interval = interval + TimeSpan.FromMinutes(40);
                Console.WriteLine(interval.ToString("hh\\:mm"));
                
            }
            Console.ReadKey();
        }

        private static void ex6()
        {
            TimeSpan interval = new TimeSpan(6, 00, 00);
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int w = rnd.Next(1, 15);
                interval = interval + TimeSpan.FromMinutes(w);
                Console.WriteLine(interval.ToString("hh\\:mm"));
            }
        }

        private static void ex5()
        {
            TimeSpan interval = new TimeSpan(12, 00, 00);
            TimeSpan time = new TimeSpan(18, 00, 00);
            for (int i = 0; interval < time; i++)
            {
                interval = interval + TimeSpan.FromMinutes(15);
                Console.WriteLine(interval);
            }
        }

        private static void ex4()
        {
            TimeSpan interval = new TimeSpan(8, 00, 00);
            Random rnd = new Random();
            int w = rnd.Next(15, 100);
            Console.WriteLine("До прибавления :"+interval);
            TimeSpan time = interval+TimeSpan.FromMinutes(w);
            Console.WriteLine("После прибавления:"+time);
        }
            private static void ex3()
        {
            Random rnd = new Random();
            int hours = rnd.Next(0, 23);
            int minutes = rnd.Next(0, 59);
            int seconds = rnd.Next(0, 59);
            DateTime date = DateTime.Now;
            TimeSpan interval = new TimeSpan(hours, minutes, seconds);
            Console.WriteLine($"Приглашаю на собрание сегодня {date.Day}.{date.Month}.{date.Year} в {interval}");
        }

        private static void ex12()
        {
            TimeSpan interval = new TimeSpan(8, 00, 00);
            Console.WriteLine(interval.ToString("hh\\:mm"));
        }
    }
}
