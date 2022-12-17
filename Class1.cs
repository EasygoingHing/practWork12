using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Крутолапов_пр12
{
    internal class Class1
    {
        /// <summary>
        /// Вычисляет площадь и периметр квадрата
        /// </summary>
        /// <param name="side">Сторона</param>
        /// <param name="square">Площадь</param>
        /// <param name="perimetr">Периметр</param>
        static public string SquareAndPerimetr(int side)
        {
            return $"Площадь - {side * side}\nПериметр - {side * 4}";
        }

        /// <summary>
        /// Меняет местами единицы и десятки, откидывая сотни
        /// </summary>
        /// <param name="number">Целое число</param>
        /// <returns></returns>
        static public string ReplacingNumbers(int number)
        {
            return $"Единицы числа - {number % 10}\nДесятки - {number % 100 / 10}";
        }
    }
}

