using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    // Циклы WHILE, DO WHILE, FOR
    class Program
    {
        static void Main(string[] args)
        {
            // WHILE

            /*            int i = 0; // i - Итератор
                        while (i < 10) // (i < 10) - Условие
                        {
                            Console.WriteLine("Цикл while выполнен - " + ++i + " раз"); // Логика
                        }

                        Console.WriteLine("Цикл while завершен!");
                        */

            /*
            int i = 0;
            bool whileCondition = false;
            while (!whileCondition)
            {                
                Console.WriteLine("Цикл while выполнен - " + ++i + " раз");
                if (i == 10)
                {
                    whileCondition = true;
                }
            }
            Console.WriteLine("Цикл while завершен!");
            */

            /*
            int i = 0;
            while (true)
            {
                Console.WriteLine("Цикл while выполнен - " + ++i + " раз");
            }
            Console.WriteLine("Цикл while завершен!"); // Цикл while бесконечен(в данном примере завершится ошибкой при переполнении регистра переменной i)
            */


            //Операторы break и continue

            /*
            int i = 0;
            while (true)
            {
                Console.WriteLine("Цикл while выполнен - " + ++i + " раз");
                if (i == 100)
                {
                    break; // Прерывает цикл в котором всречается;
                }
            }
            Console.WriteLine("Цикл while завершен!");
            */

            /*
            int i = 50;
            while (i < 10)
            {
                i++;                
                if (i % 2 == 1)
                {
                    continue; // Прерывает дальнейшее выполнение логики в блоке цикла. Переходит к следующей итерации.
                }
                Console.WriteLine("Итерация № " + i);
            }

            Console.WriteLine("Цикл while завершен!");
            */

            // Операторы return и throw

            //Console.WriteLine("Результат: " + ReturnMethod());

            //ThrowMethod();

            //DO WHILE

            /*
            int i = 0;
            do
            {
                // Логика в блоке DO выполняется до проверки условия в блоке WHILE.
                // То есть не зависимо от результата проверки условия блок DO выполнится хотя бы 1 раз.
                i += 5;
                Console.WriteLine("i = " +i);
            } while (i < 15);
            */

            //FOR

            // int i = 0 - Инициализатор. Объявление и присвоение значения итератору
            // i < 10 - Условие. Условие при выполнении которого будет выполнена логика находящаяся внутри цикла
            // i++ Итератор. Отвечает за изменение значения переменной итератора

            /*
            int i = 0;
            for (;;)
            {
                // Блок логики
                if (i > 10)
                {
                    break;
                }
                Console.WriteLine("Цикл for. Итерация № " + ++i);
            }
            Console.WriteLine("Цикл for завершен!");
            Console.WriteLine(i);
            */
            /*
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Цикл \\1\\, итерация - " + i);
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("\tЦикл 2, итерация - " + j);
                }
            }
            */

            Test2();
        }

        private static void Test2()
        {
            
        }

        private static double ThrowMethod()
        {
            throw new Exception("Сообщение!"); // Завершает метод путем выброса исключения
        }

        private static double ReturnMethod()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("Цикл while выполнен - " + ++i + " раз");
                if (i == 100)
                {
                    return 500.12; // Прерывает выполнение метода(в данном примере ReturnMethod()) и возвращает значение;
                }
            }
        }
    }
}
