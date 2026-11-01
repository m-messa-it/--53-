using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string path = "numbers.txt";

        // Крок 1: створення файла і запис першого числа
        Console.WriteLine("=== Крок 1: Запис числа у файл ===");
        int firstNumber = 1;
        using (StreamWriter writer = new StreamWriter(path))
        {
            writer.WriteLine(firstNumber.ToString("D8"));
        }
        Console.WriteLine($"Записано число: {firstNumber.ToString("D8")}");

        // Крок 2: читання числа з файла
        Console.WriteLine("\n=== Крок 2: Читання числа з файла ===");
        using (StreamReader reader = new StreamReader(path))
        {
            string? line = reader.ReadLine();
            if (line != null)
            {
                int readNumber = int.Parse(line);
                Console.WriteLine($"Прочитаний рядок: {line}");
                Console.WriteLine($"Перетворене число: {readNumber}");
            }
        }

        // Крок 3: дописування ще двох чисел
        Console.WriteLine("\n=== Крок 3: Дописування двох чисел ===");
        int secondNumber = 42;
        int thirdNumber = 256;
        using (StreamWriter writer = new StreamWriter(path, append: true))
        {
            writer.WriteLine(secondNumber.ToString("D8"));
            writer.WriteLine(thirdNumber.ToString("D8"));
        }
        Console.WriteLine($"Дописано: {secondNumber.ToString("D8")}");
        Console.WriteLine($"Дописано: {thirdNumber.ToString("D8")}");

        // Крок 4: читання всіх рядків з номерами
        Console.WriteLine("\n=== Крок 4: Вміст файла ===");
        using (StreamReader reader = new StreamReader(path))
        {
            int number = 1;
            string? line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine($"{number}: {line}");
                number++;
                line = reader.ReadLine();
            }
        }
    }
}
