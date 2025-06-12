using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace tpmodul9_2211104009
{
    [ApiController]
    [Route("api/[controller]")]

    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Lintang Suminar Tyas Wening", Nim = "2211104009" },
            new Mahasiswa { Nama = "Rezky Pratiwi", Nim = "2211104029" },
            new Mahasiswa { Nama = "Aufa Muhammad Isyafalana", Nim = "2211104015" },
            new Mahasiswa { Nama = "Doanta Aloycius Ginting", Nim = "21104009" }
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> GetAll()
        {
            return daftarMahasiswa;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();
            return daftarMahasiswa[index];
        }

        [HttpPost]
        public ActionResult Post([FromBody] Mahasiswa mhs)
        {
            daftarMahasiswa.Add(mhs);
            return Ok();
        }

        [HttpDelete("{index}")]
        public ActionResult Delete(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();
            daftarMahasiswa.RemoveAt(index);
            return Ok();
        }
    }
}
