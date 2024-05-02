using Microsoft.AspNetCore.Mvc;

namespace modul10_1302220085.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<string> courses = new List<string>
        {
            "KPL",
            "BD",
            "PBO"
        };

        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa("Mohammed Yousef Gumilar", "1302220085", courses, 2023),
            new Mahasiswa("Joshua Daniel Simanjunak", "1302220072", courses, 2023),
            new Mahasiswa("Irvan Dzawin Nuha", "1302220076", courses, 2023)
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa) 
        {
            mahasiswaList.Add(mahasiswa);
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswaList[id];
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswaList.RemoveAt(id);
        }

    }
}
