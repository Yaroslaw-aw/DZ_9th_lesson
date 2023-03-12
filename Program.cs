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
            Console.WriteLine("Функция Аккермана от m и n");

            int m = Input("Введите m: ");
            int n = Input("Введите n: ");            

            if (m < 0 || n < 0)
            {
                Console.WriteLine("Введены неправильные значения");
            }
            else
            {
                Console.WriteLine($"Функция Аккермана от {m}(m) и {n}(n) равна: {Akkerman(n, m)}");
            }

            // Вычисление функции Аккермана
            int Akkerman(int m, int n)
            {
                if (m == 0)
                    return n + 1;
                else if (n == 0)
                    return Akkerman(m - 1, 1);
                else
                return Akkerman(m - 1, Akkerman(m, n - 1));
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