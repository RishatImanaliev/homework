//1. Задание
using System;

class Program
{
    static void PrintNumbersInRange(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(n);
            PrintNumbersInRange(m, n - 1);
        }
    }

    static void Main()
    {
        Console.WriteLine("Начало промежутка (M): ");
        int m = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Конец промежутка (N): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Натуральные числа в промежутке от {m} до {n}:");
        PrintNumbersInRange(m, n);
    }
}

//2. Задание 

using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    static void Main()
    {
        Console.WriteLine("Введите m:");
        int m = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Введите n:");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = Ackermann(m, n);
        Console.WriteLine($"Результат функции Аккермана для m = {m} и n = {n}: {result}");
    }
}

//3. Задание

using System;

class Program
{
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
            PrintArrayReverse(arr, index - 1);
        }
    }

    static void Main()
    {
        int[] array = { 22, 200, 350, 450, 500 };
        Console.WriteLine("Элементы массива, начиная с конца:");
        PrintArrayReverse(array, array.Length - 1);
    }