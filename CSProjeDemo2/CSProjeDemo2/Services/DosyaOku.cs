using CSProjeDemo2.Abstract;
using CSProjeDemo2.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Services
{
    public static class DosyaOku
    {
        public static List<DosyaDto> DosyaOkuma()
        {
            using (StreamReader r = new StreamReader("..\\..\\..\\personel.json"))
            {
                string json = r.ReadToEnd();
                List<DosyaDto> items = JsonConvert.DeserializeObject<List<DosyaDto>>(json);

                return items;
            }
           
        }
    }

    public class DosyaDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
    }
}


