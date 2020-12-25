using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2_TeamWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0, B = 0, choice;

            Console.WriteLine("1. Ввести число A");
            Console.WriteLine("2. Ввести число B");
            Console.WriteLine("3. Сложить A и B");
            Console.WriteLine("4. Вычесть B из A");
            Console.WriteLine("5. Умножить A на B");
            Console.WriteLine("6. Разделить A на B");

            Console.ReadKey();
        }

        static int Enter_A()
        {
            Console.Write("Введите число A: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
