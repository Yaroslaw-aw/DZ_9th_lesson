//Задача 66: Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30


namespace DZ_9th_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.Write("Введите число M: ");
            int.TryParse(Console.ReadLine(), out m);

            int n;
            Console.Write("Введите число N: ");
            int.TryParse(Console.ReadLine(), out n);            

            Console.WriteLine(Digits_Sum(m, n));

            int Digits_Sum(int m, int n)
            {
                if (m >= n)
                    return m;
                return m + Digits_Sum(m + 1, n);
            }
        }
    }
}