using System;
using System.IO;
using Newtonsoft.Json;

namespace TPmodul7_2211104009
{
    public class NamaMahasiswa
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class DataMahasiswa2211104009
    {
        public NamaMahasiswa nama { get; set; } // Properti nama adalah objek NamaMahasiswa
        public string nim { get; set; }
        public string fakultas { get; set; }

        public static void ReadJSON()
        {
            string path = "tp7_1_2211104009.json"; // Sesuaikan path

            if (File.Exists(path))
            {
                string jsonData = File.ReadAllText(path);

                DataMahasiswa2211104009 mahasiswa = JsonConvert.DeserializeObject<DataMahasiswa2211104009>(jsonData);

                if (mahasiswa != null && mahasiswa.nama != null)
                {
                    Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan NIM {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
                }
                else
                {
                    Console.WriteLine("Gagal melakukan deserialisasi JSON atau data tidak lengkap.");
                }
            }
            else
            {
                Console.WriteLine("File JSON tidak ditemukan! Pastikan file berada di folder output aplikasi atau path sudah benar.");
            }
        }
    }
}