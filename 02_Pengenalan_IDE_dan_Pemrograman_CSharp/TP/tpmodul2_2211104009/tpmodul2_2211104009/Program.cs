// See https://aka.ms/new-console-template for more information

// Bagian A
using System;
class Program
{
    static void Main()
    {
        Console.Write("Masukkan satu huruf: ");
        char inputHuruf = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();
        if (inputHuruf == 'A' || inputHuruf == 'I' || inputHuruf == 'U' || inputHuruf == 'E' || inputHuruf == 'O')
        {
            Console.WriteLine($"Huruf {inputHuruf} merupakan huruf vokal");
        }
        else if (Char.IsLetter(inputHuruf))
        {
            Console.WriteLine($"Huruf {inputHuruf} merupakan huruf konsonan");
        }
        else
        {
            Console.WriteLine("Input bukan huruf yang valid.");
        }
    }
}

// Bagian B
//using System;
//class Program
//{
//    static void Main()
//    {
//        int[] angkagenap = { 2, 4, 6, 8, 10 };
//        for (int i = 0; i < angkagenap.Length; i++)
//        {
//            Console.WriteLine($"Angka genap {i + 1} : {angkagenap[i]}");
//        }
//    }
//}
