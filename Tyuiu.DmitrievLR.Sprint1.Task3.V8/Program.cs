using Tyuiu.DmitrievLR.Sprint1.Task3.V8.Lib;
namespace Tyuiu.DmitrievLR.Sprint1.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Дмитриев Леонид Романович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                            *");
            Console.WriteLine("* Выполнил: Дмитриев Леонид Романович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("* Написать программу вычисления величины дохода по вкладу. Процентная           *");

            Console.WriteLine("* ставка (% годовых) и время хранения (дней) задаются во время работы программы *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите величину вклада:");
            double startAmount1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Процентную ставкe (% - годовых) в процентах :");
            double percent1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите время хранения (в днях): ");
            double timeDays1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
             
            DataService ds = new DataService();

            var result = ds.IncomeAmount(startAmount1, percent1, timeDays1);
            Console.Write("Доход по вкладу: ");
            Console.WriteLine(Math.Round(result, 2) + " руб.");
            Console.WriteLine("Сумма дохода по вкладу: " + (Math.Round(startAmount1 +result, 2)) +" руб.");
            Console.ReadKey();
        }
    }
}