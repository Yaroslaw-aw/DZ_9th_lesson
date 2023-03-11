//Задача 64: Задайте значение N. Напишите программу,
//которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


namespace DZ_9th_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите число N: ");
            int.TryParse(Console.ReadLine(), out n);            

            Console.WriteLine(Descended_numbers(n));

            string Descended_numbers(int n, int i = 1)
            {
                if (i >= n)
                    return i.ToString();
                return $"{n}, {Descended_numbers(n - 1, i)}";
            }
        }
    }
}