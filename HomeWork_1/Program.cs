using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи ('2', '4', '6' или'8'): ");

            int task_number = int.Parse(Console.ReadLine());

            switch (task_number)
            {
                case 2:
                    Task_2();
                    break;
                case 4:
                    Task_4();
                    break;
                case 6:
                    Task_6();
                    break;
                case 8:
                    Task_8();
                    break;
                default:
                    Console.WriteLine("Вы ввели неверное значение");
                    break;
            }
            Task_8();
        }

        static void Task_2()
        {
            int max;

            Console.WriteLine("Введите первое число: ");

            int firstValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");

            int secondValue = int.Parse(Console.ReadLine());

            if (firstValue < secondValue)
            {
                max = secondValue;
            }
            else
            {
                max = firstValue;
            }
            Console.WriteLine(max);
        }//Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

        static void Task_4()
        {
            int max;

            Console.WriteLine("Введите первое число: ");

            int firstValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");

            int secondValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число: ");

            int thirdValue = int.Parse(Console.ReadLine());

            if (firstValue < secondValue)
            {
                if (secondValue < thirdValue)
                {
                    max = thirdValue;
                }
                else
                {
                    max = secondValue;
                }
            }
            else
            {
                max = firstValue;
            }
            Console.WriteLine(max);
        }//Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

        static void Task_6()
        {
            Console.WriteLine("Введите число: ");

            int value = int.Parse(Console.ReadLine());

            if (value % 2 == 0)
            {
                Console.WriteLine("Число " + value + " чётное");
            }
            else
            {
                Console.WriteLine("Число " + value + " нечётное");
            }
        }//Программа, которая на вход принимает число и выдаёт, является ли число чётным.

        static void Task_8()
        {
            Console.WriteLine("Введите число: ");

            int value = int.Parse(Console.ReadLine());

            for (int i = 1; i <= value; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }//Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    }
}
