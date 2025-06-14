using System;

class Program
{
    static void Main()
    {
        // Task A
        Console.Write("Masukkan nama anda: ");
        string nama = Console.ReadLine();
        Console.WriteLine("Selamat datang, " + nama + "!");

        // Task B
        for (int i = 0; i <= 50; i++)
        {
            if (i == 0)
            {
                Console.WriteLine($"{i} #$#$");
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine($"{i} ##");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine($"{i} $$");
            }
            else
            {
                Console.WriteLine($"{i} ");
            }
        }

        // Task C
        Console.Write("Masukkan angka (1-10000): ");
        int angka = Convert.ToInt32(Console.ReadLine());

        if (angka < 1 || angka > 10000)
        {
            Console.WriteLine("Angka harus berada dalam rentang 1 hingga 10000.");
        }
        else if (ApakahPrima(angka))
        {
            Console.WriteLine($"Angka {angka} merupakan bilangan prima.");
        }
        else
        {
            Console.WriteLine($"Angka {angka} bukan merupakan bilangan prima.");
        }

        static bool ApakahPrima(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}