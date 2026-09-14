using Tyuiu.PolyakovaAB.Sprint1.Task3.V2.Lib;
namespace Tyuiu.PolyakovaAB.Sprint1.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int b, d;
            float a, c;

            Console.Title = "Спринт #1 | Выполнила: Полякова А. В. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Полякова Арина Вячеславовна | ИИПб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления стоимости покупки, состоящей из нескольких*");
            Console.WriteLine("* тетрадей и карандашей.                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Цена тетрадей.                                                          *");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("* Количество тетрадей.                                                    *");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Цена карандашей.                                                        *");
            c = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("* Количество карандашей.                                                  *");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.PurchaseAmount(a, b, c, d));
            Console.ReadKey();
        }
    }
}
