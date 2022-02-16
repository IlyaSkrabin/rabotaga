using System

namespace MethodAray
{
   class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("найти разность между максимальными и минимальными элементами массива + 
           2.Поменять местами макс и мин элемент массива. + 3.Отсортировать массив");
           Console.WriteLine("ВВедите количествоэлементов в масиве: ");
           int s = Convert.ToInt32(Console.ReadLine());


       }
       static Array meArray(int s) 
       {
           int[] meArray = new int[s];
           Random rand = new Random();
           for (int i = 0; i < length; i++)
           {
              MyArray[i] = rand.Next(20);
              Console.WriteLine($"Значение {i}-го элемента массива = {myArray[x]}");
           }
       }
       static int MAXMIN()
       {
           int max = int.MinValue;
           int min = 0;
               int max = myArray.Max();
               int min = myArray.Min();
           Console.WriteLine("");
           Cosole.WriteLine($"Максимальное значение: {max}");
           Cosole.WriteLine($"Максимальное значение: {min}");
           Console.WriteLine("********")
           Console.WriteLine($"Max - Min = {max - min}");
           Console.ReadKey();
       }
       

   } 
}
