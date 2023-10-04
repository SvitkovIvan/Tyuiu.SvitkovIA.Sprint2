using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SvitkovIA.Sprint2.Task2.V7.Lib;

namespace Tyuiu.SvitkovIA.Sprint2.Task2.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                DataService dataService = new DataService();

                Console.Title = "Спринт #2 | Выполнил: Свитков И. А. | АСОиУб-23-2";
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Спринт #2                                                               *");
                Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
                Console.WriteLine("* Задание #2                                                              *");
                Console.WriteLine("* Вариант #7                                                              *");
                Console.WriteLine("* Выполнил: Свитков Иван Андреевич | АСОиУб-23-2                          *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                *");
                Console.WriteLine("* Написать программу на,                                                  *");
                Console.WriteLine("* которая запрашивает целые значения с клавиатуры и вычисляет             *");
                Console.WriteLine("* находится ли точка с координатами X,Y в заштрихованной области.         *");
                Console.WriteLine("*                                                                         *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");

                Console.Write("Введите значение переменной X: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите значение переменной Y: ");
                int y = Convert.ToInt32(Console.ReadLine());

                bool res = dataService.CheckDotInShadedArea(x, y);

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                if (res) Console.WriteLine("Точка находится в заштрихованной области");
                else Console.WriteLine("Точка не находится в заштрихованной области");

                Console.ReadKey();
            }
        }
    }
}
    

