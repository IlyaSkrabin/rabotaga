using System;

namespace Delete
{
    class Skryaba
    {
        public void skryaba (int x,int y)
        {
            //Даны два натуральных числа.
            // Определить в каком числе больше цифр, для этого создать метод,
            // определяющий количество цифр в числе. 
            int c = 0;
            int k = 0;

            while (x > 0)
            {
                x /= 10;
                c++;
            }
            while (y > 0)
            {
                y /= 10;
                k++;
            }
            if (c > k)
            {
                Console.WriteLine("В первом числе больше цифр, чем во втором");
            }
            else
            {
                if (c < k)
                {
                    Console.WriteLine("Во втором числе больше цифр, чем в первом");
                }
                else
                {
                    Console.WriteLine("Колличество цифр в числе одинаково");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Skryaba resh = new Skryaba();
            Console.WriteLine("Введите первое число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int y = Convert.ToInt32(Console.ReadLine());
            resh.skryaba(x,y);
        }
    }
}
