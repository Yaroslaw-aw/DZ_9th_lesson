//Задача 68: Напишите программу вычисления функции Аккермана
//    с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29

namespace DZ_9th_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Функция Аккермана от n и m");

            int n = Input("Введите n: ");
            int m = Input("Введите m: ");

            if (m < 0 || n < 0)
            {
                Console.WriteLine("Введены неправильные значения");
            }
            else
            {
                Console.WriteLine($"Функция Аккермана от {n}(n) и {m}(m) равна: {Akkerman(n, m)}");
            }

            // Вычисление функции Аккермана
            int Akkerman(int n, int m)
            {
                if (n == 0)
                    return m + 1;
                else if (m == 0)
                    return Akkerman(n - 1, 1);
                else
                return Akkerman(n - 1, Akkerman(n, m - 1));
            }


            // Ввод значения
            int Input(string message)
            {
                int n;
                Console.Write(message);
                bool input = int.TryParse(Console.ReadLine(), out n);

                if (!input)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введено неверное значение, попробуйте еще раз");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Input(message);
                }
                return n;
            }
        }
    }
}