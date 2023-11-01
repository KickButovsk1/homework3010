using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            //GetSymbols(str);
            //Ex2(str);
            //Ex3(str);
            //Ex4(str);
            //int collichestvo = Convert.ToInt32(Console.ReadLine());
            //Ex5(str, collichestvo);
            //Ex6(str);
            //Ex7(str);
            //ex8(str);
            //ex9(str);
            //ex10(str);
            //ex11(str);
            //ex12(str);
            //ex13(str);
            //ex15(str);  
            //ex16(str);
            //ex17(str);
        }
        private static void ex17(string str)
        {
            int w = str.Split(' ').Length;
            if (w > 3)
            {
                Console.WriteLine("больше");
            }
            else
            {
                Console.WriteLine("не больше");
            }
        }

        private static void ex16(string str)
        {
            int w = 0;
            string glasnie = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
            foreach (char item in str)
            {
                if (glasnie.Contains(item))
                {
                    w++;
                }
            }
            Console.WriteLine(w);
        }

        private static void ex8(string str)
        {
            string str1 = Console.ReadLine();
            int strpervoe = str.Length;
            int strvtoroe = str1.Length;
            string novoeslovo = str1.Replace(strvtoroe.ToString(), strpervoe.ToString());
            Console.WriteLine(novoeslovo);
        }

        private static void ex11(string str)
        {
            char char1 = 'a';
            char char2 = 'n';
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == char1)
                {
                    Console.WriteLine(i);
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == char2)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void ex15(string str)
        {
            int w = 0; int a = 0;
            foreach (char item in str)
            {
                if (item == '+')
                {
                    w = w + 1;
                }
                if (item == '?')
                {
                    a = a + 1;
                }
            }
            Console.WriteLine("Плюсов " + w);
            Console.WriteLine("Знаков вопроса " + a);
        }

        private static void ex13(string str)
        {
            int w = 0;
            foreach (char item in str)
            {
                if (item == ' ')
                {
                    w = w + 1;
                }
            }
            Console.WriteLine(w);
        }

        private static void ex12(string str)
        {
            for (int i = 0; i < str.Length; i = i + 4)
            {
                Console.WriteLine(str[i]);
                int w = i + 1;
                Console.WriteLine(str[w]);
            }
        }

        private static void ex10(string str)
        {
            for (int i = 2; i < str.Length; i = i + 3)
            {
                Console.WriteLine(str[i]);
            }
        }

        private static string ex9(string str)
        {
            string result = String.Empty;
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'и')
                {
                    result = result + "и";
                }
            }
            Console.WriteLine(result);
            return str;
        }

        private static void Ex7(string str)
        {
            StringBuilder str2 = new StringBuilder();
            int l = str.Length;
            str2.Insert(0, "*", l);
            str2.Insert(str.Length, str);
            int h = str2.Length;
            str2.Insert(str2.Length, "*", l);



            Console.WriteLine(str2);

        }
        private static void Ex6(string str)
        {
            StringBuilder str2 = new StringBuilder();
            string plusi = "++++";
            string minusi = "-----";
            str2.Insert(0, str);
            str2.Insert(0, plusi);
            str2.Insert(str2.Length, minusi);
            Console.WriteLine(str2);
        }
        private static void Ex5(string str, int collichestvo)
        {

            for (int i = 0; i < collichestvo; i++)
            {
                Console.WriteLine(str);
            }
        }
        private static void Ex4(string str)
        {
            StringBuilder t = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                t.Append(str[i]);
            }
            Console.WriteLine(t);
        }
        private static void Ex3(string str)
        {
            StringBuilder str2 = new StringBuilder();
            for (int i = 0; i < str.Length; i += 2)
            {
                str2.Append(str[i]);
            }
            Console.WriteLine(str2);
        }

        private static void Ex2(string str)
        {
            StringBuilder str2 = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                str2.Append(str[i]);
            }
            Console.Write(str2);
        }

        /// <summary>
        /// Печать символа столбиком
        /// </summary>
        /// <param name="str"></param>
        private static void GetSymbols(string str)
        {
            foreach (char item in str)
            {
                Console.WriteLine(item);
            }
        }
    }
}
