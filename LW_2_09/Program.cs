using System;

namespace LW_2_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }

        static void Task1()
        {
            Uravnenie ur = new(2, 5, 3);
            Console.WriteLine("Задание 1");

            double[] res1 = ur.Solution();
            double[] res2 = Uravnenie.Solution(2, 5, 3);

            Console.WriteLine("Решение уравнения через вызов метода экземпляра");
            PrintSolution(res1);
            Console.WriteLine("Решение уравнения через вызов статического метода");
            PrintSolution(res2);

            Console.WriteLine($"Количество созданных экземпляров класса = {Uravnenie.GetCounter()}");
        }

        static void Task2()
        {
            Console.WriteLine("\nЗадание 2");

            Uravnenie ur1 = new(2, 5, 3);

            Console.WriteLine($"Решение уравнения для параметров: a = {ur1.A} b = {ur1.B} c = {ur1.C}");
            PrintSolution(ur1.Solution());

            ur1--;

            Console.WriteLine("Применен декремент");
            Console.WriteLine($"Решение уравнения для параметров: a = {ur1.A} b = {ur1.B} c = {ur1.C}");
            PrintSolution(ur1.Solution());

            ur1++;

            Console.WriteLine("Применен инкремент");
            Console.WriteLine($"Решение уравнения для параметров: a = {ur1.A} b = {ur1.B} c = {ur1.C}");
            PrintSolution(ur1.Solution());

            double t1 = (double)ur1;
            Console.WriteLine("Неявное привидение к double = " + t1);
            bool t2 = ur1;
            Console.WriteLine("Неявное привидение к bool = " + t2);

            Uravnenie ur2 = new(4, 10, 4);
            Console.WriteLine($"Сравнение {ur1} и {ur2}");
            Console.WriteLine($"ur1 == ur2 :{ur1 == ur2}");
            Console.WriteLine($"ur1 != ur2 :{ur1 != ur2}");

            Console.WriteLine($"Количество созданных экземпляров класса = {Uravnenie.GetCounter()}");
        }

        static void Task3()
        {
            Console.WriteLine("\nЗадание 3");

            double[][] sets = { new double[] { 1, 5, 6 }, new double[] { 7, 2, 9 } };

            UravnenieArray ar1 = new();
            UravnenieArray ar2 = new(5);
            UravnenieArray ar3 = new(sets);

            Console.WriteLine("Массив 1" + "\n" + ar1);
            Console.WriteLine("\nМассив 2" + "\n" + ar2);
            Console.WriteLine("\nМассив 3" + "\n" + ar3);

            Console.WriteLine("3-й элемент 2-го массива = " + ar2[2]);

            Console.WriteLine($"Уравнение с максимальным решением в 3-ем массиве = {ar3.FindMaxAbsoluteSolution()}");
        }

        static void PrintSolution(double[] sol)
        {
            if (sol != null)
            {
                for (int i = 0; i < sol.Length; i++)
                {
                    Console.WriteLine(sol[i]);
                }
            }
            else
            {
                Console.WriteLine("Решений нет");
            }
        }
    }
}
