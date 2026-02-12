using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to check if it's an integer:(整数かどうかを確認するには数値を入力してください)");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            Console.WriteLine($"'{input}' is a valid integer.整数です");
        }
        else
        {
            Console.WriteLine($"'{input}' is not a valid integer.整数ではありません");
        }
    }
}
