using System;
using Library1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using static Two.Program;

namespace Two
{
    internal class Program
    {
        
        public delegate bool Del(object obj1, object obj2);
        delegate Boolean Filter(int number);
        //Метод для отримання усіх простих чисел у масиві; 
        class prime
        {
           public object[] qws = { 1, 2, 3, 4, 5, 9, 8, 7, 6, 10 };

            public static bool prim (int number)
            {
                if (number <= 1)
                    return false;

                if (number == 2)
                    return true;

                if (number % 2 == 0)
                    return false;

                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                        return false;
                }

                return true;
            }
        }
        public void Prime(Filter F, object[] qws)
        {
           
            int count = 0;
            int[] temp = new int[qws.Length];

            for (int i = 0; i < qws.Length; i++)
            {
                if (qws[i] is int number && F(number))
                {
                    temp[count++] = number;
                }
            }

            Console.WriteLine("Prime numbers:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(temp[i]);
            }
        }
    }

//    Метод для отримання усіх парних чисел у масиві; 
//■ Метод для отримання усіх непарних чисел у масиві;

    static class Programs
        {
            
            public static bool CompareOne(object obj1, object obj2)
            {
                return (int)obj1 > (int)obj2;
            }

            public static bool CompareTwo(object obj1, object obj2)
            {
                return (int)obj1 < (int)obj2;
            }

            
            public static void Addeven(object[] add, Del dg)
            {
                for (int i = 0; i < add.Length; i++)
                {
                    for (int j = i + 1; j < add.Length; j++) 
                    {
                        if (dg(add[i], add[j]))
                        {
                            object temp = add[i];
                            add[i] = add[j];
                            add[j] = temp;
                        }
                    }
                }
            }
        }

//    Завдання 2 Створіть набір методів:
//■ Метод відображення поточного часу; 
//■ Метод відображення поточної дати; 
//■ Метод відображення поточного дня тижня; 
//■ Метод для підрахунку площі трикутника; 
//■ Метод для підрахунку площі прямокутника.

    public delegate void DisplayDelegate();

    public delegate double AreaDelegate(double x, double y);

    class Program
    {
        public static void ShowCurrentTime()
        {
            Console.WriteLine("Current Time: " + DateTime.Now.ToString("HH:mm:ss"));
        }

        public static void ShowCurrentDate()
        {
            Console.WriteLine("Current Date: " + DateTime.Now.ToString("yyyy-MM-dd"));
        }

        public static void ShowCurrentDayOfWeek()
        {
            Console.WriteLine("Current Day of Week: " + DateTime.Now.DayOfWeek);
        }

        public static double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public static double CalculateRectangleArea(double width, double height)
        {
            return width * height;
        }


        static void Main(string[] args)
        {
            
            object[] qws = { 1, 2, 3, 4, 5, 9, 8, 7, 6, 10 };

            Del d = new Del(Programs.CompareOne);
            Del dtwo = new Del(Programs.CompareTwo);

            Programs.Addeven(qws, d);

            Console.WriteLine("Sorted using CompareOne:");
            foreach (object o in qws)
            {
                Console.WriteLine(o);
            }

            Programs.Addeven(qws, dtwo);

            Console.WriteLine("\nSorted using CompareTwo:");
            foreach (object o in qws)
            {
                Console.WriteLine(o);
            }
        }
    }



