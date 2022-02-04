using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Описать класс для работы с двумерным массивом вещественных чисел. 
Обеспечить добавление к первому столбцу столбца заданного номера (перегрузка операции +). 

Как сделать перегрузкой я не понял, т.к. "+" это бинарный оператор и к нему нужно два параметра, а это два двухмерный массива. А в задании нам надо сложить строку к первой строке, а массив с массиво. 
Может я что-то и не понял...
 */

namespace TwoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array(3, 3);


            array.FillArray();

            Console.WriteLine("\nИсходная");
            array.PrintArray();

            array.SumCol();


            Console.WriteLine();
            Console.WriteLine("\nИзмененная");
            array.PrintArray();


            Console.ReadKey();
        }
    }
}
