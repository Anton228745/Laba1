using System;
using CoreLibrary;

class Program
{
    static void Main()
    {
       
        Console.Write("Введите число N для последовательности (1...N): ");
        if (int.TryParse(Console.ReadLine(), out int nSeq) && nSeq > 0)
        {
            string seqResult = NumberSequence.Generate(nSeq);
            Console.WriteLine($"Результат: {seqResult}\n");
        }
        else
        {
            Console.WriteLine("Некорректный ввод для последовательности.\n");
        }

        // квадрат из звёздочекы
        Console.Write("Введите нечётное положительное число N для квадрата со звёздочками: ");
        if (int.TryParse(Console.ReadLine(), out int nSquare) && nSquare > 0 && nSquare % 2 != 0)
        {
            string squareResult = StarSquare.Generate(nSquare);
            Console.WriteLine("Результат:");
            Console.WriteLine(squareResult);
        }
        else
        {
            Console.WriteLine("Ошибка: число должно быть положительным и нечётным!");
        }
    }
}