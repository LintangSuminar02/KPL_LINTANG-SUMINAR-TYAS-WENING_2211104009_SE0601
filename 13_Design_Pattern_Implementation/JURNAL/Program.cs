using System;

namespace modul13_2211104009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Nama : Lintang Suminar Tyas Wening ");
            Console.WriteLine(" NIM  : 2211104009 ");
            Console.WriteLine(" Kelas: SE0601 ");

            // Membuat dua variable Singleton
            PusatDataSingleton data1 = PusatDataSingleton.GetDataSingleton();
            PusatDataSingleton data2 = PusatDataSingleton.GetDataSingleton();

            // Menambahkan data (nama anggota kelompok dan asisten)
            data1.AddSebuahData("Nama Anggota 1: Aufa");
            data1.AddSebuahData("Nama Anggota 2: Rezky");
            data1.AddSebuahData("Nama Anggota 3: Doanta");
            data1.AddSebuahData("Nama Asisten Praktikum: Imelda dan Naufal");

            // Mencetak semua data melalui data2 (harusnya sama dengan data1)
            Console.WriteLine("\n ======= Data pada data2 ======= ");
            data2.PrintSemuaData();

            // Menghapus nama asisten praktikum
            data2.HapusSebuahData(3); // Hapus asisten praktikum di index ke-3

            // Mencetak kembali data melalui data1 (asisten harus sudah terhapus)
            Console.WriteLine("\n ======= Data pada data1 setelah penghapusan ======= ");
            data1.PrintSemuaData();

            // Mencetak jumlah data pada kedua variabel
            Console.WriteLine("\n Jumlah data pada data1: " + data1.GetSemuaData().Count);
            Console.WriteLine(" Jumlah data pada data2: " + data2.GetSemuaData().Count);
        }
    }
}