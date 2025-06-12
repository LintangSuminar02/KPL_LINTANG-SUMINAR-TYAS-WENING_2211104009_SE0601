using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPmodul7_2211104009
{
    class KuliahMahasiswa
    {
        public class Course
        {
            public string Code { get; set; }
            public string Name { get; set; }
        }

        public class CourseList
        {
            public List<Course> Courses { get; set; }
        }

        public static void ReadJSON()
        {
            string filePath = "tp7_2_2211104009.json";

            // Cek apakah file JSON ada
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File JSON tidak ditemukan.");
                return;
            }

            // Membaca isi file JSON
            string jsonContent = File.ReadAllText(filePath);

            // Melakukan deserialisasi JSON ke objek
            CourseList data = JsonConvert.DeserializeObject<CourseList>(jsonContent);

            // Menampilkan hasil
            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int index = 1;
            foreach (var course in data.Courses)
            {
                Console.WriteLine($"MK {index} {course.Code} - {course.Name}");
                index++;
            }
        }
    }
}
